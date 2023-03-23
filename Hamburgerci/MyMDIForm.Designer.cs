namespace Hamburgerci
{
    partial class MyMDIForm
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
            this.tsmHamburgerMenu = new System.Windows.Forms.MenuStrip();
            this.tsmSiparisYönetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisBilgi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUrunYönetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenüEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEksrtaMalzeme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHamburgerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmHamburgerMenu
            // 
            this.tsmHamburgerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisYönetimi,
            this.tsmUrunYönetimi});
            this.tsmHamburgerMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmHamburgerMenu.Name = "tsmHamburgerMenu";
            this.tsmHamburgerMenu.Size = new System.Drawing.Size(800, 24);
            this.tsmHamburgerMenu.TabIndex = 1;
            this.tsmHamburgerMenu.Text = "menuStrip1";
            // 
            // tsmSiparisYönetimi
            // 
            this.tsmSiparisYönetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisOlustur,
            this.tsmSiparisBilgi});
            this.tsmSiparisYönetimi.Name = "tsmSiparisYönetimi";
            this.tsmSiparisYönetimi.Size = new System.Drawing.Size(103, 20);
            this.tsmSiparisYönetimi.Text = "Sipariş Yönetimi";
            // 
            // tsmSiparisOlustur
            // 
            this.tsmSiparisOlustur.Name = "tsmSiparisOlustur";
            this.tsmSiparisOlustur.Size = new System.Drawing.Size(150, 22);
            this.tsmSiparisOlustur.Text = "Sipariş Oluştur";
            this.tsmSiparisOlustur.Click += new System.EventHandler(this.tsmSiparisOlustur_Click);
            // 
            // tsmSiparisBilgi
            // 
            this.tsmSiparisBilgi.Name = "tsmSiparisBilgi";
            this.tsmSiparisBilgi.Size = new System.Drawing.Size(150, 22);
            this.tsmSiparisBilgi.Text = "Sipariş Bilgileri";
            this.tsmSiparisBilgi.Click += new System.EventHandler(this.tsmSiparisBilgi_Click);
            // 
            // tsmUrunYönetimi
            // 
            this.tsmUrunYönetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenüEkle,
            this.tsmEksrtaMalzeme});
            this.tsmUrunYönetimi.Name = "tsmUrunYönetimi";
            this.tsmUrunYönetimi.Size = new System.Drawing.Size(95, 20);
            this.tsmUrunYönetimi.Text = "Ürün Yönetimi";
            // 
            // tsmMenüEkle
            // 
            this.tsmMenüEkle.Name = "tsmMenüEkle";
            this.tsmMenüEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmMenüEkle.Text = "Menü Ekle";
            this.tsmMenüEkle.Click += new System.EventHandler(this.tsmMenüEkle_Click);
            // 
            // tsmEksrtaMalzeme
            // 
            this.tsmEksrtaMalzeme.Name = "tsmEksrtaMalzeme";
            this.tsmEksrtaMalzeme.Size = new System.Drawing.Size(180, 22);
            this.tsmEksrtaMalzeme.Text = "Ekstra Malzeme Ekle";
            this.tsmEksrtaMalzeme.Click += new System.EventHandler(this.tsmEksrtaMalzeme_Click);
            // 
            // MyMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsmHamburgerMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.tsmHamburgerMenu;
            this.Name = "MyMDIForm";
            this.Text = "MyMDIForm";
            this.tsmHamburgerMenu.ResumeLayout(false);
            this.tsmHamburgerMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip tsmHamburgerMenu;
        private ToolStripMenuItem tsmSiparisYönetimi;
        private ToolStripMenuItem tsmSiparisOlustur;
        private ToolStripMenuItem tsmUrunYönetimi;
        private ToolStripMenuItem tsmSiparisBilgi;
        private ToolStripMenuItem tsmMenüEkle;
        private ToolStripMenuItem tsmEksrtaMalzeme;
    }
}