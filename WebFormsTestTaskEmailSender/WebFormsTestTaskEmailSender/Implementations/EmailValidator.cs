using System.ComponentModel.DataAnnotations;

namespace WebFormsTestTaskEmailSender
{
    public class EmailValidator : IEmailValidator
    {
        public bool IsValid(string email)
        {
            return email != null && new EmailAddressAttribute().IsValid(email);
        }
    }
}