using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сандали.MyClass
{
    internal class ConnectionBD
    {
        public static string connectionString = @"Database = up_02_2_2; Data Source = localhost; user = root; password =qwerty; charset = utf8;";
        public static MySqlConnection myConnection;
        public static MySqlCommand myCommand;
        public static MySqlDataAdapter myDataAdapter;
        public static string login;
        public static string roll;
        public static string resFio; 
        public static DataTable dtKategoriya = new DataTable();
        public static DataTable dtPostavchik = new DataTable();
        public static DataTable dtProizvoditel = new DataTable();
        public static DataTable dtEdinIzm = new DataTable(); 
        public static DataTable dtTovariInZakaz = new DataTable();
        public static bool ConnectBD()
        {
            try
            {
                myConnection = new MySqlConnection(connectionString);
                myConnection.Open();
                myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                myDataAdapter = new MySqlDataAdapter(myCommand);
                return true;
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        public static void CloseBD()
        {
            myConnection.Close();
        }
    }
}
