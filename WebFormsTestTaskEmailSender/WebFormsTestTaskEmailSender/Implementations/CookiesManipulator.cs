using System;
using System.Web;

namespace WebFormsTestTaskEmailSender
{
    public class CookiesManipulator : ICookiesManipulator
    {
        private readonly HttpRequest _httprequest;

        public CookiesManipulator(HttpRequest httprequest)
        {
            _httprequest = httprequest;
        }

        public string GetCookie(string key)
        {
            if (_httprequest.Cookies[key].Value == null)
            {
                return string.Empty;
            }

            return _httprequest.Cookies[key].Value;
        }

        public HttpCookie SetCookie(string key, string value, int days)
        {
            HttpCookie cookie = new HttpCookie(key);
            cookie.Value = value;
            cookie.Expires = DateTime.UtcNow.AddDays(days);

            return cookie;
        }
    }
}