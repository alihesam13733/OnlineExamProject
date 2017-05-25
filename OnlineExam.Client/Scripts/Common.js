
$('a.refresh-captcha').on('click', function (e) {
    e.preventDefault();
    $('.captcha-image').attr('src', "/Home/CaptchaImage"+ "?t=" + new Date().getTime());

});