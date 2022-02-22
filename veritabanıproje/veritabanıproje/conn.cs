using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace veritabanıproje
{
    public partial class conn : Form
    {
        public conn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-N3VPKFS\SQLEXPRESS;initial catalog=ogrenciListesi;integrated security=true;");
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("Select * From ogrenciler", baglanti);
            SqlDataReader hafiza = sorgu.ExecuteReader();
            DataTable tablo = new DataTable();  
            tablo.Load(hafiza);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void conn_Load(object sender, EventArgs e)
        {
        }
    }
}
