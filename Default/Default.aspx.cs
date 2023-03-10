using BusinessLayer;
using System;
using System.Data;
using System.IO;
using System.Linq;

namespace Default
{
    public partial class Default : System.Web.UI.Page
    {
        private BLayer db = new BLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Text();
                GetImage();
            }
        }
        public void Text()
        {
            var GetAllDataFromText = db.GetAllDataFromArlyAI();
            foreach (DataRow row in GetAllDataFromText.AsEnumerable())
            {
                ArlyText.Text = row["ArlyText"].ToString();
            }
        }
        private void GetImage()
        {
            var GetAllDataFromBildeOgPassord = db.GetAllDataFromBildeOgPassord();
            var imgnavn = "";

            foreach (DataRow row in GetAllDataFromBildeOgPassord.AsEnumerable())
            {
                imgnavn = row["Bilde"].ToString();
            }
            string folderPath = Server.MapPath("~/Img/");

            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                string fileExtention = Path.GetExtension(file);
                string fileName = Path.GetFileName(file).Replace(fileExtention, "");
                if (fileName == imgnavn)
                {
                    Image.ImageUrl = $"Img/{imgnavn}{fileExtention}";
                }
            }
        }
        protected void Administrasjon_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrasjon.aspx");
        }
    }
}