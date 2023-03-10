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
                ArlyOppgHeader.Text = row["ArlyOppgHeader"].ToString();
                ArlyOppgUnderHeader1.Text = row["ArlyOppgUnderHeader1"].ToString();
                ArlyOppgUnderHeader2.Text = row["ArlyOppgUnderHeader2"].ToString();
                ArlyOppgUnderHeader3.Text = row["ArlyOppgUnderHeader3"].ToString();
                ArlyOppgUnderHeader4.Text = row["ArlyOppgUnderHeader4"].ToString();
                ArlyOppgUnderHeader5.Text = row["ArlyOppgUnderHeader5"].ToString();
                ArlyOppgIntro.Text = row["ArlyOppgIntro"].ToString();
                GenerellBrukerstøtte1.Text = row["GenerellBrukerstøtte1"].ToString();
                GenerellBrukerstøtte2.Text = row["GenerellBrukerstøtte2"].ToString();
                GenerellBrukerstøtte3.Text = row["GenerellBrukerstøtte3"].ToString();
                GenerellBrukerstøtte4.Text = row["GenerellBrukerstøtte4"].ToString();
                GenerellBrukerstøtte5.Text = row["GenerellBrukerstøtte5"].ToString();
                ForedragBrukerstøtte1.Text = row["ForedragBrukerstøtte1"].ToString();
                ForedragBrukerstøtte2.Text = row["ForedragBrukerstøtte2"].ToString();
                ForedragBrukerstøtte3.Text = row["ForedragBrukerstøtte3"].ToString();
                ForedragBrukerstøtte4.Text = row["ForedragBrukerstøtte4"].ToString();
                AndreBrukerstøtte1.Text = row["AndreBrukerstøtte1"].ToString();
                AndreBrukerstøtte2.Text = row["AndreBrukerstøtte2"].ToString();
                Avslutning1.Text = row["Avslutning1"].ToString();
                Avslutning2.Text = row["Avslutning2"].ToString();
                Avslutning3.Text = row["Avslutning3"].ToString();
                Avslutning4.Text = row["Avslutning4"].ToString();
                Sammendrag.Text = row["Sammendrag"].ToString();
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