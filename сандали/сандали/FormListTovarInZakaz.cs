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
        public FormListTovarInZakaz(string idTovar)
        {
            InitializeComponent();
            id = idTovar;
        }

        private void FormListTovarInZakaz_Load(object sender, EventArgs e)
        {
            MyClass.CardZakazcs.SelectTovariInZakaz(id);
            dataGridView1.DataSource = ConnectionBD.dtTovariInZakaz;

        }
    }
}
