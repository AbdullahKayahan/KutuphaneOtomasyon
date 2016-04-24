namespace KutuphaneOtomasyon
{
    partial class yonetim
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEserAdi = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTuru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.cmbCesit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEserSahibiAdi = new System.Windows.Forms.TextBox();
            this.txtEserSahibiSoyadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(46, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KULLANICI EKLE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbCesit);
            this.tabPage2.Controls.Add(this.txtKod);
            this.tabPage2.Controls.Add(this.txtAdet);
            this.tabPage2.Controls.Add(this.txtEserSahibiSoyadi);
            this.tabPage2.Controls.Add(this.txtTuru);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtEserSahibiAdi);
            this.tabPage2.Controls.Add(this.txtEserAdi);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ESER EKLE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "EKLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(616, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PARAMETRE GÜNCELLE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 179);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eser Adı:";
            // 
            // txtEserAdi
            // 
            this.txtEserAdi.Location = new System.Drawing.Point(148, 111);
            this.txtEserAdi.Name = "txtEserAdi";
            this.txtEserAdi.Size = new System.Drawing.Size(121, 20);
            this.txtEserAdi.TabIndex = 2;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(148, 85);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(121, 20);
            this.txtKod.TabIndex = 3;
            this.txtKod.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Türü:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTuru
            // 
            this.txtTuru.Location = new System.Drawing.Point(148, 137);
            this.txtTuru.Name = "txtTuru";
            this.txtTuru.Size = new System.Drawing.Size(121, 20);
            this.txtTuru.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adet:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(148, 163);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(121, 20);
            this.txtAdet.TabIndex = 2;
            // 
            // cmbCesit
            // 
            this.cmbCesit.FormattingEnabled = true;
            this.cmbCesit.Items.AddRange(new object[] {
            "Kitap",
            "Dergi",
            "CD",
            "DVD"});
            this.cmbCesit.Location = new System.Drawing.Point(148, 189);
            this.cmbCesit.Name = "cmbCesit";
            this.cmbCesit.Size = new System.Drawing.Size(121, 21);
            this.cmbCesit.TabIndex = 4;
            this.cmbCesit.Text = "Çeşit Seçiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Çeşit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Eser Sahibi Adi:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEserSahibiAdi
            // 
            this.txtEserSahibiAdi.Location = new System.Drawing.Point(398, 85);
            this.txtEserSahibiAdi.Name = "txtEserSahibiAdi";
            this.txtEserSahibiAdi.Size = new System.Drawing.Size(121, 20);
            this.txtEserSahibiAdi.TabIndex = 2;
            // 
            // txtEserSahibiSoyadi
            // 
            this.txtEserSahibiSoyadi.Location = new System.Drawing.Point(398, 111);
            this.txtEserSahibiSoyadi.Name = "txtEserSahibiSoyadi";
            this.txtEserSahibiSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txtEserSahibiSoyadi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Eser Sahibi Soyadi:";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // yonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 416);
            this.Controls.Add(this.tabControl1);
            this.Name = "yonetim";
            this.Text = "YÖNETİM";
            this.Load += new System.EventHandler(this.yonetim_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TextBox txtEserAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCesit;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEserSahibiSoyadi;
        private System.Windows.Forms.TextBox txtEserSahibiAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}