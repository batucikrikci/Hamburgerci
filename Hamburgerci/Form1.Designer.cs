namespace Hamburgerci
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBuyuk = new System.Windows.Forms.RadioButton();
            this.rdoOrta = new System.Windows.Forms.RadioButton();
            this.rdoKucuk = new System.Windows.Forms.RadioButton();
            this.flpEkstraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnTamamla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hamburgerci.Properties.Resources.hamburger;
            this.pictureBox1.Location = new System.Drawing.Point(18, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(13, 144);
            this.cmbMenuler.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(246, 23);
            this.cmbMenuler.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBuyuk);
            this.groupBox1.Controls.Add(this.rdoOrta);
            this.groupBox1.Controls.Add(this.rdoKucuk);
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(247, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BOYUT SEÇİN";
            // 
            // rdoBuyuk
            // 
            this.rdoBuyuk.AutoSize = true;
            this.rdoBuyuk.Location = new System.Drawing.Point(160, 36);
            this.rdoBuyuk.Margin = new System.Windows.Forms.Padding(4);
            this.rdoBuyuk.Name = "rdoBuyuk";
            this.rdoBuyuk.Size = new System.Drawing.Size(60, 19);
            this.rdoBuyuk.TabIndex = 2;
            this.rdoBuyuk.TabStop = true;
            this.rdoBuyuk.Text = "Büyük";
            this.rdoBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdoOrta
            // 
            this.rdoOrta.AutoSize = true;
            this.rdoOrta.Location = new System.Drawing.Point(86, 36);
            this.rdoOrta.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOrta.Name = "rdoOrta";
            this.rdoOrta.Size = new System.Drawing.Size(50, 19);
            this.rdoOrta.TabIndex = 1;
            this.rdoOrta.TabStop = true;
            this.rdoOrta.Text = "Orta";
            this.rdoOrta.UseVisualStyleBackColor = true;
            // 
            // rdoKucuk
            // 
            this.rdoKucuk.AutoSize = true;
            this.rdoKucuk.Location = new System.Drawing.Point(17, 36);
            this.rdoKucuk.Margin = new System.Windows.Forms.Padding(4);
            this.rdoKucuk.Name = "rdoKucuk";
            this.rdoKucuk.Size = new System.Drawing.Size(61, 19);
            this.rdoKucuk.TabIndex = 0;
            this.rdoKucuk.TabStop = true;
            this.rdoKucuk.Text = "Küçük";
            this.rdoKucuk.UseVisualStyleBackColor = true;
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(12, 245);
            this.flpEkstraMalzemeler.Margin = new System.Windows.Forms.Padding(4);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(247, 117);
            this.flpEkstraMalzemeler.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(18, 398);
            this.nmrAdet.Margin = new System.Windows.Forms.Padding(4);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(33, 21);
            this.nmrAdet.TabIndex = 6;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(72, 370);
            this.btnSiparisEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(102, 52);
            this.btnSiparisEkle.TabIndex = 7;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.HorizontalScrollbar = true;
            this.lbxSiparisler.ItemHeight = 14;
            this.lbxSiparisler.Location = new System.Drawing.Point(267, 13);
            this.lbxSiparisler.Margin = new System.Windows.Forms.Padding(4);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.ScrollAlwaysVisible = true;
            this.lbxSiparisler.Size = new System.Drawing.Size(305, 354);
            this.lbxSiparisler.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "TOPLAM TUTAR";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.ForeColor = System.Drawing.Color.Red;
            this.lblTutar.Location = new System.Drawing.Point(371, 396);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(14, 15);
            this.lblTutar.TabIndex = 10;
            this.lblTutar.Text = "0";
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(454, 384);
            this.btnTamamla.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(110, 38);
            this.btnTamamla.TabIndex = 11;
            this.btnTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 451);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpEkstraMalzemeler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cmbMenuler;
        private GroupBox groupBox1;
        private RadioButton rdoBuyuk;
        private RadioButton rdoOrta;
        private RadioButton rdoKucuk;
        private FlowLayoutPanel flpEkstraMalzemeler;
        private Label label2;
        private NumericUpDown nmrAdet;
        private Button btnSiparisEkle;
        private ListBox lbxSiparisler;
        private Label label3;
        private Label lblTutar;
        private Button btnTamamla;
    }
}