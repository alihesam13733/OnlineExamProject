using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Web;
using System.Web.Mvc;

namespace OnlineExam.Utilities.PersianCaptcha
{
    /// <summary>
    /// برای بازگشت یک تصویر امنیتی در کنترلهای خود از نام این کلاس استفاده میکنیم
    /// و چون این نوع به صورت تو کار در ام وی سی وجود ندارد خودمان آن را تولید میکنیم 
    /// </summary>
    public class CaptchaImageResult : ActionResult
    {

        /// <summary>
        /// height captcha image
        /// </summary>
        private const int Height = 60;
        /// <summary>
        /// width captcha image
        /// </summary>
        private const int Width = 160;
        /// <summary>
        /// backgroundColor Captcha Image
        /// </summary>
        private readonly Color _backgroundColor = Color.FromArgb(255, 239, 239, 239);
        /// <summary>
        /// کلید رمزنگاری اطلاعات، این کلید باید با کلید رمزگشایی اطلاعات که در کلاس
        /// ValidateCaptchaAttribute
        /// تعریف شده است یکسان باشد
        /// </summary>
        private const string EncryptionKey = "AliHesam";
        /// <summary>
        /// FontFamily For Captcha Image
        /// </summary>
        private const string CaptchaFontFamily = "Tahoma";

        /// <summary>
        ///FontSize For Captcha Image
        /// </summary>
        private const int CaptchaFontSize = 10;


        public override void ExecuteResult(ControllerContext context)
        {
            //create a new 32bit bitmap image
            Bitmap bitmap = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
            //-- ایجاد یک شیء گرافیکی برای عملیات ترسیم روی تصویر امنیتی
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.PageUnit = GraphicsUnit.Pixel;
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            //-- پاک کردن پس زمینه تصویر امنیتی با یک رنگ سفید
            graphics.Clear(_backgroundColor);

            //Create a Random Number from 1000 to 9999
            int salt = CaptchaHelper.CreateSalt();

            //-- تاریخ فعلی (فقط روز فعلی) باید به کلید رمزنگاری اطلاعات اضافه شود
            //-- این کار به این هدف متفاوت بودن کلید رمزنگاری اطلاعات در هر روز صورت گرفته است
            string encryptionSaltKey = EncryptionKey + DateTime.Now.Date.ToString();

            //-- چسباندن عدد اتفاقی تولید شده به تاریخ و زمان فعلی با یک جدا کننده
            //-- توضیح: تاریخ و زمان فعلی باید در کورکی ذخیره شود تا هنگام رمزگشایی 
            //-- اطلاعات، اختلاف زمانی فی ما بین زمان ارسال فرم به مرورگر کاربر و زمان
            //-- ارسال فرم به سرور توسط کاربر محاسبه شود
            string plainText = salt.ToString() + "," + DateTime.Now.ToString();

            //-- رمزنگاری مقدار متغیر بالا جهت ذخیره در کوکی
            string encryptedValue = (plainText).Encrypt(encryptionSaltKey);

            //-- ذخیره کردن رشته رمزنگاری شده در کوکی
            HttpCookie cookie = new HttpCookie("captchastring");
            cookie.Value = encryptedValue;
            HttpContext.Current.Response.Cookies.Add(cookie);

            //-- تبدیل عدد اتفاقی تولید شده به حروف معادل
            string randomString = (salt).NumberToText(Language.Persian);

            //-- تنظیمات فرمت متن تصویر امنیتی
            var format = new StringFormat();
            int faLcid = new System.Globalization.CultureInfo("fa-IR").LCID;
            format.SetDigitSubstitution(faLcid, StringDigitSubstitute.National);
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            //-- نوع و اندازه قلم تصویر امنیتی
            Font font = new Font(CaptchaFontFamily, CaptchaFontSize);

            //-- ایجاد یک مسیر گرافیکی در تصویر امنیتی
            GraphicsPath path = new GraphicsPath();

            path.AddString(randomString,
                font.FontFamily,
                (int)font.Style,
                (graphics.DpiY * font.SizeInPoints / 72),
                new Rectangle(0, 0, Width, Height),
                format);

            Random random = new Random();

            //-- ایجاد رنگ متن تصویر امنیتی به صورت اتفاقی
            Pen pen = new Pen(Color.FromArgb(random.Next(0, 100), random.Next(0, 100), random.Next(0, 100)));
            graphics.DrawPath(pen, path);

            //-- ایجاد یک موج سینوسی و کسینوسی اتفاقی برای نوشتن حروف کد امنیتی در آن
            int distortion = random.Next(-10, 10);
            using (Bitmap copy = (Bitmap)bitmap.Clone())
            {
                for (int y = 0; y < Height; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        int newX = (int)(x + (distortion * Math.Sin(Math.PI * y / 64.0)));
                        int newY = (int)(y + (distortion * Math.Cos(Math.PI * x / 64.0)));
                        if (newX < 0 || newX >= Width) newX = 0;
                        if (newY < 0 || newY >= Height) newY = 0;
                        bitmap.SetPixel(x, y, copy.GetPixel(newX, newY));
                    }
                }
            }

            //-- اضافه کردن نویز به تصویر امنیتی
            int i, r, xx, yy, u, v;
            for (i = 1; i < 10; i++)
            {
                pen.Color = Color.FromArgb((random.Next(0, 255)), (random.Next(0, 255)), (random.Next(0, 255)));
                r = random.Next(0, (Width / 3));
                xx = random.Next(0, Width);
                yy = random.Next(0, Height);
                u = xx - r;
                v = yy - r;
                graphics.DrawEllipse(pen, u, v, r, r);
            }

            //-- رسم تصویر امنیتی
            graphics.DrawImage(bitmap, new Point(0, 0));
            graphics.Flush();

            //-- خروجی به عنوان یک تصویر jpeg و به صورت جریان به مرورگر کاربر فرستاده می شود
            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = "image/jpeg";
            context.HttpContext.DisableBrowserCache();
            bitmap.Save(response.OutputStream, ImageFormat.Jpeg);

            //-- آزاد سازی حافظه های اشغال شده
            font.Dispose();
            graphics.Dispose();
            bitmap.Dispose();
        }
    }
}
