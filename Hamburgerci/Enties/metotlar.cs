using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace Hamburgerci.Enties
{
    public class metotlar
    {
        //TODO:Temizle isimli bir metot oluşturup Formlardaki gerekli yerlerde çağırıldığında gerekli temizle işlemlerini yaptırınız.
        // menü combox'ın ilk elemanı seçili hale gelecek.
        //boyut Radiobuttunların küçük olanı seçili hale gelecek.
        // malzeme flowlayoutdeki checkkboxların chedi kaldıralacak.
        // adet numeriUpdown değer mininum değere eşitlenekcek

        // Menü Ekle Sayfası
        // işlem başarılı olursa Menü adı texboxı temizlenecek.
        //işlem başarılı olursa menü fiyatı numericupdowndaki değer minum olacak.

        // ekstra malzeme sayfası
        // işlem başarılı olursa ekstra malzemeadı texboxı temizlenecek.
        //işlem başarılı olursa ekstra malzeme fiyatı numericupdowndaki değer minum olacak.

        public static void Temizle(ControlCollection formunKontrolleri)
        {
            foreach (Control item in formunKontrolleri)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                else if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = 0;
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
                else if (item is FlowLayoutPanel)
                    Temizle(((FlowLayoutPanel)item).Controls);
                else if (item is RadioButton)
                {
                    if (((RadioButton)item).Name.Contains("Kucuk"))
                        ((RadioButton)item).Checked = true;
                }
                else if (item is CheckBox)
                {
                   // if (((CheckBox)item).Name.Contains("chk"))
                        ((CheckBox)item).Checked = false;
                }
                else if (item is GroupBox)
                    Temizle(((GroupBox)item).Controls);

            }
        }
    }
}
