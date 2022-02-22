using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabanıproje
{
    public partial class combo : Form
    {
        public combo()
        {
            InitializeComponent();
        }

        private void combo_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-N3VPKFS\SQLEXPRESS;initial catalog=ogrenciListesi;integrated security=true;");
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("Select * From ogrenciler", baglanti);
            SqlDataReader hafiza = sorgu.ExecuteReader();
            DataTable tablo = new DataTable();
            tablo.Load(hafiza);
            comboBox1.DataSource = tablo;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "Bolumu";
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
