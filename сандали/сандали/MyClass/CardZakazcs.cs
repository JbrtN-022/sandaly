using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сандали.MyClass
{
    internal class CardZakazcs
    {
        public static void SelectCardZakaz(FlowLayoutPanel panel)
        {
            panel.Controls.Clear();

            ConnectionBD.myCommand.CommandText = @"SELECT  заказ.id_order, заказ.PickupCode, статус_зак.status, пункт_выдачи.adress, 
                    заказ.OrderDate, заказ.DeliveryDate,
                        (SELECT SUM(
                                (товар.price - товар.price/100*товар.discount_percent)
                                * состав_заказа.quantity)
                            FROM up_02_2_2.состав_заказа
                            JOIN up_02_2_2.товар 
                                ON состав_заказа.article = товар.article
                            WHERE состав_заказа.id_order = заказ.id_order
                        ) AS 'стоимость заказа'
                    FROM up_02_2_2.заказ
                    JOIN up_02_2_2.статус_зак 
                        ON статус_зак.id_status = заказ.id_status
                    JOIN up_02_2_2.пункт_выдачи 
                        ON пункт_выдачи.id_pick_up_point = заказ.id_pick_up_point;";
            using (MySqlDataReader reader = ConnectionBD.myCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string id = reader["id_order"].ToString();
                    string NumZakaza = reader["PickupCode"].ToString();
                    string status = reader["status"].ToString();
                    string adress = reader["adress"].ToString() ;
                    string DateZak = reader["OrderDate"].ToString();
                    string DelivZak = reader["DeliveryDate"].ToString();
                    string stoimostZak = reader["стоимость заказа"].ToString();

                    UserControlZakaz user = new UserControlZakaz(id, NumZakaza, status, adress, DateZak, DelivZak, stoimostZak);
                    panel.Controls.Add(user);
                }
            }
        }
        public static void SelectTovariInZakaz(string id)
        {
            ConnectionBD.myCommand.CommandText = $@"SELECT товар.article, товар.name as 'название',товар.description as 'описание',
            concat(товар.price - товар.price/100*товар.discount_percent) as'итоговая цена', состав_заказа.quantity  as 'кол-во в заказе'
            FROM up_02_2_2.товар,  up_02_2_2.состав_заказа 
            WHERE состав_заказа.article = товар.article and id_order={id};";
            ConnectionBD.dtTovariInZakaz.Clear();
            ConnectionBD.myDataAdapter.Fill(ConnectionBD.dtTovariInZakaz);
        }
    }
}
