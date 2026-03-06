using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сандали.MyClass
{
    internal class ClassComboBox
    {
        public static void KategoriyaTovara()
        {
            ConnectionBD.myCommand.CommandText = "SELECT * FROM up_02_2_2.категориятовара;";
            ConnectionBD.dtKategoriya.Clear();
            ConnectionBD.myDataAdapter.Fill(ConnectionBD.dtKategoriya);
        }
        public static void Proizvoditel()
        {
            ConnectionBD.myCommand.CommandText = "SELECT * FROM up_02_2_2.производитель;;";
            ConnectionBD.dtProizvoditel.Clear();
            ConnectionBD.myDataAdapter.Fill(ConnectionBD.dtProizvoditel);
        }
        public static void Postavchik()
        {
            ConnectionBD.myCommand.CommandText = "SELECT id,name FROM up_02_2_2.поставщики;";
            ConnectionBD.dtPostavchik.Clear();
            ConnectionBD.myDataAdapter.Fill(ConnectionBD.dtPostavchik);
        }

        public static void EdinicaIzmereniya()
        {
            ConnectionBD.myCommand.CommandText = "SELECT * FROM up_02_2_2.единицы_изм;";
            ConnectionBD.dtEdinIzm.Clear();
            ConnectionBD.myDataAdapter.Fill(ConnectionBD.dtEdinIzm);
        }
        public static void StatusZakaza()
        {
            ConnectionBD.myCommand.CommandText = "SELECT * FROM up_02_2_2.статус_зак;";
            ConnectionBD.dtStatusZak.Clear();
            ConnectionBD.myDataAdapter.Fill(ConnectionBD.dtStatusZak);
        }

        public static void PunktVidachi()
        {
            ConnectionBD.myCommand.CommandText = "SELECT * FROM up_02_2_2.пункт_выдачи;";
            ConnectionBD.dtPunktVidachi.Clear();
            ConnectionBD.myDataAdapter.Fill(ConnectionBD.dtPunktVidachi);
        }

        public static void TovariNotInZakaz(string id)
        {
            ConnectionBD.myCommand.CommandText = $@"SELECT товар.article, товар.description
                                                    FROM up_02_2_2.товар 
                                                    WHERE article NOT IN (
                                                        SELECT article 
                                                        FROM up_02_2_2.состав_заказа 
                                                        WHERE id_order = {id}
                                                    );";
            ConnectionBD.dtTovariNotInZakaz.Clear();
            ConnectionBD.myDataAdapter.Fill(ConnectionBD.dtTovariNotInZakaz);
        }
    }
}
