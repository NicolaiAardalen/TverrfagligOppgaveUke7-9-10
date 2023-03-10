using BusinessLayer;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;
using File = System.IO.File;

namespace Default
{
    public partial class Administrasjon : System.Web.UI.Page
    {
        private BLayer db = new BLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Text();
                Dropdown();
                GetImage();
            }
        }
        public void Text()
        {
            var GetAllDataFromText = db.GetAllDataFromArlyAI();
            foreach (DataRow row in GetAllDataFromText.AsEnumerable())
            {
                EditArlyOppgHeader.Text = row["ArlyOppgHeader"].ToString();
                EditArlyOppgUnderHeader1.Text = row["ArlyOppgUnderHeader1"].ToString();
                EditArlyOppgUnderHeader2.Text = row["ArlyOppgUnderHeader2"].ToString();
                EditArlyOppgUnderHeader3.Text = row["ArlyOppgUnderHeader3"].ToString();
                EditArlyOppgUnderHeader4.Text = row["ArlyOppgUnderHeader4"].ToString();
                EditArlyOppgUnderHeader5.Text = row["ArlyOppgUnderHeader5"].ToString();
                EditArlyOppgIntro.Text = row["ArlyOppgIntro"].ToString();
                EditGenerellBrukerstøtte1.Text = row["GenerellBrukerstøtte1"].ToString();
                EditGenerellBrukerstøtte2.Text = row["GenerellBrukerstøtte2"].ToString();
                EditGenerellBrukerstøtte3.Text = row["GenerellBrukerstøtte3"].ToString();
                EditGenerellBrukerstøtte4.Text = row["GenerellBrukerstøtte4"].ToString();
                EditGenerellBrukerstøtte5.Text = row["GenerellBrukerstøtte5"].ToString();
                EditForedragBrukerstøtte1.Text = row["ForedragBrukerstøtte1"].ToString();
                EditForedragBrukerstøtte2.Text = row["ForedragBrukerstøtte2"].ToString();
                EditForedragBrukerstøtte3.Text = row["ForedragBrukerstøtte3"].ToString();
                EditForedragBrukerstøtte4.Text = row["ForedragBrukerstøtte4"].ToString();
                EditAndreBrukerstøtte1.Text = row["AndreBrukerstøtte1"].ToString();
                EditAndreBrukerstøtte2.Text = row["AndreBrukerstøtte2"].ToString();
                EditAvslutning1.Text = row["Avslutning1"].ToString();
                EditAvslutning2.Text = row["Avslutning2"].ToString();
                EditAvslutning3.Text = row["Avslutning3"].ToString();
                EditAvslutning4.Text = row["Avslutning4"].ToString();
                EditSammendrag.Text = row["Sammendrag"].ToString();
            }
        }
        private void GetImage()
        {
            try
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
                DropDownListImg.SelectedValue = imgnavn;
            }
            catch (Exception) { }
        }
        private void Dropdown()
        {
            string folderPath = Server.MapPath("~/Img/");

            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                string fileExtention = Path.GetExtension(file);
                string fileName = Path.GetFileName(file).Replace(fileExtention, "");
                DropDownListImg.Items.Add(fileName);
            }
        }
        protected void ChangeImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (DropDownListImg.SelectedItem == null)
                {
                    return;
                }
                string imagename = DropDownListImg.SelectedItem.Text;
                db.EditImageOnDropDownListAndButton(imagename);
                GetImage();
            }
            catch (Exception) { }
        }
        protected void DeleteImage_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Img/");

            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                string fileExtention = Path.GetExtension(file);
                string fileName = Path.GetFileName(file).Replace(fileExtention, "");
                if (fileName == DropDownListImg.SelectedItem.Text)
                {
                    string dropdownvalue = DropDownListImg.SelectedItem.Text;
                    File.Delete(folderPath + dropdownvalue + fileExtention);
                    GetImage();
                    DropDownListImg.Items.Clear();
                    Dropdown();
                    return;
                }
            }
        }
        protected void Default_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void EditArlyAI_Click(object sender, EventArgs e)
        {
            db.EditArlyAIOnEditArlyAIButton(EditArlyOppgHeader.Text, EditArlyOppgUnderHeader1.Text, EditArlyOppgUnderHeader2.Text, EditArlyOppgUnderHeader3.Text, EditArlyOppgUnderHeader4.Text, EditArlyOppgUnderHeader5.Text, EditArlyOppgIntro.Text, EditGenerellBrukerstøtte1.Text, EditGenerellBrukerstøtte2.Text, EditGenerellBrukerstøtte3.Text, EditGenerellBrukerstøtte4.Text, EditGenerellBrukerstøtte5.Text, EditForedragBrukerstøtte1.Text, EditForedragBrukerstøtte2.Text, EditForedragBrukerstøtte3.Text, EditForedragBrukerstøtte4.Text, EditAndreBrukerstøtte1.Text, EditAndreBrukerstøtte2.Text, EditAvslutning1.Text, EditAvslutning2.Text, EditAvslutning3.Text, EditAvslutning4.Text, EditSammendrag.Text);
            Text();
        }
        protected void UploadImage_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Img/");
            try
            {
                FileUpload.SaveAs(folderPath + FileUpload.FileName);
                DropDownListImg.Items.Clear();
                Dropdown();
            }
            catch (Exception) { }
        }
    }
}