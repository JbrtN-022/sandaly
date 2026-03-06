using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
        public static void SelectListTovar(FlowLayoutPanel panel, int postav = 0, bool sort = true, string search = "")
        {
            panel.Controls.Clear();
            string sql = @"
            SELECT article,
	            категориятовара.name as 'категория товара',
	            товар.name,
	            description,
	            производитель.name as 'производитель',
	            поставщики.name as 'поставщики',
	            price,
	            единицы_изм.name as 'единицы измерения',
	            stock_quantity,
	            photo,
	            discount_percent
            FROM up_02_2_2.товар
            JOIN  up_02_2_2.категориятовара ON товар.category_id = категориятовара.id
            JOIN up_02_2_2.производитель ON товар.manufacturer_id = производитель.id
            JOIN up_02_2_2.поставщики ON товар.supplier_id = поставщики.id 
            JOIN up_02_2_2.единицы_изм ON товар.unit_id = единицы_изм.id WHERE 1=1";


            if (!string.IsNullOrEmpty(search))
            {
                sql += $@" and (товар.name LIKE '%{search}%' or 
                        description LIKE '%{search}%' or 
                        производитель.name LIKE '%{search}%' or
                        поставщики.name LIKE '%{search}%' or
                        единицы_изм.name LIKE '%{search}%' or
                        категориятовара.name LIKE '%{search}%')";
            }
            if (postav != 0)
            {
                sql += $@"and товар.supplier_id = '{postav}'";
            }
            if (sort)
            {
                sql += $@" order by stock_quantity asc";
            }
            else
            {
                sql += $@" ORDER BY stock_quantity desc";
            }
            ConnectionBD.myCommand.CommandText = sql;
            using (MySqlDataReader reader = ConnectionBD.myCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string article = reader["article"].ToString();
                    string Kateg = reader["категория товара"].ToString();
                    string name = reader["name"].ToString();
                    string description = reader["description"].ToString();
                    string Proizvod = reader["производитель"].ToString();
                    string postavchik = reader["поставщики"].ToString();
                    string price = reader["price"].ToString();
                    string Edizm = reader["единицы измерения"].ToString();
                    string stock = reader["stock_quantity"].ToString();
                    string photo = reader["photo"].ToString();
                    string discount = reader["discount_percent"].ToString();
                    UserControlTovar user = new UserControlTovar(article, Kateg, name, description, Proizvod, postavchik, price, Edizm, stock, photo, discount);
                    panel.Controls.Add(user);
                }
            }
        }


        public static bool AddTovar(string art, string name, string unitId, string SupplierId, string manufacId, string categoryId, string price, string discount, string quantity, string description, string photo)
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
            }
            catch (Exception ex)
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

        public static int SearchTovarForDelete(string art)
        {
            try
            {
                ConnectionBD.myCommand.CommandText = $@"SELECT count(*) FROM up_02_2_2.состав_заказа where article = '{art}';";
                object res = ConnectionBD.myCommand.ExecuteScalar();
                return int.Parse(res.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public static bool DeleteTovar(string art)
        {
            try
            {
                ConnectionBD.myCommand.CommandText = $@"DELETE from up_02_2_2.товар where article = '{art}';";
                if (ConnectionBD.myCommand.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}

