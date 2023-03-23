using Hamburgerci.Enties;
using System.Drawing.Text;

namespace Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Siparisler> tumSiparisler = new List<Siparisler>();
        public static List<Siparisler> mevcutSiparisler = new List<Siparisler>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{MenuAdi = "Big King", MenuFiyati = 50.75M},
            new Menu{MenuAdi = "Whooper Jr.", MenuFiyati = 45.50M},
            new Menu{MenuAdi = "King Chicken", MenuFiyati = 37.75M},
            new Menu{MenuAdi = "Chicken Royale", MenuFiyati = 42.00M},
            new Menu{MenuAdi = "K�fteburger", MenuFiyati = 52.25M},
        };

        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{EkstraAdi="Ket�ap",EkstraFiyati = 1.00M},
            new EkstraMalzeme{EkstraAdi="Mayonez",EkstraFiyati = 1.00M},
            new EkstraMalzeme{EkstraAdi="Ranch Sos",EkstraFiyati = 1.50M},
            new EkstraMalzeme{EkstraAdi="BBQ Sos",EkstraFiyati = 1.50M},
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
                cmbMenuler.Items.Add(item); // ToString() metotu override edildi�i i�in... Men� �eklinde eklenecektir.

            foreach (EkstraMalzeme item in ekstralar)
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item });

            foreach (Siparisler item in mevcutSiparisler)
                lbxSiparisler.Items.Add(item); // e�er form a��ld���nda tamamlanmam�� (mevcut) siprai� varsa ListBox'a ekle.


            rdoKucuk.Checked = true; // A��l��ta k���k boyut se�ili gelsin.
            cmbMenuler.SelectedIndex = 0; // A��l��ta ilk eleman se�ili gelsin.
            TutarHesapla();

        }
        private decimal TutarHesapla()
        {
            decimal toplamtutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparisler gelenSiparis = (Siparisler)lbxSiparisler.Items[i];
                toplamtutar += gelenSiparis.ToplamTutar;
            }
            lblTutar.Text = toplamtutar.ToString("C2");
            return toplamtutar; // herhangi bir yerde metotu �a��rd���m�zda geriye de�er d�nd�rebilecek i�in yaz�yoruz.D�n�� tipi de o sebepler void de�il decimal ayarland�.
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparisler yeniSiparis = new Siparisler();
            yeniSiparis.SeciliMenusu = (Menu)cmbMenuler.SelectedItem;

            if (rdoKucuk.Checked)// rdo chechked== true;
                yeniSiparis.Boyutu = BoyutEnum.Kucuk;
            else if (rdoOrta.Checked)
                yeniSiparis.Boyutu = BoyutEnum.Orta;
            else
                yeniSiparis.Boyutu = BoyutEnum.Buyuk;

            yeniSiparis.EkstraMalzemeleri = new List<EkstraMalzeme>();

            foreach (CheckBox kontrol in flpEkstraMalzemeler.Controls)
            {
                if (kontrol.Checked)
                    yeniSiparis.EkstraMalzemeleri.Add((EkstraMalzeme)kontrol.Tag); // Flpnin kontrollerinden her birinin Tag property'sinde tututalan EkstraMalzeme nesnesinin bir kopyas�n� ald�k ve Siparis nesnesinde olu�turdu�umuz ekstraMalzemeleri listesine ekledik.
            }
            yeniSiparis.Adedi=Convert.ToInt32(nmrAdet.Value);

            yeniSiparis.Hesapla(); // eklenen yeni sipari�in tutar�n� ilgili classtaki metot ile hesapl�yoruz.

            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            //tumSiparisler.Add(yeniSiparis);

            TutarHesapla(); // ilgili Label'da toplam tutar yazs�n diye kulland�k.

            metotlar.Temizle(this.Controls); // Bu formun kontrollerini ilgili metoda g�nder.

        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipari� tutar�: "+TutarHesapla().ToString("C2") + "\nSat�n Alma ��lemini Onayl�yor Musunuz?", "Sipari� Bilgisi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                tumSiparisler.AddRange(mevcutSiparisler); // Siparis tamamland���nda mevcut sipari�leri t�m sipari�lere ekliyoruz.
                lbxSiparisler.Items.Clear(); // listeBox� temizle
                mevcutSiparisler.Clear(); // ge�ici olrak bu listeyi temizliyoruz.
                TutarHesapla();
                MessageBox.Show("Sipari�iniz tamamland�.");
            }
            else
                MessageBox.Show("��leminiz �ptal edildi.");
        }
        
    }
}