using BusinessLayer;
using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;

namespace Default
{
    public partial class Login : System.Web.UI.Page
    {
        private BLayer db = new BLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckPassword_Click(object sender, EventArgs e)
        {
            var GetAllDataFromBildeOgPassord = db.GetAllDataFromBildeOgPassord();
            var LoginPassword = "";
            foreach (DataRow row in GetAllDataFromBildeOgPassord.AsEnumerable())
            {
                LoginPassword = row["Passord"].ToString();
            }
            string hashed = ComputeSha256Hash(LoginPasswordTextbox.Text);
            if (hashed == LoginPassword)
            {
                FormsAuthentication.RedirectFromLoginPage(LoginPassword, false);
            }
            else
            {
                WrongPassword.Visible = true;
            }
        }
        static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        protected void BackToSite_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            ChangePassword.NavigateUrl = "ChangePassword.aspx";
        }
    }
}