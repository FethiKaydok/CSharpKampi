using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital= Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country= Console.ReadLine();

            //if(capital =="Ankara" & country=="Türkiye")
            //{
            //    Console.WriteLine("Bilgiler doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Bilgiler hatalı");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 7)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}

            //int exam1, exam2, exam3, avarage;
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + avarage);

            //if (avarage > 0 & avarage < 50)
            //{
            //    result = "FF";
            //}
            //if (avarage >= 50 & avarage < 60)
            //{
            //    result = "DD";
            //}
            //if (avarage >= 60 & avarage < 65)
            //{
            //    result = "DC";
            //}
            //if (avarage >= 65 & avarage < 75)
            //{
            //    result = "CC";
            //}
            //if (avarage >= 75 & avarage < 80)
            //{
            //    result = "CB";
            //}
            //if (avarage >= 80 & avarage < 85)
            //{
            //    result = "BB";
            //}
            //if (avarage >= 85 & avarage < 90)
            //{
            //    result = "BA";
            //}
            //if (avarage >= 90)
            //{
            //    result = "AA";
            //}

            //Console.WriteLine();

            //Console.WriteLine("Harf Notunuz: " + result);

            //string city;
            //Console.Write("Lütfen şehir giriniz: ");
            //city = Console.ReadLine();
            //if (city == "Nevşehir" | city == "Kayseri" | city == "Bartın")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez!");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz ");
            //}

            #endregion

            #region Mod İşlemleri
            //int number;
            //number = 45;
            //int result = number % 7;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 =int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.Sayının 2.Sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number= int.Parse(Console.ReadLine());
            //if(number %2 ==0)
            //{
            //    Console.WriteLine("Sayı Çifttir.");
            //}

            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}
            #endregion

            #region Char Değişkenler
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G') 
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F') 
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje
            //Console.WriteLine("***** KYDK Restoranı *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Salatalar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine("-------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını Görmek İstediğiniz Menü Seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Domates Çorbası");
            //    Console.WriteLine("3-Tarhana Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Fırın Tavuk");
            //    Console.WriteLine("3-Tavuk Şiş");
            //    Console.WriteLine("4-İskender");
            //    Console.WriteLine("5-Tavuk Döner");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Salatalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Çoban Salata");
            //    Console.WriteLine("2-Tavuklu Salata");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Salatalar----------");

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kadayıf");
            //    Console.WriteLine("2-Baklava");
            //    Console.WriteLine("3-Künefe");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");

            //}

            //Console.Read();
            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi! "); break;


            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak İstediğiniz İşlemi Giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

                    

                    #endregion
                    
            }

           




        }
    }


