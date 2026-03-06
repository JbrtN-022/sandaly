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
        public static string ConnectionString = @"Database = up_02_2_2; Data Source = localhost; user=root;password=qwerty;charset=utf8;";
        public static MySqlDataAdapter myDataAdapter;
        public static MySqlCommand myCommand;
        public static MySqlConnection myConnection;
        public static string login;
        public static string roll;
        public static string resFio; 
        public static DataTable dtKategoriya = new DataTable();
        public static DataTable dtPostavchik = new DataTable();
        public static DataTable dtProizvoditel = new DataTable();
        public static DataTable dtStatusZak = new DataTable();
        public static DataTable dtPunktVidachi = new DataTable();
        public static DataTable dtTovariNotInZakaz = new DataTable();
        public static DataTable dtEdinIzm = new DataTable(); 
        public static DataTable dtTovariInZakaz = new DataTable();
        
        public static bool ConnectBd()
        {
            try
            {
                myConnection = new MySqlConnection(ConnectionString);
                myConnection.Open();
                myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                myDataAdapter = new MySqlDataAdapter(myCommand);
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static void CloseBD()
        {
            myConnection.Close();
        }
        
    }
}
