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
    public partial class disconn : Form
    {
        public disconn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-N3VPKFS\SQLEXPRESS;initial catalog=ogrenciListesi;integrated security=true;");
            baglanti.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select * From ogrenciler", baglanti);
            DataTable veritablo = new DataTable();
            komut.Fill(veritablo);
            dataGridView1.DataSource = veritablo;
            baglanti.Close();
        }
    }
}
