﻿namespace OkulProjesi
{
    partial class Kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OgrenciMail = new System.Windows.Forms.TextBox();
            this.AdSoyad = new System.Windows.Forms.TextBox();
            this.okulNo = new System.Windows.Forms.TextBox();
            this.SifreTekrarOgren = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(51, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(51, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Öğrenci Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(51, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(51, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Şifre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(51, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şifre Tekrar\r\n";
            // 
            // OgrenciMail
            // 
            this.OgrenciMail.Location = new System.Drawing.Point(330, 223);
            this.OgrenciMail.Name = "OgrenciMail";
            this.OgrenciMail.Size = new System.Drawing.Size(173, 27);
            this.OgrenciMail.TabIndex = 7;
            // 
            // AdSoyad
            // 
            this.AdSoyad.Location = new System.Drawing.Point(330, 185);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(173, 27);
            this.AdSoyad.TabIndex = 8;
            // 
            // okulNo
            // 
            this.okulNo.Location = new System.Drawing.Point(330, 148);
            this.okulNo.Name = "okulNo";
            this.okulNo.Size = new System.Drawing.Size(173, 27);
            this.okulNo.TabIndex = 9;
            // 
            // SifreTekrarOgren
            // 
            this.SifreTekrarOgren.Location = new System.Drawing.Point(330, 297);
            this.SifreTekrarOgren.Name = "SifreTekrarOgren";
            this.SifreTekrarOgren.Size = new System.Drawing.Size(173, 27);
            this.SifreTekrarOgren.TabIndex = 10;
            this.SifreTekrarOgren.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(330, 260);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(173, 27);
            this.Sifre.TabIndex = 11;
            this.Sifre.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(330, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 41);
            this.button3.TabIndex = 16;
            this.button3.Text = "Yeni Kayıt ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.SifreTekrarOgren);
            this.Controls.Add(this.okulNo);
            this.Controls.Add(this.AdSoyad);
            this.Controls.Add(this.OgrenciMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Kayıt";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Kayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox OgrenciMail;
        private TextBox AdSoyad;
        private TextBox okulNo;
        private TextBox SifreTekrarOgren;
        private TextBox Sifre;
        private Button button3;
        private Button button1;
    }
}