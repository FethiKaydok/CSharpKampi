using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 15.45;
            //orangePrice = 12.60;
            //strawberryPrice = 40.65;
            //potatoPrice = 9.85;
            //tomatoPrice = 20.15;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.035;
            //orangeGram = 3.450;
            //strawberryGram = 0.650;
            //potatoGram = 7.850;
            //tomatoGram = 3.450;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı :" + applePrice + " - Gramaj : " + appleGram + " - Toplam Tutar : " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı :" + orangePrice + " - Gramaj : " + orangeGram + " - Toplam Tutar : " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı :" + strawberryPrice + " - Gramaj : " + strawberryGram + " - Toplam Tutar : " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı :" + potatoPrice + " - Gramaj : " + potatoGram + " - Toplam Tutar : " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı :" + tomatoPrice + " - Gramaj : " + tomatoGram + " - Toplam Tutar : " + tomatoTotalPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Ödenecek Toplam Tutar: " + shoppingTotalPrice + " TL");



            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("***** KYDK Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passengerIdentityNumber, passengerName, passengerSurname, passengerAge, passengerEmail, passengerPhone;

            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Email: ");
            //passengerEmail = Console.ReadLine();
            //Console.Write("Yolcu Telefon Numarası: ");
            //passengerPhone = Console.ReadLine();

            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Yolcu TC Kimlik Numarası: " + passengerIdentityNumber + " - Yolcu Ad Soyad : " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yolcu Yaşı: " + passengerAge);
            //Console.WriteLine("Yolcu Email: " + passengerEmail);
            //Console.WriteLine("Yolcu Telefon Numarası: " + passengerPhone);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int phonePrice, computerPrice, tvPrice, monitorPrice;

            //phonePrice = 30000;
            //computerPrice = 50000;
            //tvPrice = 75000;
            //monitorPrice = 5000;

            //int phoneCount, computerCount, tvCount, monitorCount;

            //Console.Write("Lütfen aldığınız telefon sayısını giriniz: ");
            //phoneCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız monitör sayısını giriniz: ");
            //monitorCount = int.Parse(Console.ReadLine());

            //int totalPrice = phonePrice * phoneCount + computerPrice * computerCount + tvPrice * tvCount + monitorPrice * monitorCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödnecek tutar: " + totalPrice + "TL");

            #endregion

            #region Klavyeden Ondalıklı İşlemleri 

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //Console.WriteLine();

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Not Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);
            #endregion

            Console.Read();
        }
    }
}
