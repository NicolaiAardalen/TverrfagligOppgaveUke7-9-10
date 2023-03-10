using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLayer
{
    public class DBLayer
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        public DataTable GetAllDataFromArlyAI()
        {
            try
            {
                DataTable weatherReadings = new DataTable();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM ArlyAI", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                weatherReadings.Load(reader);
                conn.Close();

                return weatherReadings;

            }
            catch (ArgumentOutOfRangeException) { return null; }
        }
        public DataTable GetAllDataFromBildeOgPassord()
        {
            try
            {
                DataTable weatherReadings = new DataTable();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM BildeOgPassord", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                weatherReadings.Load(reader);
                conn.Close();

                return weatherReadings;

            }
            catch (ArgumentOutOfRangeException) { return null; }
        }
        public void EditImageOnDropDownListAndButton(string Bilde)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE BildeOgPassord SET Bilde = @bilde", conn);

                cmd.Parameters.AddWithValue("bilde", Bilde);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception) { }
        }
        public void EditArlyAIOnEditArlyAIButton(string ArlyOppgHeader, string ArlyOppgUnderHeader1, string ArlyOppgUnderHeader2, string ArlyOppgUnderHeader3, string ArlyOppgUnderHeader4, string ArlyOppgUnderHeader5, string ArlyOppgIntro, string GenerellBrukerstøtte1, string GenerellBrukerstøtte2, string GenerellBrukerstøtte3, string GenerellBrukerstøtte4, string GenerellBrukerstøtte5, string ForedragBrukerstøtte1, string ForedragBrukerstøtte2, string ForedragBrukerstøtte3, string ForedragBrukerstøtte4, string AndreBrukerstøtte1, string AndreBrukerstøtte2, string Avslutning1, string Avslutning2, string Avslutning3, string Avslutning4, string Sammendrag)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE ArlyAI SET ArlyOppgHeader = @aoh, ArlyOppgUnderHeader1 = @aouh1, ArlyOppgUnderHeader2 = @aouh2, ArlyOppgUnderHeader3 = @aouh3, ArlyOppgUnderHeader4 = @aouh4, ArlyOppgUnderHeader5 = @aouh5, ArlyOppgIntro = @aoi, GenerellBrukerstøtte1 = @gbs1, GenerellBrukerstøtte2 = @gbs2, GenerellBrukerstøtte3 = @gbs3, GenerellBrukerstøtte4 = @gbs4, GenerellBrukerstøtte5 = @gbs5, ForedragBrukerstøtte1 = @fbs1, ForedragBrukerstøtte2 = @fbs2, ForedragBrukerstøtte3 = @fbs3, ForedragBrukerstøtte4 = @fbs4, AndreBrukerstøtte1 = @abs1, AndreBrukerstøtte2 = @abs2, Avslutning1 = @avs1, Avslutning2 = @avs2, Avslutning3 = @avs3, Avslutning4 = @avs4, Sammendrag = @smd WHERE ArlyAI.ID = 1", conn);

                cmd.Parameters.AddWithValue("aoh", ArlyOppgHeader);
                cmd.Parameters.AddWithValue("aouh1", ArlyOppgUnderHeader1);
                cmd.Parameters.AddWithValue("aouh2", ArlyOppgUnderHeader2);
                cmd.Parameters.AddWithValue("aouh3", ArlyOppgUnderHeader3);
                cmd.Parameters.AddWithValue("aouh4", ArlyOppgUnderHeader4);
                cmd.Parameters.AddWithValue("aouh5", ArlyOppgUnderHeader5);
                cmd.Parameters.AddWithValue("aoi", ArlyOppgIntro);
                cmd.Parameters.AddWithValue("gbs1", GenerellBrukerstøtte1);
                cmd.Parameters.AddWithValue("gbs2", GenerellBrukerstøtte2);
                cmd.Parameters.AddWithValue("gbs3", GenerellBrukerstøtte3);
                cmd.Parameters.AddWithValue("gbs4", GenerellBrukerstøtte4);
                cmd.Parameters.AddWithValue("gbs5", GenerellBrukerstøtte5);
                cmd.Parameters.AddWithValue("fbs1", ForedragBrukerstøtte1);
                cmd.Parameters.AddWithValue("fbs2", ForedragBrukerstøtte2);
                cmd.Parameters.AddWithValue("fbs3", ForedragBrukerstøtte3);
                cmd.Parameters.AddWithValue("fbs4", ForedragBrukerstøtte4);
                cmd.Parameters.AddWithValue("abs1", AndreBrukerstøtte1);
                cmd.Parameters.AddWithValue("abs2", AndreBrukerstøtte2);
                cmd.Parameters.AddWithValue("avs1", Avslutning1);
                cmd.Parameters.AddWithValue("avs2", Avslutning2);
                cmd.Parameters.AddWithValue("avs3", Avslutning3);
                cmd.Parameters.AddWithValue("avs4", Avslutning4);
                cmd.Parameters.AddWithValue("smd", Sammendrag);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (ArgumentOutOfRangeException) { }
        }
        public void ChangeLoginAdminPasswordOnButton(string NewPass)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE BildeOgPassord SET Passord = @np", conn);

                cmd.Parameters.AddWithValue("np", NewPass);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception) { }
        }
    }
}
