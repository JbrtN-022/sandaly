using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сандали.MyClass
{
    internal class CardTovarInZakaz
    {
        public static void SelectTovariInZakaz(string id)
        {
            ConnectionBD.myCommand.CommandText = $@"SELECT товар.article, товар.name as 'название',товар.description as 'описание',
            concat(товар.price - товар.price/100*товар.discount_percent) as'итоговая цена', состав_заказа.quantity  as 'кол-во в заказе'
            FROM up_02_2_2.товар,  up_02_2_2.состав_заказа 
            WHERE состав_заказа.article = товар.article and id_order={id};";
            ConnectionBD.dtTovariInZakaz.Clear();
            ConnectionBD.myDataAdapter.Fill(ConnectionBD.dtTovariInZakaz);
        }
        public static bool AddTovarInZakaz(string idOrder, string article, string quantity)
        {
            try
            {
                ConnectionBD.myCommand.CommandText = $@"
            INSERT INTO up_02_2_2.состав_заказа
            (id_order, article, quantity)
            VALUES
            ('{idOrder}','{article}','{quantity}')";

                if (ConnectionBD.myCommand.ExecuteNonQuery() != 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool DeleteTovarInZakaz(string article, string idOrder)
        {
            try
            {
                ConnectionBD.myCommand.CommandText = $@"
            DELETE FROM up_02_2_2.состав_заказа 
            WHERE article='{article}' AND id_order='{idOrder}'";

                if (ConnectionBD.myCommand.ExecuteNonQuery() != 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}

