using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сандали.MyClass
{
    internal class CardTovar
    {

        public static void SelectListTovar(FlowLayoutPanel panel)
        {
            panel.Controls.Clear();

            ConnectionBD.myCommand.CommandText = @"SELECT article, категориятовара.name as 'категория товара', товар.name,
            description, производитель.name as 'производитель', поставщики.name as 'поставщики', price, единицы_изм.name as 'единицы измерения', stock_quantity,photo,discount_percent
            FROM up_02_2_2.товар ,  up_02_2_2.категориятовара, up_02_2_2.производитель, up_02_2_2.поставщики, up_02_2_2.единицы_изм
            where товар.category_id = категориятовара.id and товар.manufacturer_id = производитель.id and товар.supplier_id = поставщики.id and товар.unit_id = единицы_изм.id;";
             using (MySqlDataReader reader = ConnectionBD.myCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string article = reader["article"].ToString();
                    string kat = reader["категория товара"].ToString();
                    string name = reader["name"].ToString();
                    string desc = reader["description"].ToString();
                    string proizv = reader["производитель"].ToString();
                    string postav = reader["поставщики"].ToString();
                    string price = reader["price"].ToString();
                    string edIzm = reader["единицы измерения"].ToString();
                    string kolvo = reader["stock_quantity"].ToString();
                    string photo = reader["photo"].ToString();
                    string skidka = reader["discount_percent"].ToString();

                    UserControlTovar controlTovar = new UserControlTovar(article, kat, name, desc, proizv, postav, price,edIzm, kolvo, photo,skidka);
                    panel.Controls.Add(controlTovar);
                }
            }
        }

        public static bool AddTovar(string art,string name, string unitId, string SupplierId, string manufacId, string categoryId, string price, string discount, string quantity,string description, string photo)
        {
            try
            {
                ConnectionBD.myCommand.CommandText = $@"INSERT INTO up_02_2_2.товар (article,name,unit_id,supplier_id,manufacturer_id,category_id,price,discount_percent,stock_quantity,description,photo) 
                                    Values ('{art}','{name}','{unitId}','{SupplierId}','{manufacId}','{categoryId}','{price}','{discount}','{quantity}','{description}','{photo}');";
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
        public static bool UppTovar(string art, string name, string unitId, string SupplierId, string manufacId, string categoryId, string price, string discount, string quantity, string description, string photo)
        {
            try
            {
                ConnectionBD.myCommand.CommandText = $@"UPDATE up_02_2_2.товар 
                 SET name='{name}',unit_id='{unitId}',supplier_id='{SupplierId}',manufacturer_id='{manufacId}',category_id='{categoryId}',price='{price}',discount_percent='{discount}',
                 stock_quantity='{quantity}',description='{description}',photo='{photo}' WHERE article = '{art}'";
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
    }
}
