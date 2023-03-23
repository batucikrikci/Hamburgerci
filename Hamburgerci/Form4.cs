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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzeme = 0;
            int satisAdedi = 0;

            foreach (Siparisler siparis in Form1.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (EkstraMalzeme ekstra in siparis.EkstraMalzemeleri)
                {
                    ekstraMalzeme += ekstra.EkstraFiyati;
                }
                satisAdedi += siparis.Adedi;
                lbxTumSiparisler.Items.Add(siparis);
            }
            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalGeliri.Text = ekstraMalzeme.ToString("C2");
            lblToplamSipSayisi.Text = lbxTumSiparisler.Items.Count.ToString();
            lblSatılanUrunSayisi.Text = satisAdedi.ToString();
        }
    }
}
