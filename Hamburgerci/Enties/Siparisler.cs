using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Enties
{
    public class Siparisler
    {
        public Menu SeciliMenusu { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeleri { get; set; }
        public BoyutEnum Boyutu { get; set; }
        public int Adedi { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenusu.MenuFiyati;

            switch (Boyutu)
            {
                case BoyutEnum.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case BoyutEnum.Buyuk:
                    ToplamTutar += ToplamTutar * 0.20M;
                    break;
            }
            ToplamTutar += Adedi;

            foreach (EkstraMalzeme item in EkstraMalzemeleri)
                ToplamTutar += item.EkstraFiyati;

        }
        public override string ToString()
        {
            if (EkstraMalzemeleri.Count < 1)
            {
                return string.Format("{0} Menü x {1}Adet, {2} Boy, Toplam {3}", SeciliMenusu.MenuAdi, Adedi, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string ekstraMalzemler = null;
                foreach (EkstraMalzeme item in EkstraMalzemeleri)
                    ekstraMalzemler += item.EkstraAdi + ",";


                ekstraMalzemler = ekstraMalzemler.Trim(','); // En sondaki virgülü temizledik.

                return string.Format("{0} Menü x {1}Adet, {2} Boy, ({3}) Toplam {4}", SeciliMenusu.MenuAdi, Adedi, Boyutu.ToString(), ekstraMalzemler, ToplamTutar.ToString("C2"));

            }
           
        }

    }
}

