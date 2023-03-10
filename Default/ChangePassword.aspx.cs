using BusinessLayer;
using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Default
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        private BLayer db = new BLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void backToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrasjon.aspx");
        }
        protected void ChangePassword_Click(object sender, EventArgs e)
        {
            var CurrentPassword = "";
            string EnteredPassword = ComputeSha256Hash(CurrentPasswordTextbox.Text);
            var GetAllDataFromText = db.GetAllDataFromBildeOgPassord();
            foreach (DataRow row in GetAllDataFromText.AsEnumerable())
            {
                CurrentPassword = row["Passord"].ToString();
            }
            if (CurrentPassword != EnteredPassword)
            {
                WrongPassword.Visible = true;
                return;
            }
            else
            {
                WrongPassword.Visible = false;
                db.ChangeLoginAdminPasswordOnButton(ComputeSha256Hash(NewPasswordTextbox.Text));
                Changed.Visible = true;
                ClientScript.RegisterStartupScript(this.GetType(), "redirectScript", "setTimeout(function() { window.location.replace('Administrasjon.aspx'); }, 1000);", true);
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
    }
}