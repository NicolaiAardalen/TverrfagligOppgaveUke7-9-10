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
        public void EditArlyAIOnEditArlyAIButton(string ArlyOppgHeader, string ArlyOppgUnderHeader1, string ArlyOppgUnderHeader2, string ArlyOppgUnderHeader3, string ArlyOppgUnderHeader4, string ArlyOppgUnderHeader5, string ArlyOppgIntro, string GenerellBrukerstøtte1, string GenerellBrukerstøtte2, string GenerellBrukerstøtte3, string GenerellBrukerstøtte4, string GenerellBrukerstøtte5, string ForedragBrukerstøtte1, string ForedragBrukerstøtte2, string ForedragBrukerstøtte3, string ForedragBrukerstøtte4, string AndreBrukerstøtte1, string AndreBrukerstøtte2, string Avslutning1, string Avslutning2, string Avslutning3, string Avslutning4, string Sammendrag)
        {
            dbl.EditArlyAIOnEditArlyAIButton(ArlyOppgHeader, ArlyOppgUnderHeader1, ArlyOppgUnderHeader2, ArlyOppgUnderHeader3, ArlyOppgUnderHeader4, ArlyOppgUnderHeader5, ArlyOppgIntro, GenerellBrukerstøtte1, GenerellBrukerstøtte2, GenerellBrukerstøtte3, GenerellBrukerstøtte4, GenerellBrukerstøtte5, ForedragBrukerstøtte1, ForedragBrukerstøtte2, ForedragBrukerstøtte3, ForedragBrukerstøtte4, AndreBrukerstøtte1, AndreBrukerstøtte2, Avslutning1, Avslutning2, Avslutning3, Avslutning4, Sammendrag);
        }
        public void ChangeLoginAdminPasswordOnButton(string NewPass)
        {
            dbl.ChangeLoginAdminPasswordOnButton(NewPass);
        }
    }
}
