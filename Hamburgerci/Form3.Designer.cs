namespace Hamburgerci
{
    partial class Form3
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
            this.btnEkstraMalzemekle = new System.Windows.Forms.Button();
            this.nmrEkstraMalzemeFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzeme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkstraMalzemekle);
            this.groupBox1.Controls.Add(this.nmrEkstraMalzemeFiyati);
            this.groupBox1.Controls.Add(this.txtEkstraMalzeme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EKSTRA MALZEME EKLEME PANELİ";
            // 
            // btnEkstraMalzemekle
            // 
            this.btnEkstraMalzemekle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEkstraMalzemekle.Location = new System.Drawing.Point(99, 100);
            this.btnEkstraMalzemekle.Name = "btnEkstraMalzemekle";
            this.btnEkstraMalzemekle.Size = new System.Drawing.Size(114, 41);
            this.btnEkstraMalzemekle.TabIndex = 4;
            this.btnEkstraMalzemekle.Text = "EKSTRA MALZEME EKLE";
            this.btnEkstraMalzemekle.UseVisualStyleBackColor = false;
            this.btnEkstraMalzemekle.Click += new System.EventHandler(this.btnEkstraMalzemekle_Click);
            // 
            // nmrEkstraMalzemeFiyati
            // 
            this.nmrEkstraMalzemeFiyati.Location = new System.Drawing.Point(93, 71);
            this.nmrEkstraMalzemeFiyati.Name = "nmrEkstraMalzemeFiyati";
            this.nmrEkstraMalzemeFiyati.Size = new System.Drawing.Size(120, 23);
            this.nmrEkstraMalzemeFiyati.TabIndex = 3;
            // 
            // txtEkstraMalzeme
            // 
            this.txtEkstraMalzeme.Location = new System.Drawing.Point(93, 28);
            this.txtEkstraMalzeme.Name = "txtEkstraMalzeme";
            this.txtEkstraMalzeme.Size = new System.Drawing.Size(120, 23);
            this.txtEkstraMalzeme.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 167);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEkstraMalzemekle;
        private NumericUpDown nmrEkstraMalzemeFiyati;
        private TextBox txtEkstraMalzeme;
        private Label label2;
        private Label label1;
    }
}