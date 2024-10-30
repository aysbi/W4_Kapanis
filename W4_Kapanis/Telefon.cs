using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace W4_Kapanis
{
    public class Telefon : BaseMachine
    {
        public bool TrLisansliMi { get; set; }

        public override void BilgileriYazdir()
        {
            string TrLisansDurumu = TrLisansliMi ? "Evet" : "Hayir";
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisanslı mı: {TrLisansDurumu}"); 
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }
    }
}
