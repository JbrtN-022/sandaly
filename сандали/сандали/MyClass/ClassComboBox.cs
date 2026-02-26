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
            ConnectionBD.myCommand.CommandText = "SELECT * FROM up_02_2_2.поставщики;";
            ConnectionBD.dtPostavchik.Clear();
            ConnectionBD.myDataAdapter.Fill(ConnectionBD.dtPostavchik);
        }

        public static void EdinicaIzmereniya()
        {
            ConnectionBD.myCommand.CommandText = "SELECT * FROM up_02_2_2.единицы_изм;";
            ConnectionBD.dtEdinIzm.Clear();
            ConnectionBD.myDataAdapter.Fill(ConnectionBD.dtEdinIzm);
        }
    }
}
