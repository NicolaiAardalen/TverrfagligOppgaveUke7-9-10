using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tverrfaglig_Prosjekt_uke_7__9__10
{
    public partial class Default : System.Web.UI.Page
    {
        protected BLayer db = new BLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Text();
            }
        }
        public void Text()
        {
            var AllDataInDefault = db.GetAllDataFromDefault();
            var Kol1 = (from DataRow row in AllDataInDefault
                        select new
                        {
                            Kol1 = row["Kol1"].ToString()
                        }).ToString();

            Label1.Text = Kol1;
        }
    }
}