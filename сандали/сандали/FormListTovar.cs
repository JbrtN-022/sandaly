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
            CardTovar.SelectListTovar(flowLayoutPanel1);

            lblFIO.Text = ConnectionBD.resFio; 
            if(int.Parse(ConnectionBD.roll) == 3)
            {
                groupBox1.Visible = false;
                button2.Visible = false;
            }
            if (int.Parse(ConnectionBD.roll) == 1)
            {
                button1.Visible = true;
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
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListZakaz form = new FormListZakaz();
            form.ShowDialog();
        }
    }
}
