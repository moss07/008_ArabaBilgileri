using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_ArabaBilgileri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı tarafından Windows Forms üzerinden girilen aşağıdaki araba verilerinin
            //önce Kaydet butonu ile yeni bir araba objesi oluşturularak kaydedilmesi daha sonra Göster butonu ile ekranda gösterilmesi.

            //Araba sınıfı özellikleri:
            //Id
            //Marka
            //Model
            //KapiSayisi(2 kapılı, 4 kapılı, 5 kapılı)
            //BeygirGucu(Beygir cinsinden)
            //ArabaTuru(Binek, Ticari)
            //MaksimumHiz(Kilometre / saat cinsinden)
            //Cekis(Önden çekiş, Arkadan itiş, Dört çeker)
            //SifirdanYuzeHizlanma(Saniye cinsinden)
            //Agirlik(Kilogram cinsinden)
            //MotorHacmi(Santimetreküp cinsinden)

            Araba araba1 = new Araba()
            {
                Id = 1,
                Marka = "Citroen",
                Model = "C3",
                UretimYılı=2008,
                KapiSayisi = KapiSayisi.Beş,
                BeygirGucu = 70,
                ArabaTuru = ArabaTuru.Binek,
                MaksimumHiz = 185,
                Cekis = Cekis.ÖndenÇekiş,
                SifirdanYuzeHizlanma = 15.6,
                Agirlik = 1100,
                MotorHacmi = 1400
            };

            Console.WriteLine("\t***Araba Bilgileri***");
            Console.WriteLine("Id......................:"+araba1.Id);
            Console.WriteLine("Marka...................:"+araba1.Marka);
            Console.WriteLine("Model...................:"+araba1.Model);
            Console.WriteLine("Üretim Yılı.............:"+araba1.UretimYılı);
            Console.WriteLine("Kapı Sayısı.............:"+araba1.KapiSayisi+" ("+(int)araba1.KapiSayisi+") ");
            Console.WriteLine("Beygir Gücü.............:"+araba1.BeygirGucu + " hp");
            Console.WriteLine("Araba Türü..............:"+araba1.ArabaTuru + " (" + (int)araba1.ArabaTuru + ") ");
            Console.WriteLine("Maksimum Hız............:"+araba1.MaksimumHiz+" km/h");
            Console.WriteLine("Çekiş...................:"+araba1.Cekis+ " (" + (int)araba1.Cekis + ") ");
            Console.WriteLine("Sıfırdan Yüze Hızlanma..:"+araba1.SifirdanYuzeHizlanma+" sn");
            Console.WriteLine("Aracın Ağırlığı.........:"+araba1.Agirlik+" kg");
            Console.WriteLine("Motor Hacmi.............:"+araba1.MotorHacmi+" cm3");

            Araba araba2 = new Araba();

            araba2.Id = 2;
            araba2.Marka = "Mazda";
            araba2.Model = "MX-5";
            araba2.UretimYılı = 2016;
            araba2.KapiSayisi = KapiSayisi.İki;
            araba2.BeygirGucu = 131;
            araba2.ArabaTuru = ArabaTuru.Binek;
            araba2.MaksimumHiz = 204;
            araba2.Cekis = Cekis.Arkadanİtiş;
            araba2.SifirdanYuzeHizlanma = 8.3;
            araba2.Agirlik = 975;
            araba2.MotorHacmi = 1496;

            Console.WriteLine("\t***Araba Bilgileri***");
            Console.WriteLine("Id......................:" + araba2.Id);
            Console.WriteLine("Marka...................:" + araba2.Marka);
            Console.WriteLine("Model...................:" + araba2.Model);
            Console.WriteLine("Üretim Yılı.............:" + araba2.UretimYılı);
            Console.WriteLine("Kapı Sayısı.............:" + araba2.KapiSayisi + " (" + (int)araba2.KapiSayisi + ") ");
            Console.WriteLine("Beygir Gücü.............:" + araba2.BeygirGucu + " hp");
            Console.WriteLine("Araba Türü..............:" + araba2.ArabaTuru + " (" + (int)araba2.ArabaTuru + ") ");
            Console.WriteLine("Maksimum Hız............:" + araba2.MaksimumHiz + " km/h");
            Console.WriteLine("Çekiş...................:" + araba2.Cekis + " (" + (int)araba2.Cekis + ") ");
            Console.WriteLine("Sıfırdan Yüze Hızlanma..:" + araba2.SifirdanYuzeHizlanma + " sn");
            Console.WriteLine("Aracın Ağırlığı.........:" + araba2.Agirlik + " kg");
            Console.WriteLine("Motor Hacmi.............:" + araba2.MotorHacmi + " cm3");

            Araba araba3 = new Araba()
            {
                Id = 3,
                Marka = "Volvo",
                Model = "XC40",
                UretimYılı=2019,
                KapiSayisi = KapiSayisi.Beş,
                BeygirGucu = 190,
                ArabaTuru = ArabaTuru.Binek,
                MaksimumHiz = 210,
                Cekis = Cekis.DörtÇeker,
                SifirdanYuzeHizlanma = 8.4,
                Agirlik = 1735,
                MotorHacmi = 1969
            };

            Console.WriteLine("\t***Araba Bilgileri***");
            Console.WriteLine("Id......................:" + araba3.Id);
            Console.WriteLine("Marka...................:" + araba3.Marka);
            Console.WriteLine("Model...................:" + araba3.Model);
            Console.WriteLine("Üretim Yılı.............:" + araba3.UretimYılı);
            Console.WriteLine("Kapı Sayısı.............:" + araba3.KapiSayisi + " (" + (int)araba3.KapiSayisi + ") ");
            Console.WriteLine("Beygir Gücü.............:" + araba3.BeygirGucu + " hp");
            Console.WriteLine("Araba Türü..............:" + araba3.ArabaTuru + " (" + (int)araba3.ArabaTuru + ") ");
            Console.WriteLine("Maksimum Hız............:" + araba3.MaksimumHiz + " km/h");
            Console.WriteLine("Çekiş...................:" + araba3.Cekis + " (" + (int)araba3.Cekis + ") ");
            Console.WriteLine("Sıfırdan Yüze Hızlanma..:" + araba3.SifirdanYuzeHizlanma + " sn");
            Console.WriteLine("Aracın Ağırlığı.........:" + araba3.Agirlik + " kg");
            Console.WriteLine("Motor Hacmi.............:" + araba3.MotorHacmi + " cm3");

            Console.ReadLine();
        }
    }
}
