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

    }
}
