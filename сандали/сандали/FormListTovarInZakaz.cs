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
    public partial class FormListTovarInZakaz : Form
    {
        public string id;
        public string selectedID;
        public FormListTovarInZakaz(string idTovar)
        {
            InitializeComponent();
            id = idTovar;
        }

        private void FormListTovarInZakaz_Load(object sender, EventArgs e)
        {
            MyClass.CardTovarInZakaz.SelectTovariInZakaz(id);
            dataGridView1.DataSource = ConnectionBD.dtTovariInZakaz;

            MyClass.ClassComboBox.TovariNotInZakaz(id);
            comboBoxTovar.DataSource = ConnectionBD.dtTovariNotInZakaz;
            comboBoxTovar.DisplayMember = "description";
            comboBoxTovar.ValueMember = "article";

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены что хотите удалить товар из заказа?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (CardTovarInZakaz.DeleteTovarInZakaz(selectedID, id))
                {
                    MessageBox.Show("Товар удален");

                    CardTovarInZakaz.SelectTovariInZakaz(id);
                    dataGridView1.DataSource = ConnectionBD.dtTovariInZakaz;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               
            }
        }

        private void textBoxKolVo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if ((textBoxKolVo.Text.Length > 0) && (comboBoxTovar.SelectedValue != null))
            {
                string tovar = comboBoxTovar.SelectedValue.ToString();
                string kolvo = textBoxKolVo.Text;

                if (CardTovarInZakaz.AddTovarInZakaz(id, tovar, kolvo))
                {
                    MessageBox.Show("Товар добавлен");

                    CardTovarInZakaz.SelectTovariInZakaz(id);
                    dataGridView1.DataSource = ConnectionBD.dtTovariInZakaz;
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }

        }
    }
}
