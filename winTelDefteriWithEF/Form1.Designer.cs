namespace winTelDefteriWithEF
{
    partial class Form1
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
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.lstAdresler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKisiAd = new System.Windows.Forms.TextBox();
            this.txtKisiSoyad = new System.Windows.Forms.TextBox();
            this.txtKisiTel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.btnKisiKaydet = new System.Windows.Forms.Button();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.txtAdresTanim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdresEkle = new System.Windows.Forms.Button();
            this.btnAdresKaydet = new System.Windows.Forms.Button();
            this.btnAdresSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 16;
            this.lstKisiler.Location = new System.Drawing.Point(12, 28);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(209, 228);
            this.lstKisiler.TabIndex = 0;
            this.lstKisiler.SelectedIndexChanged += new System.EventHandler(this.lstKisiler_SelectedIndexChanged);
            // 
            // lstAdresler
            // 
            this.lstAdresler.FormattingEnabled = true;
            this.lstAdresler.ItemHeight = 16;
            this.lstAdresler.Location = new System.Drawing.Point(227, 28);
            this.lstAdresler.Name = "lstAdresler";
            this.lstAdresler.Size = new System.Drawing.Size(209, 228);
            this.lstAdresler.TabIndex = 0;
            this.lstAdresler.SelectedIndexChanged += new System.EventHandler(this.lstAdresler_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKisiSil);
            this.groupBox1.Controls.Add(this.btnKisiKaydet);
            this.groupBox1.Controls.Add(this.btnKisiEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKisiTel);
            this.groupBox1.Controls.Add(this.txtKisiSoyad);
            this.groupBox1.Controls.Add(this.txtKisiAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdresSil);
            this.groupBox2.Controls.Add(this.txtAdresTanim);
            this.groupBox2.Controls.Add(this.btnAdresKaydet);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAdresEkle);
            this.groupBox2.Location = new System.Drawing.Point(227, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adresler";
            // 
            // txtKisiAd
            // 
            this.txtKisiAd.Location = new System.Drawing.Point(92, 35);
            this.txtKisiAd.MaxLength = 20;
            this.txtKisiAd.Name = "txtKisiAd";
            this.txtKisiAd.Size = new System.Drawing.Size(111, 23);
            this.txtKisiAd.TabIndex = 0;
            // 
            // txtKisiSoyad
            // 
            this.txtKisiSoyad.Location = new System.Drawing.Point(92, 64);
            this.txtKisiSoyad.MaxLength = 20;
            this.txtKisiSoyad.Name = "txtKisiSoyad";
            this.txtKisiSoyad.Size = new System.Drawing.Size(111, 23);
            this.txtKisiSoyad.TabIndex = 0;
            // 
            // txtKisiTel
            // 
            this.txtKisiTel.Location = new System.Drawing.Point(92, 93);
            this.txtKisiTel.Mask = "00000-000000";
            this.txtKisiTel.Name = "txtKisiTel";
            this.txtKisiTel.Size = new System.Drawing.Size(111, 23);
            this.txtKisiTel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon :";
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(146, 122);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(57, 23);
            this.btnKisiEkle.TabIndex = 3;
            this.btnKisiEkle.Text = "Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // btnKisiKaydet
            // 
            this.btnKisiKaydet.Location = new System.Drawing.Point(83, 122);
            this.btnKisiKaydet.Name = "btnKisiKaydet";
            this.btnKisiKaydet.Size = new System.Drawing.Size(57, 23);
            this.btnKisiKaydet.TabIndex = 3;
            this.btnKisiKaydet.Text = "Kaydet";
            this.btnKisiKaydet.UseVisualStyleBackColor = true;
            this.btnKisiKaydet.Click += new System.EventHandler(this.btnKisiKaydet_Click);
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.Location = new System.Drawing.Point(20, 122);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(57, 23);
            this.btnKisiSil.TabIndex = 3;
            this.btnKisiSil.Text = "Sil";
            this.btnKisiSil.UseVisualStyleBackColor = true;
            this.btnKisiSil.Click += new System.EventHandler(this.btnKisiSil_Click);
            // 
            // txtAdresTanim
            // 
            this.txtAdresTanim.Location = new System.Drawing.Point(6, 64);
            this.txtAdresTanim.MaxLength = 250;
            this.txtAdresTanim.Multiline = true;
            this.txtAdresTanim.Name = "txtAdresTanim";
            this.txtAdresTanim.Size = new System.Drawing.Size(197, 52);
            this.txtAdresTanim.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adres Tanım :";
            // 
            // btnAdresEkle
            // 
            this.btnAdresEkle.Location = new System.Drawing.Point(146, 122);
            this.btnAdresEkle.Name = "btnAdresEkle";
            this.btnAdresEkle.Size = new System.Drawing.Size(57, 23);
            this.btnAdresEkle.TabIndex = 3;
            this.btnAdresEkle.Text = "Ekle";
            this.btnAdresEkle.UseVisualStyleBackColor = true;
            this.btnAdresEkle.Click += new System.EventHandler(this.btnAdresEkle_Click);
            // 
            // btnAdresKaydet
            // 
            this.btnAdresKaydet.Location = new System.Drawing.Point(83, 122);
            this.btnAdresKaydet.Name = "btnAdresKaydet";
            this.btnAdresKaydet.Size = new System.Drawing.Size(57, 23);
            this.btnAdresKaydet.TabIndex = 3;
            this.btnAdresKaydet.Text = "Kaydet";
            this.btnAdresKaydet.UseVisualStyleBackColor = true;
            this.btnAdresKaydet.Click += new System.EventHandler(this.btnAdresKaydet_Click);
            // 
            // btnAdresSil
            // 
            this.btnAdresSil.Location = new System.Drawing.Point(20, 122);
            this.btnAdresSil.Name = "btnAdresSil";
            this.btnAdresSil.Size = new System.Drawing.Size(57, 23);
            this.btnAdresSil.TabIndex = 3;
            this.btnAdresSil.Text = "Sil";
            this.btnAdresSil.UseVisualStyleBackColor = true;
            this.btnAdresSil.Click += new System.EventHandler(this.btnAdresSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kişiler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Adresler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstAdresler);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Telefon Defteri With EF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.ListBox lstAdresler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.Button btnKisiKaydet;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtKisiTel;
        private System.Windows.Forms.TextBox txtKisiSoyad;
        private System.Windows.Forms.TextBox txtKisiAd;
        private System.Windows.Forms.Button btnAdresSil;
        private System.Windows.Forms.TextBox txtAdresTanim;
        private System.Windows.Forms.Button btnAdresKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdresEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

