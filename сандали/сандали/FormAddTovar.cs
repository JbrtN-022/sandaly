using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
           
            ConnectionBD.dtPostavchik.Clear();
            ClassComboBox.Postavchik();

            string cols = string.Join(", ", ConnectionBD.dtPostavchik.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
            string count = ConnectionBD.dtPostavchik.Rows.Count.ToString();

          
            ClassComboBox.EdinicaIzmereniya();
            ClassComboBox.Proizvoditel();
            ClassComboBox.KategoriyaTovara();

            comboBoxEdIzm.DataSource = ConnectionBD.dtEdinIzm;
            comboBoxEdIzm.DisplayMember = "Name";
            comboBoxEdIzm.ValueMember = "id";
            comboBoxKateg.DataSource = ConnectionBD.dtKategoriya;
            comboBoxKateg.DisplayMember = "name";
            comboBoxKateg.ValueMember = "id";
            comboBoxPostav.DataSource = ConnectionBD.dtPostavchik;
            comboBoxPostav.ValueMember = "id";
            comboBoxPostav.DisplayMember = "name";

            comboBoxProizv.DataSource = ConnectionBD.dtProizvoditel;
            comboBoxProizv.DisplayMember = "Name";
            comboBoxProizv.ValueMember = "id";
        }

        private void FormAddTovar_Load(object sender, EventArgs e)
        {
            DataTable dtLocalPost = new DataTable();
            using (var cmd = new MySqlCommand("SELECT id, name FROM up_02_2_2.поставщики", ConnectionBD.myConnection))
            using (var adap = new MySqlDataAdapter(cmd))
            {
                adap.Fill(dtLocalPost);
            }

            comboBoxPostav.DataSource = dtLocalPost;
            comboBoxPostav.DisplayMember = "name";
            comboBoxPostav.ValueMember = "id";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if( ofd.ShowDialog() == DialogResult.OK )
                {
                    try
                    {
                        selectedImage = ofd.FileName;

                        Image img = Image.FromFile(selectedImage);
                        pictureBox1.Image = img;

                        MessageBox.Show("Изображение успешно загружено");
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("Файл не является изображением или он повреждён.",
                                        "Ошибка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка загрузки изображения:\n" + ex.Message,
                                        "Ошибка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            

        }
        public static Random random = new Random();
        public static string GenerateArticule()
        {
            char bukva1 = (char)('A' + random.Next(0, 26));
            int chislo1 = random.Next(100, 1000);
            char bukva2 = (char)('A' + random.Next(0, 26));
            int chislo2 = random.Next(0, 10);
            return $"{bukva1}{chislo1}{bukva2}{chislo2}";
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
