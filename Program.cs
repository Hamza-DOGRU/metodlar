using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 1;
            Urun[] urunler = new Urun[] {urun1,urun2 };
            //type-safe--tip güvenli neyle çalışacağımı bilmek isterim 
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("----------------");
            }
            //bu günkü ders
            Console.WriteLine("--------Metodlar-----------");
            sepetmaneger sepetmaneger = new sepetmaneger();
            sepetmaneger.Ekle(urun1);//Metod çağırma
            sepetmaneger.Ekle(urun2);//Metod çağırma

            sepetmaneger.Ekle2("Armut","Yeşil armut",12);//Metod çağırma
            sepetmaneger.Ekle2("Elma", "Yeşil elma", 10);


        }
    }
}

//clean code - Best practise
