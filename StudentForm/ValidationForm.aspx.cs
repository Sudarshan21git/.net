using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentForm
{
    public partial class ValidationForm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void cvpw_validate(object source, ServerValidateEventArgs args)
        {
            string password = args.Value;
            args.IsValid = password.Length >= 6;  // Ensure password is at least 6 characters long
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Retrieve values from the form
                string name = txtName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string age = txtAge.Text;

                // Display the collected data in the result label
                result.Text = $"Name: {name}<br/>Email: {email}<br/>Password: {password}<br/>Age: {age}";
            }
        }
    }
}
