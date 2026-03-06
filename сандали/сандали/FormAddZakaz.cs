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
    public partial class FormAddZakaz : Form
    {
        public FormAddZakaz()
        {
            InitializeComponent();
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

        private void FormAddZakaz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Num = textBoxNumZak.Text;
            string orderDate = dateTimePickerZakaza.Value.ToString("yyyy-MM-dd");
            string deliveryDate = dateTimePickerVidachi.Value.ToString("yyyy-MM-dd");
            ConnectionBD.myCommand.CommandText = $@"SELECT id_client 
                                                FROM up_02_2_2.пользователь 
                                                where FIO = '{ConnectionBD.resFio}' and login='{ConnectionBD.login}';";
            string id = (ConnectionBD.myCommand.ExecuteScalar()).ToString();
            string point = comboBoxAdres.SelectedValue.ToString();
            string status = comboBoxStatus.SelectedValue.ToString();

            if (CardZakaz.AddZakaz(orderDate, deliveryDate, point, id, Num,status))
            {
                MessageBox.Show("Заказ добавлен");
                this.Close();
            }
        }
    }
}
