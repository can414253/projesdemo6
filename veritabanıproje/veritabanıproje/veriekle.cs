using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace veritabanıproje
{
    public partial class veriekle : Form
    {
        public veriekle()
        {
            InitializeComponent();
        }

        private void veriekle_Load(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void veriekle_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)

        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N3VPKFS\\SQLEXPRESS;initial catalog=OgrenciListesi; integrated security=true");
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into ogrenciler (Ogrenci_No,Ogrenci_ad,Ogrenci_Soyad,Bolumu,OgrenciEposta) VALUES (@Ogrenci_No,@Ogrenci_ad,@Ogrenci_Soyad,@Bolumu,@OgrenciEposta)", baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@Ogrenci_No", txtNo.Text);
                komut.Parameters.AddWithValue("@Ogrenci_ad", txtAD.Text);
                komut.Parameters.AddWithValue("@Ogrenci_Soyad", txtSoyadı.Text);
                komut.Parameters.AddWithValue("@Bolumu", txtBolumu.Text);
                komut.Parameters.AddWithValue("@OgrenciEposta", txtEposta.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Öğrenci Eklendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata ile karşılaştık");

            }
        
        
          
        }

    }
}
