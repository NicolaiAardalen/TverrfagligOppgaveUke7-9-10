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
                EditArlyText.Text = row["ArlyText"].ToString();
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
            db.EditArlyAIOnEditArlyAIButton(EditArlyText.Text);
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