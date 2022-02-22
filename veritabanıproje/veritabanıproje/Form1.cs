using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabanıproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          conn frm=new conn();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
             disconn frm=new disconn();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            combo form = new combo();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ara form = new Ara();
            form.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            veriekle form = new veriekle(); 
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fotografekle form = new fotografekle();
            form.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
