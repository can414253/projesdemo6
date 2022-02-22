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
using System.Data.SqlClient;

namespace veritabanıproje
{
    public partial class fotografekle : Form
    {
        public fotografekle()
        {
            InitializeComponent();
        }
        string dosyaAdi;
        string kopyalanacakdosyayolu;

        private void btnSec_Click(object sender, EventArgs e)
        {
            string klasor = Application.StartupPath.ToString() + "\\" + "resimler";  //klasor yolu
            if (!Directory.Exists(klasor)); //burada boyle bir klasor varmı?
            {
                Directory.CreateDirectory(klasor);  // klasor olustur
            }
            openFileDialog1.FileName = "*";
            openFileDialog1.Filter =
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Resim Dosyası Aç";

            //sectiğimiz dosyanın adı ve yolu
            if (openFileDialog1.ShowDialog() == DialogResult.Ok)
            {
                //dosya secildiyse
                string dosyayolu = openFileDialog1.FileName;
                kopyalanacakdosyayolu = klasor + "\\" + openFileDialog1.SafeFileName;
                File.Copy(dosyayolu, kopyalanacakdosyayolu, true);
                textBox1.Text = kopyalanacakdosyayolu; //bilgi amaclı
                pictureBox1.ImageLocation = dosyayolu;//picturebox ta secilen resmi görüntüle
                MessageBox.Show("resim kopyalandı");
                dosyaAdi = openFileDialog1.SafeFileName;
            }
            else
            {
                Message
            }

                    
        }
    }

           
        


