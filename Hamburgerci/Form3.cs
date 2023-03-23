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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemekle_Click(object sender, EventArgs e)
        {
            Form1.ekstralar.Add(new EkstraMalzeme { EkstraAdi = txtEkstraMalzeme.Text, EkstraFiyati = nmrEkstraMalzemeFiyati.Value });

            //TODO: Ekleme işleminden sonra Temizle() metotu çağrılsın.Ekranı temizlesin.

            MessageBox.Show("Ekstra Malzeme Başarıyla eklendi!");
        }
    }
}
