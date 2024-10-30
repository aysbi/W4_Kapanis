using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_Kapanis
{
    internal class Bilgisayar : BaseMachine
    {
        public int usbGirisSayisi;
        public bool Bluetooth {  get; set; }

        public int UsbGirisSayisi
        {
            get { return usbGirisSayisi; }
            set
            {
                if (value == 2 || value == 4)
                    usbGirisSayisi = value;
                else
                {
                    Console.WriteLine("Hatali giris");
                    usbGirisSayisi = -1;
                }
            }
        }

        
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarinizin adi ---> {Ad}");
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            string BluetoothVarMi = Bluetooth ? "Evet" : "Hayır";
            Console.WriteLine($"Usb Giris Sayisi: {usbGirisSayisi}\r\nBluetooth var mi: {BluetoothVarMi}"); 
        }
    }
}
