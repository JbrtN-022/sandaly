using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using сандали.MyClass;

namespace сандали
{
    public partial class FormUppTovar : Form
    {
        public string photoPath;
    
        public string newphotoPath;
        private string imageFolder = "Images";
        public string article, kat, name, desc, proizv, postav, price, edIzm, kolvo, skidka;

        private void comboBoxPostav_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int res = CardTovar.SearchTovarForDelete(article);
            if (res == 0)
            {
                CardTovar.DeleteTovar(article);
                MessageBox.Show("товар удален");
                this.Close();
            }
            else
            {
                MessageBox.Show("товар невозможно удалить тк он находиться в чьем то заказе");
            }

        }

        public FormUppTovar(string art, string kateg, string nameT, string description, string proizvodstvo, string postavchik, string priceT, string edIzmer, string kolvoT, string photoT, string skidkaT)
        {
            InitializeComponent();
            ClassComboBox.Postavchik();
            ClassComboBox.EdinicaIzmereniya();
            ClassComboBox.Proizvoditel();
            ClassComboBox.KategoriyaTovara();

            article = art;
            kat = kateg;
            name = nameT;
            desc = description;
            proizv = proizvodstvo;
            postav = postavchik;
            price = priceT;
            edIzm = edIzmer;
            kolvo = kolvoT;
            photoPath = photoT;
            skidka = skidkaT;
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
        

        private void FormUppTovar_Load(object sender, EventArgs e)
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

            textBoxArt.Text = article;
             textBoxName.Text = name;  
             textBoxPrice.Text = price;
             textBoxSkidka.Text = skidka;
             textBoxKolVo.Text = kolvo;
            textBoxDesc.Text= desc;
            SelectComboBoxByText(comboBoxEdIzm, edIzm);
            SelectComboBoxByText(comboBoxKateg, kat);
            SelectComboBoxByText(comboBoxPostav, postav);
            SelectComboBoxByText(comboBoxProizv, proizv);
            LoadImage();
        }
        private void SelectComboBoxByText(ComboBox comboBox, string text)
        {
            int index = comboBox.FindStringExact(text);

            if (index >= 0)
                comboBox.SelectedIndex = index;
            else
                comboBox.SelectedIndex = -1;
        }

        public void LoadImage()
        {
            if (File.Exists(photoPath))
            {
                pictureBox1.Image = Image.FromFile(photoPath);
            }
            else
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd =  new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (Image original = Image.FromFile(ofd.FileName))
                        {
                           
                            if (original.Width > 5000 || original.Height > 5000)
                            {
                                MessageBox.Show("Изображение слишком большое.\nМаксимум 5000x5000");

                                return;
                            }

                            Bitmap resized = new Bitmap(300, 200);

                            using (Graphics g = Graphics.FromImage(resized))
                            {
                                g.DrawImage(original, 0, 0, 300, 200);
                            }

                            if (pictureBox1.Image != null)
                            {
                                pictureBox1.Image.Dispose();
                            }

                            pictureBox1.Image = resized;

                            newphotoPath = ofd.FileName;
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("Файл не является корректным изображением или слишком большой.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка загрузки: " + ex.Message);
                    }
                }
            }
        }
        private bool ValidateFields()
        {
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

        

        private void buttonUpp_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            

            bool result = CardTovar.UppTovar(
                article,
                textBoxName.Text,
                comboBoxEdIzm.SelectedValue?.ToString(),
                comboBoxPostav.SelectedValue?.ToString(),
                comboBoxProizv.SelectedValue?.ToString(),
                comboBoxKateg.SelectedValue?.ToString(),
                textBoxPrice.Text,
                textBoxSkidka.Text,
                textBoxKolVo.Text,
                textBoxDesc.Text,
                newphotoPath
            );

            if (result)
            {
                MessageBox.Show("Товар обновлен");

                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка обновления");
            }
        }
    }
}
