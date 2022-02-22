namespace veritabanıproje
{
    partial class veriekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.txtBolumu = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölümü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-posta :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(331, 179);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 29);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(147, 12);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(259, 22);
            this.txtNo.TabIndex = 6;
            this.txtNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(147, 47);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(259, 22);
            this.txtAD.TabIndex = 7;
            this.txtAD.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(147, 77);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(259, 22);
            this.txtSoyadı.TabIndex = 8;
            this.txtSoyadı.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtBolumu
            // 
            this.txtBolumu.Location = new System.Drawing.Point(147, 109);
            this.txtBolumu.Name = "txtBolumu";
            this.txtBolumu.Size = new System.Drawing.Size(259, 22);
            this.txtBolumu.TabIndex = 9;
            this.txtBolumu.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(147, 141);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(259, 22);
            this.txtEposta.TabIndex = 10;
            this.txtEposta.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // veriekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 480);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtBolumu);
            this.Controls.Add(this.txtSoyadı);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "veriekle";
            this.Text = "öğrenci Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtSoyadı;
        private System.Windows.Forms.TextBox txtBolumu;
        private System.Windows.Forms.TextBox txtEposta;
    }
}