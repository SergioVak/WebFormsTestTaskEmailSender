using System;

namespace WebFormsTestTaskEmailSender
{
    public partial class SuccessPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SuccessLabel.Text = Resource.SuccessLabel;
        }
    }
}