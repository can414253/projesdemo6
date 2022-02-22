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
    public partial class Ara : Form
    {
        public Ara()
        {
            InitializeComponent();
        }

        private void Ara_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brnAra_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-N3VPKFS\SQLEXPRESS;initial catalog=ogrenciListesi;integrated security=true;");
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("Select * From ogrenciler where Ogrenci_ad like '%"+aranan+"%'", baglanti);
            SqlDataReader hafiza = sorgu.ExecuteReader();
            DataTable tablo = new DataTable();
            tablo.Load(hafiza);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
