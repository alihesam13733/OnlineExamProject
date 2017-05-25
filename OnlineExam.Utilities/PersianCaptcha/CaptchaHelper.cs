using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Utilities.PersianCaptcha
{
    public class CaptchaHelper
    {
        public static int CreateSalt()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }
}
