using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сандали.MyClass
{
    internal class CardZakaz
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
        public static bool AddZakaz(string dateOrder, string dateDelivery, string idPoint,string client,string pickup,  string idStatus)
        {
            try
            {
                ConnectionBD.myCommand.CommandText = $@"
        INSERT INTO up_02_2_2.заказ
        (OrderDate, DeliveryDate, id_pick_up_point,id_client,PickupCode, id_status)
        VALUES
        ('{dateOrder}','{dateDelivery}','{idPoint}','{client}','{pickup}','{idStatus}')";

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
        public static bool UpdateZakaz(string id, string orderDate, string deliveryDate, string point, string status)
        {
            try
            {
                ConnectionBD.myCommand.CommandText = $@"
        UPDATE up_02_2_2.заказ
        SET
        OrderDate='{orderDate}',
        DeliveryDate='{deliveryDate}',
        id_pick_up_point='{point}',
        id_status='{status}'
        WHERE id_order='{id}'";

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
        public static bool SelectZakazForUpp(string id)
        {
            
            try
            {
                ConnectionBD.myCommand.CommandText = $@"SELECT OrderDate,DeliveryDate,id_pick_up_point,PickupCode,id_status FROM up_02_2_2.заказ where id_order={id};";
                if (ConnectionBD.myCommand.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool DeleteZakaz(string id)
        {
            try
            {
                ConnectionBD.myCommand.CommandText = $@"DELETE from up_02_2_2.заказ where id_order = '{id}'";
                if (ConnectionBD.myCommand.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool ZakazHasTovar(string id)
        {
            try
            {
                ConnectionBD.myCommand.CommandText = $@"
        SELECT COUNT(*) 
        FROM up_02_2_2.состав_заказа
        WHERE id_order = '{id}'";

                int count = Convert.ToInt32(ConnectionBD.myCommand.ExecuteScalar());

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }
    }
}
