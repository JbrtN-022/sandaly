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
        private bool ValidateFields()
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Введите название");
                return false;
            }

            if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                MessageBox.Show("Цена некорректна");
                return false;
            }

            if (price < 0)
            {
                MessageBox.Show("Цена не может быть отрицательной");
                return false;
            }

            if (!int.TryParse(textBoxKolVo.Text, out int quantity))
            {
                MessageBox.Show("Количество некорректно");
                return false;
            }

            if (quantity < 0)
            {
                MessageBox.Show("Количество не может быть отрицательным");
                return false;
            }

            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            string id = GenerateArticule();



            bool result = CardTovar.AddTovar(
                 id,
                 textBoxName.Text,
                 comboBoxEdIzm.SelectedValue.ToString(),
                 comboBoxPostav.SelectedValue.ToString(),
                 comboBoxProizv.SelectedValue.ToString(),
                 comboBoxKateg.SelectedValue.ToString(),
                 textBoxPrice.Text,
                 textBoxSkidka.Text,
                 textBoxKolVo.Text,
                 textBoxDesc.Text,
                 selectedImage
                 );
            if (result)
            {
                MessageBox.Show("Товар добавлен");

                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка добавления");
            } 
            
             

            

        }
    }
}
