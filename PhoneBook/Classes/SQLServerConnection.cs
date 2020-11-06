using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;
namespace PhoneBook.Classes
{
    class DBClass
    {
        public static string GetConnectionStrings()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ToString();
            return connectionString;
        }
        public static string sql;
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataReader rd;
        public static DataTable dt;
        public static SqlDataAdapter da;

        public static void openConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = GetConnectionStrings();
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Фэйл. Сорян. " + Environment.NewLine +
                                "Описание: " + ex.Message.ToString(), "C# WPF Connection To SQLServer",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception)
            {
                //
            }
        }
    }
}
