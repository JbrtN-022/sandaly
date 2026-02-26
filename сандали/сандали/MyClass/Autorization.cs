using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сандали.MyClass
{
    internal class Autorization
    {
        public static void AutorizationBD(string log, string pass)
        {
            try { 
                ConnectionBD.myCommand.CommandText = $@"SELECT roll_id FROM up_02_2_2.пользователь where login ='{log}' and password='{pass}';";
                Object res = ConnectionBD.myCommand.ExecuteScalar();
                if (res  != null)
                {
                    ConnectionBD.roll = res.ToString();
                    ConnectionBD.login = log;
                } else
                {
                    ConnectionBD.roll = null;
                }                
            } catch (Exception e) 
            {
                ConnectionBD.login = ConnectionBD.roll = null;
                MessageBox.Show(e.Message);
            }
        }

        public static void GetFioUser(string log, string pass)
        {
            try
            {
                ConnectionBD.myCommand.CommandText = $@"SELECT FIO FROM up_02_2_2.пользователь where login ='{log}' and password='{pass}';";
                Object fio = ConnectionBD.myCommand.ExecuteScalar();
                if (fio != null)
                {
                    ConnectionBD.resFio = fio.ToString();
                }
                else
                {
                    ConnectionBD.resFio = null;
                }
            }
            catch (Exception e)
            {
                ConnectionBD.login = ConnectionBD.roll = null;
                MessageBox.Show(e.Message);
            } 
        }
    }
}
