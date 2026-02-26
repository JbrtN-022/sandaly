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
    public partial class FormAddTovar : Form
    {
        public string selectedImage;
        public FormAddTovar()
        {
            InitializeComponent();
            ClassComboBox.Postavchik();
            ClassComboBox.EdinicaIzmereniya();
            ClassComboBox.Proizvoditel();
            ClassComboBox.KategoriyaTovara();

            comboBoxEdIzm.DataSource = ConnectionBD.dtEdinIzm;
            comboBoxEdIzm.DisplayMember = "Name";
            comboBoxEdIzm.ValueMember = "id";
            comboBoxKateg.DataSource = ConnectionBD.dtKategoriya;
            comboBoxKateg.DisplayMember = "Name";
            comboBoxKateg.ValueMember = "id";
            comboBoxPostav.DataSource = ConnectionBD.dtPostavchik;
            comboBoxPostav.DisplayMember = "Name";
            comboBoxPostav.ValueMember = "id";
            comboBoxProizv.DataSource = ConnectionBD.dtProizvoditel;
            comboBoxProizv.DisplayMember = "Name";
            comboBoxProizv.ValueMember = "id";
        }

        private void FormAddTovar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if( ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImage = ofd.FileName;
                    pictureBox1.Image =Image.FromFile(selectedImage);
                }
            }
        }
        private static Random randomize = new Random();
        public static string GenerateArticule()
        {
            char later1 = (char)('A' + randomize.Next(0, 26));
            int later2 = randomize.Next(100, 1000);
            char later3 = (char)('A' + randomize.Next(0, 26));
            int later4 = randomize.Next(0, 10);
            return $"{later1}{later2}{later3}{later4}";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = GenerateArticule();
            MessageBox.Show(id);
        }
    }
}
