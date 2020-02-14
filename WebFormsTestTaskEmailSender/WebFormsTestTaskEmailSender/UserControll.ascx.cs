using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsTestTaskEmailSender
{
    public partial class UserControll : System.Web.UI.UserControl
    {
        private IEmailValidator _emailValidator;
        private ICookiesManipulator _cookiesManipulator;

        private const string EMAIL = "Email";
        private const string MESSAGE = "Message";
        private const int COOKIE_LIFE_DAYS = 60;

        public UserControll()
        {
            _emailValidator = new EmailValidator();
            _cookiesManipulator = new CookiesManipulator(HttpContext.Current.Request);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            InvalidEmailLabel.Visible = false;

            SetFields();

            if (!IsPostBack)
            {
                GetCookiesAndSetForValues();
            }
        }

        protected void SendButton_Click(object sender, EventArgs e)
        {          
            string email = EmailInput.Text;

            if (_emailValidator.IsValid(email))
            {
                InvalidEmailLabel.Visible = false;
                Response.Redirect("SuccessPage.aspx");
            }
            else
            {
                InvalidEmailLabel.Visible = true;
            }
        }         
        protected void EmailInput_TextChanged(object sender, EventArgs e)
        {
            Response.Cookies.Add(_cookiesManipulator.SetCookie(EMAIL, EmailInput.Text
                , COOKIE_LIFE_DAYS));
        }

        protected void MessageInput_TextChanged(object sender, EventArgs e)
        {
            Response.Cookies.Add(_cookiesManipulator.SetCookie(MESSAGE, MessageInput.Text
                , COOKIE_LIFE_DAYS));
        }

        private void SetFields()
        {
            EmailLabel.Text = Resource.EmailLabel;
            MessageLabel.Text = Resource.MessageLabel;
            InvalidEmailLabel.Text = Resource.InvalidEmailLabel;
            SendButton.Text = Resource.SendButton;
        }

        private void GetCookiesAndSetForValues()
        {
            if (EmailInput.Text == string.Empty)
            {
                EmailInput.Text = _cookiesManipulator.GetCookie(EMAIL);
            }

            if (MessageInput.Text == string.Empty)
            {
                MessageInput.Text = _cookiesManipulator.GetCookie(MESSAGE);
            }
        }
    }
}