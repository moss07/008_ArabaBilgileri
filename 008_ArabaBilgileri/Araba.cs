using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_ArabaBilgileri
{
    public class Araba
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public short UretimYılı { get; set; }
        public KapiSayisi KapiSayisi { get; set; }
        public int BeygirGucu { get; set; }
        public int MyProperty { get; set; }
        public ArabaTuru ArabaTuru { get; set; }
        public short MaksimumHiz { get; set; }
        public Cekis Cekis { get; set; }
        public double SifirdanYuzeHizlanma { get; set; }
        public double Agirlik { get; set; }
        public short MotorHacmi { get; set; }
    }
}
