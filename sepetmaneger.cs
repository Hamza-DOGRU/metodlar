using System;
using System.Collections.Generic;
using System.Text;

namespace metodlar
{
    class sepetmaneger
    {
        public void Ekle(Urun urun)//ilk Urun tipidir. aşağıda ki kodları nerede ne için uygulanacak
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi : "+urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi : " + urunAdi,aciklama,fiyat);
        }
    }
}
