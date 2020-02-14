using System.Web;

namespace WebFormsTestTaskEmailSender
{
    public interface ICookiesManipulator
    {
        string GetCookie(string key);
        HttpCookie SetCookie(string key, string value, int days); 
    }
}
