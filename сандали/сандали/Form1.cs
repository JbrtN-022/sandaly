using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сандали
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if( MyClass.ConnectionBD.ConnectBd() != true)
            {
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyClass.ConnectionBD.CloseBD();
        }

        private void buttonAutorization_Click(object sender, EventArgs e)
        {
            MyClass.Autorization.AutorizationBD(textBoxlogin.Text, textBoxpass.Text);
            MyClass.Autorization.GetFioUser(textBoxlogin.Text, textBoxpass.Text);
            switch (MyClass.ConnectionBD.roll)
            {
                case null:
                    MessageBox.Show("Неверные данные!");
                    break;
                case "1":
                    FormListTovar form = new FormListTovar();
                    form.ShowDialog();
                    break;
                case "2":
                    FormListTovar form1 = new FormListTovar();
                    form1.ShowDialog();
                    break;
                case "3":
                    FormListTovar form2 = new FormListTovar();
                    form2.ShowDialog();
                    break;
            }
            
        }
    }
}
