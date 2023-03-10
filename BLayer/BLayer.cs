using DatabaseLayer;
using System.Data;

namespace BusinessLayer
{
    public class BLayer
    {
        private DBLayer dbl = new DBLayer();
        public DataTable GetAllDataFromArlyAI()
        {
            return dbl.GetAllDataFromArlyAI();
        }
        public DataTable GetAllDataFromBildeOgPassord()
        {
            return dbl.GetAllDataFromBildeOgPassord();
        }
        public void EditImageOnDropDownListAndButton(string Bilde)
        {
            dbl.EditImageOnDropDownListAndButton(Bilde);
        }
        public void EditArlyAIOnEditArlyAIButton(string ArlyText)
        {
            dbl.EditArlyAIOnEditArlyAIButton(ArlyText);
        }
        public void ChangeLoginAdminPasswordOnButton(string NewPass)
        {
            dbl.ChangeLoginAdminPasswordOnButton(NewPass);
        }
    }
}
