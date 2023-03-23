using Hamburgerci.Enties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Form1.menuler.Add(new Menu { MenuAdi = txtMenuAdı.Text, MenuFiyati = nmrMenuFiyati.Value });

            //TODO: Ekleme işleminden sonra Temizle() metotu çağrılsın.Ekranı temizlesin.

            MessageBox.Show("Menü Başarıyla eklendi!");
        }
    }
}
