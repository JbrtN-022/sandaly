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
    public partial class FormListTovar : Form
    {
        public FormListTovar()
        {
            InitializeComponent();
        }

        private void FormListTovar_Load(object sender, EventArgs e)
        {
            ClassComboBox.Postavchik();
            CardTovar.SelectListTovar(flowLayoutPanel1);
            comboBoxSort.Items.Add("По возрастанию");
            comboBoxSort.Items.Add("По убыванию");
            comboBoxSort.SelectedIndex = 0;

            if (!ConnectionBD.dtPostavchik.AsEnumerable().Any(r => r["id"].ToString() == "0"))
            {
                DataRow row = ConnectionBD.dtPostavchik.NewRow();
                row["id"] = 0;
                row["name"] = "Все поставщики";
                ConnectionBD.dtPostavchik.Rows.InsertAt(row, 0);
            }


            comboBoxFilter.DataSource = ConnectionBD.dtPostavchik;
            comboBoxFilter.ValueMember = "id";
            comboBoxFilter.DisplayMember = "name";

            lblFIO.Text = ConnectionBD.resFio; 
            if(int.Parse(ConnectionBD.roll) == 3)
            {
                groupBox1.Visible = false;
                buttonZak.Visible = false;
            }
            if (int.Parse(ConnectionBD.roll) == 1)
            {
                buttonAdd.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddTovar form = new FormAddTovar();
            form.ShowDialog();
            
            LoadTovars();
        }
        public void LoadTovars()
        {
            flowLayoutPanel1.Controls.Clear();
            CardTovar.SelectListTovar(flowLayoutPanel1);

            if (!ConnectionBD.dtPostavchik.AsEnumerable().Any(r => r["id"].ToString() == "0"))
            {
                DataRow row = ConnectionBD.dtPostavchik.NewRow();
                row["id"] = 0;
                row["name"] = "Все поставщики";
                ConnectionBD.dtPostavchik.Rows.InsertAt(row, 0);
            }


            comboBoxFilter.DataSource = ConnectionBD.dtPostavchik;
            comboBoxFilter.ValueMember = "id";
            comboBoxFilter.DisplayMember = "name";
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListZakaz form = new FormListZakaz();
            form.ShowDialog();
        }
        private void LoadData()
        {
            string serachtext = textBoxSearch.Text;
            bool sort;
            if (comboBoxSort.SelectedItem.ToString() == "По возрастанию")
            {
                sort = true;
            }
            else
            {
               sort = false;
            }
            int post = 0;

            if (comboBoxFilter.SelectedIndex > 0)
            {
                post = Convert.ToInt32(comboBoxFilter.SelectedValue);
            }

            CardTovar.SelectListTovar(flowLayoutPanel1, post, sort,serachtext);
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

       
    }
}
