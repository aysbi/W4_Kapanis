using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_Kapanis
{
    public abstract class BaseMachine
    {
        public DateTime UretimTarihi { get; private set; }
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public BaseMachine() 
        {
            UretimTarihi = DateTime.Now;
        }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Uretim Tarihi: {UretimTarihi.ToString()}\r\nSeri Numarasi: {SeriNumarasi}\r\nAd: {Ad}\r\nAciklama: {Aciklama}\r\nIsletim Sistemi: {IsletimSistemi}");
        }

        public abstract void UrunAdiGetir();

    }
}
