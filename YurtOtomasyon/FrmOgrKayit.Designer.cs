﻿namespace YurtOtomasyon
{
    partial class FrmOgrKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.Color.NavajoWhite;
            this.TxtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(132, 15);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(234, 26);
            this.TxtOgrAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrenci Soyad:";
//            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.Color.NavajoWhite;
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(132, 47);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(234, 26);
            this.TxtOgrSoyad.TabIndex = 2;
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.NavajoWhite;
            this.MskTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(132, 80);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(234, 26);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(94, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(64, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon:";
//            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MskTelefon
            // 
            this.MskTelefon.BackColor = System.Drawing.Color.NavajoWhite;
            this.MskTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTelefon.Location = new System.Drawing.Point(132, 112);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(234, 26);
            this.MskTelefon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doğum Tarihi:";
//            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // MskDogum
            // 
            this.MskDogum.BackColor = System.Drawing.Color.NavajoWhite;
            this.MskDogum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDogum.Location = new System.Drawing.Point(132, 144);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(234, 26);
            this.MskDogum.TabIndex = 5;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(68, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bölüm:";
//            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // CmbBolum
            // 
            this.CmbBolum.BackColor = System.Drawing.Color.NavajoWhite;
            this.CmbBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(132, 176);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(234, 26);
            this.CmbBolum.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(83, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mail:";
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.NavajoWhite;
            this.TxtMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(132, 208);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(234, 26);
            this.TxtMail.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(68, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "OdaNo:";
            // this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.BackColor = System.Drawing.Color.NavajoWhite;
            this.CmbOdaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(132, 240);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(234, 26);
            this.CmbOdaNo.TabIndex = 8;
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.Color.NavajoWhite;
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(132, 307);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(234, 26);
            this.TxtVeliAdSoyad.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Veli Ad - Soyad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(35, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Veli Telefon:";
            this.label10.Click += new System.EventHandler(this.label4_Click);
            // 
            // MskVeliTelefon
            // 
            this.MskVeliTelefon.BackColor = System.Drawing.Color.NavajoWhite;
            this.MskVeliTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVeliTelefon.Location = new System.Drawing.Point(132, 339);
            this.MskVeliTelefon.Mask = "(999) 000-0000";
            this.MskVeliTelefon.Name = "MskVeliTelefon";
            this.MskVeliTelefon.Size = new System.Drawing.Size(234, 26);
            this.MskVeliTelefon.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(76, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Adres:";
            this.label11.Click += new System.EventHandler(this.label4_Click);
            // 
            // RchAdres
            // 
            this.RchAdres.BackColor = System.Drawing.Color.NavajoWhite;
            this.RchAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchAdres.Location = new System.Drawing.Point(132, 371);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(234, 118);
            this.RchAdres.TabIndex = 11;
            this.RchAdres.Text = "";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(178, 495);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(150, 40);
            this.BtnKaydet.TabIndex = 12;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(384, 548);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.RchAdres);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.MskDogum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MskVeliTelefon);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskDogum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MskVeliTelefon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox RchAdres;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label12;
    }
}

