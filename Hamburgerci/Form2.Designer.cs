namespace Hamburgerci
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtMenuAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenuEkle);
            this.groupBox1.Controls.Add(this.nmrMenuFiyati);
            this.groupBox1.Controls.Add(this.txtMenuAdı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENÜ EKLEME PANELİ";
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenuEkle.Location = new System.Drawing.Point(99, 91);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(114, 41);
            this.btnMenuEkle.TabIndex = 4;
            this.btnMenuEkle.Text = "MENÜ EKLE";
            this.btnMenuEkle.UseVisualStyleBackColor = false;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.Location = new System.Drawing.Point(93, 62);
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(120, 23);
            this.nmrMenuFiyati.TabIndex = 3;
            // 
            // txtMenuAdı
            // 
            this.txtMenuAdı.Location = new System.Drawing.Point(93, 28);
            this.txtMenuAdı.Name = "txtMenuAdı";
            this.txtMenuAdı.Size = new System.Drawing.Size(120, 23);
            this.txtMenuAdı.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 168);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMenuEkle;
        private NumericUpDown nmrMenuFiyati;
        private TextBox txtMenuAdı;
        private Label label2;
        private Label label1;
    }
}