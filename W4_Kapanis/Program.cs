using W4_Kapanis;

Baslangic:
Console.WriteLine("Telefon üretmek için 1 bilgisayar üretmek için 2'ye basiniz");
string Cevap = Console.ReadLine();

if (Cevap == "1" || Cevap == "2")
{
   switch (Cevap)
    {
        case "1":
            Telefon telefon = new Telefon();
            BilgileriAl(telefon);
            Console.Write("TR Lisanslı mı (Evet/Hayır): ");
            telefon.TrLisansliMi = Console.ReadLine().ToLower() == "evet";
            telefon.BilgileriYazdir();
            telefon.UrunAdiGetir();
            break;
        case "2":
            Bilgisayar bilgisayar = new Bilgisayar();
            BilgileriAl(bilgisayar);
            Console.Write("USB Giriş Sayısı (2 veya 4): ");
            bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());
            Console.Write("Bluetooth var mı (Evet/Hayır): ");
            bilgisayar.Bluetooth = Console.ReadLine().ToLower() == "evet";
            bilgisayar.BilgileriYazdir();
            bilgisayar.UrunAdiGetir();
            break;
    }
}
else
    goto Baslangic;

Console.WriteLine("Ürün başarıyla üretildi. Başka bir ürün üretmek ister misiniz? (Evet/Hayır)");
bool devamMi = Console.ReadLine().ToLower() == "evet";

if (devamMi)
    goto Baslangic;
else
{
    Console.WriteLine("Sizinle calismak guzeldi");
    Console.ReadKey();
}



static void BilgileriAl(BaseMachine urun)
{
    Console.Write("Seri Numarası: ");
    urun.SeriNumarasi = Console.ReadLine();
    Console.Write("Ad: ");
    urun.Ad = Console.ReadLine();
    Console.Write("Açıklama: ");
    urun.Aciklama = Console.ReadLine();
    Console.Write("İşletim Sistemi: ");
    urun.IsletimSistemi = Console.ReadLine();
}