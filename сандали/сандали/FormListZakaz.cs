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
    public partial class FormListZakaz : Form
    {
        public FormListZakaz()
        {
            InitializeComponent();
        }
        public void LoadTovars()
        {
            flowLayoutPanel1.Controls.Clear();
            CardZakaz.SelectCardZakaz(flowLayoutPanel1);
        }
        private void FormListZakaz_Load(object sender, EventArgs e)
        {
            CardZakaz.SelectCardZakaz(flowLayoutPanel1);
            if(int.Parse(ConnectionBD.roll) != 1)
            {
                buttonAdd.Visible = false;
                
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddZakaz form = new FormAddZakaz();
            form.ShowDialog();
            FormListZakaz parent = this.FindForm() as FormListZakaz;

            if (parent != null)
            {
                parent.LoadTovars();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

        }
    }
}
