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
        public void EditArlyAIOnEditArlyAIButton(string ArlyText)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE ArlyAI SET ArlyText = @at WHERE ArlyAI.ID = 1", conn);

                cmd.Parameters.AddWithValue("at", ArlyText);

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
