namespace denemeproje
{
    partial class Frmizin
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
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskGun = new System.Windows.Forms.MaskedTextBox();
            this.Btnizin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblMesaj = new System.Windows.Forms.Label();
            this.LblDonus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.LblPozisyon = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(253, 262);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(312, 34);
            this.dtStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Tarihi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gün Sayısı:";
            // 
            // MskGun
            // 
            this.MskGun.Location = new System.Drawing.Point(253, 304);
            this.MskGun.Mask = "00";
            this.MskGun.Name = "MskGun";
            this.MskGun.Size = new System.Drawing.Size(312, 34);
            this.MskGun.TabIndex = 2;
            this.MskGun.ValidatingType = typeof(int);
            this.MskGun.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Btnizin
            // 
            this.Btnizin.Location = new System.Drawing.Point(284, 344);
            this.Btnizin.Name = "Btnizin";
            this.Btnizin.Size = new System.Drawing.Size(208, 66);
            this.Btnizin.TabIndex = 3;
            this.Btnizin.Text = "İzin Al";
            this.Btnizin.UseVisualStyleBackColor = true;
            this.Btnizin.Click += new System.EventHandler(this.Btnizin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblMesaj);
            this.groupBox1.Controls.Add(this.LblDonus);
            this.groupBox1.Location = new System.Drawing.Point(103, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dönüş Tarihi:";
            // 
            // LblMesaj
            // 
            this.LblMesaj.AutoSize = true;
            this.LblMesaj.Location = new System.Drawing.Point(37, 45);
            this.LblMesaj.Name = "LblMesaj";
            this.LblMesaj.Size = new System.Drawing.Size(0, 27);
            this.LblMesaj.TabIndex = 1;
            this.LblMesaj.Click += new System.EventHandler(this.label7_Click);
            // 
            // LblDonus
            // 
            this.LblDonus.AutoSize = true;
            this.LblDonus.Location = new System.Drawing.Point(193, 106);
            this.LblDonus.Name = "LblDonus";
            this.LblDonus.Size = new System.Drawing.Size(46, 27);
            this.LblDonus.TabIndex = 0;
            this.LblDonus.Text = "null";
            this.LblDonus.Click += new System.EventHandler(this.LblDonus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soyad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pozisyon:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(248, 121);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(46, 27);
            this.LblAd.TabIndex = 14;
            this.LblAd.Text = "null";
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Location = new System.Drawing.Point(248, 157);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(46, 27);
            this.LblSoyad.TabIndex = 15;
            this.LblSoyad.Text = "null";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(248, 193);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(144, 27);
            this.LblTc.TabIndex = 16;
            this.LblTc.Text = "00000000000";
            // 
            // LblPozisyon
            // 
            this.LblPozisyon.AutoSize = true;
            this.LblPozisyon.Location = new System.Drawing.Point(248, 232);
            this.LblPozisyon.Name = "LblPozisyon";
            this.LblPozisyon.Size = new System.Drawing.Size(46, 27);
            this.LblPozisyon.TabIndex = 17;
            this.LblPozisyon.Text = "null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(209, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "İZİN ALMA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(209, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "PERSONEL";
            // 
            // Frmizin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 627);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblPozisyon);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btnizin);
            this.Controls.Add(this.MskGun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtStart);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frmizin";
            this.Text = "İZİN FORMU";
            this.Load += new System.EventHandler(this.Frmizin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskGun;
        private System.Windows.Forms.Button Btnizin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblDonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LblPozisyon;
        private System.Windows.Forms.Label LblMesaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}