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
    public partial class UserControlTovar : UserControl
    {
        public string article, kat, name, desc, proizv, postav, price, edIzm, kolvo, photo, skidka;

       

        private void labelDesc_Click(object sender, EventArgs e)
        {

        }

        public UserControlTovar(string art, string kateg, string names, string descript, string proizvod, string postavshik, string prices, string edIzmer, string kolichestvo, string foto, string skidkaProc)
        {
            InitializeComponent();
           article = art;   
           kat = kateg;
            name = names;
            desc = descript;
            proizv = proizvod;
            postav = postavshik;
            price = prices;
            edIzm = edIzmer;
            kolvo = kolichestvo;
            photo = foto;
            skidka = skidkaProc;
        }
        private void UserControlTovar_Load(object sender, EventArgs e)
        {
            if(int.Parse(skidka) > 15)
            {
                this.BackColor = ColorTranslator.FromHtml("#2E8B57");
            }
            if(int.Parse(kolvo) == 0)
            {
                labelKolVo.ForeColor = Color.Aqua;

            }

            labelArticul.Text = $"Артикул товара: {article}";
            labelTovar.Text = $"{kat}|{name}";
            labelDesc.Text = desc;
            labelProizvoditel.Text = $"Производитель: {proizv}";
            if (int.Parse(skidka) > 0)
            {
                int skidkaInt = int.Parse(skidka);
                
                int priceInt= int.Parse(price);
                
                int itog = priceInt - (priceInt / 100 *  skidkaInt);
                labelCenaOld.ForeColor = Color.Red;
                labelCenaOld.Font = new Font( labelCenaOld.Font,FontStyle.Strikeout );
                labelCenaOld.Text = $"Цена: {price}";
                labelCenaNew.ForeColor = Color.Black;
                labelCenaNew.Text = itog.ToString();

            }
            else
            {
                labelCenaOld.Text = $"Цена: {price}";
                labelCenaNew.Text = null;
            }
            labelEdIzm.Text = $"Едииница измерения: {edIzm}" ;
            labelKolVo.Text = $"Количество на складе: {kolvo}";
            labelSkidka.Text = $"Действующая скидка: {skidka} %" ;
            LoadImage();
        }

        private void UserControlTovar_Click(object sender, EventArgs e)
        {

            if (int.Parse(ConnectionBD.roll) == 1)
            {
                FormUppTovar form = new FormUppTovar(article, kat, name, desc, proizv, postav, price, edIzm, kolvo, photo, skidka);
                form.ShowDialog();
                FormListTovar parent = this.FindForm() as FormListTovar;

                if (parent != null)
                {
                    parent.LoadTovars();
                }
            }
           
        }
        public void LoadImage()
        {
            if (File.Exists(photo))
            {
                pictureBox1.Image = Image.FromFile(photo);

            }
            else
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

       
    }
}
