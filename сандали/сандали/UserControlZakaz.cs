using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace сандали
{
    public partial class UserControlZakaz : UserControl
    {
        public string IdZak, NumZak, StatusZak, DataZakaza, AdresPunkt, DataDostavk, Stoimost;

        private void button1_Click(object sender, EventArgs e)
        {
            FormListTovarInZakaz form = new FormListTovarInZakaz(IdZak);
            form.ShowDialog();
            FormListTovar parent = this.FindForm() as FormListTovar;

            if (parent != null)
            {
                parent.LoadTovars();
            }

        }

        public UserControlZakaz(string id, string NumZakaza, string Status,string adress, string DateZak, string DelivZak, string stoimostZak)
        {
            InitializeComponent();
            IdZak = id;
            NumZak = NumZakaza;
            StatusZak = Status;
            AdresPunkt = adress;
            DataZakaza = DateZak;
            DataDostavk = DelivZak;
            Stoimost = stoimostZak;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlZakaz_Load(object sender, EventArgs e)
        {
            label1.Text = $@"Дата доставки {DataDostavk} ";
            label2.Text = $@"Номер заказа {NumZak} | Стоимость заказа: {Stoimost}";
            label3.Text = $@"Статус заказа: {StatusZak}";
            label4.Text = $@"Адрес пункта выдачи: {AdresPunkt}";
            label5.Text = $@"Дата заказа: {DataZakaza}";
        }
    }
}
