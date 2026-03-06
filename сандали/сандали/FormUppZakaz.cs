using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using сандали.MyClass;

namespace сандали
{
    public partial class FormUppZakaz : Form
    {
        public string Id;
        public FormUppZakaz(string IdZak)
        {
            InitializeComponent();
            Id = IdZak;
            ClassComboBox.StatusZakaza();
            ClassComboBox.PunktVidachi();

            comboBoxStatus.DataSource = ConnectionBD.dtStatusZak;
            comboBoxStatus.DisplayMember = "status";
            comboBoxStatus.ValueMember = "id_status";
            comboBoxStatus.SelectedIndex = 0;

            comboBoxAdres.DataSource = ConnectionBD.dtPunktVidachi;
            comboBoxAdres.DisplayMember = "adress";
            comboBoxAdres.ValueMember = "id_pick_up_point";
            comboBoxAdres.SelectedIndex = 0;
        }

        private void FormUppZakaz_Load(object sender, EventArgs e)
        {
           CardZakaz.SelectZakazForUpp(Id);
            ConnectionBD.myCommand.CommandText =
    $@"SELECT PickupCode,OrderDate,DeliveryDate,id_pick_up_point,id_status 
       FROM up_02_2_2.заказ 
       WHERE id_order={Id}";

            using (MySqlDataReader reader = ConnectionBD.myCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    textBoxNumZak.Text = Convert.ToString(reader["PickupCode"]);
                    dateTimePickerVidachi.Value = Convert.ToDateTime(reader["OrderDate"]);
                    dateTimePickerZakaza.Value = Convert.ToDateTime(reader["DeliveryDate"]);

                    comboBoxAdres.SelectedValue = reader["id_pick_up_point"].ToString();
                    comboBoxStatus.SelectedValue = reader["id_status"].ToString();
                }
            }
        }

        private void buttonUpp_Click(object sender, EventArgs e)
        {
            string orderDate = dateTimePickerVidachi.Value.ToString("yyyy-MM-dd");
            string deliveryDate = dateTimePickerZakaza.Value.ToString("yyyy-MM-dd");

            string point = comboBoxAdres.SelectedValue.ToString();
            string status = comboBoxStatus.SelectedValue.ToString();

            if (CardZakaz.UpdateZakaz(Id, orderDate, deliveryDate, point, status))
            {
                MessageBox.Show("Заказ обновлен");
                this.Close();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (CardZakaz.ZakazHasTovar(Id))
            {
                MessageBox.Show("Нельзя удалить заказ, так как в нем есть товары");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы уверены что хотите удалить заказ?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (CardZakaz.DeleteZakaz(Id))
                {
                    MessageBox.Show("Заказ удален");
                    this.Close();
                }
            }
        }
    }
}
