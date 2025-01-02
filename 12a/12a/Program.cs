using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _12a
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları

            //Console.Write("akif");
            //Console.WriteLine("Arda");


            //Console.WriteLine("---------- Yemek Çeşitleri ---------");
            //Console.WriteLine();
            //Console.WriteLine("1- Corbalar");
            //Console.WriteLine("2- Ana Yemek");
            //Console.WriteLine("3- Ara Sıcaklar");
            //Console.WriteLine("4- Tatlılar");
            //Console.WriteLine("5- içecekler");
            //Console.WriteLine("6- Salatalar");
            //Console.WriteLine();
            //Console.WriteLine("---------- Yemek Çeşitleri ----------");

            #endregion

            #region Değişken İsimlendirmeleri

            //Snake Case =>  degisken_türü_ornegi

            //Camel Case =>  degiskenTürüOrnegi

            //Pascal Case =>  DegiskenTürüOrnegi

            //Hungarian Case => strDegiskenTuruOrnegi

            //Kebab Case=>  degisken-türü-ornegi



            #endregion

            #region String Değişkenler

            //degisken türü  degiskenAdı
            //String isim;
            //isim = "kerin";

            //String isim2 = "kerim2";

            //Console.WriteLine(isim2);

            //String customerName = "EBubekir";
            //String customerSurname;
            //customerSurname = "Palabıyık";

            //String customerName = "Poyraz";
            //String customerSurname, customerEmail, customerPhone, customerCity, customerDiscrixt;


            //customerName = "Poyraz";
            //customerSurname = "YAYLA";
            //customerEmail="deneme123@gmail.com";
            //customerPhone = "2131242144214";
            //customerCity = "İstanbul";
            //customerDiscrixt = "Gaziosmanpaşa";

            //Console.WriteLine("----------- REZERVASYON KARTI ---------------");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri Adı : " + customerName);
            //Console.WriteLine("Müşteri Soyadı:" + customerSurname);
            //Console.WriteLine("Müşteri Epostası : "+customerEmail);
            //Console.WriteLine("Müşteri Telefon numarası: " + customerPhone);
            //Console.WriteLine("Müşteri Adresi:" + customerCity + "/" + customerDiscrixt);
            //Console.WriteLine() ;
            //Console.WriteLine("----------- REZERVASYON KARTI ---------------");


            //customerName = "keirm";

            //Console.WriteLine("----------- REZERVASYON KARTI ---------------");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri Adı : " + customerName);


            #endregion

            #region int (TAM SAYI) Değişkenler

            //int number;
            //number = 239;

            //Console.WriteLine(number);


            //int hamburgerPrice = 300;
            //int cokePrice = 45;
            //int waterPrice = 10;
            //String kitapAdi = "ARaba sevdası";
            //int lemonadePrice = 35;
            //int friesPrice = 100;

            //Console.WriteLine("************ Restoren Menü Fiyati **********");
            //Console.WriteLine();
            //Console.WriteLine("hamburher fiyatı : " + hamburPrice);
            //Console.WriteLine("Kola Fiyatı : " + cokePrice);
            //Console.WriteLine("Su Fiyatı" + waterPrice);
            //Console.WriteLine("Limonata Fiyatı" + lemonadePrice);
            //Console.WriteLine("Kızartma Fiyatı : " + friesPrice);
            //Console.WriteLine();
            //Console.WriteLine("************* Restoran Menü fiyatı **********0");

            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int lemonadeCount;
            //int friesCount;


            //int totalHamburgerPrice;
            //int totalCokePrice;
            //int totalWaterPrice;
            //int totalLemonadePrice;
            //int totalFriesPrice;


            //hamburgerCount = 15;
            //cokeCount = 15;
            //waterCount = 10;
            //friesCount = 30;
            //lemonadeCount = 15;

            //totalHamburgerPrice = hamburgerCount *hamburgerPrice;
            //totalCokePrice = cokeCount * cokePrice;
            //totalWaterPrice = waterCount * waterPrice;
            //totalFriesPrice = friesCount * friesPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;

            //int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalLemonadePrice;


            //Console.WriteLine("************ Sipraiş özeti **********");
            //Console.WriteLine();
            //Console.WriteLine(" Sizin aldığınız hamburger fiyatı = " + totalHamburgerPrice);
            //Console.WriteLine(" Sizin Aldığınız Kola Fiyatı = " + totalCokePrice);
            //Console.WriteLine(" sizin Aldığınız Su Fiyatı = " + totalWaterPrice);
            //Console.WriteLine(" Sizin aldığınız Limonata Fiyatı " + totalLemonadePrice);
            //Console.WriteLine(" Sizin Aldığınız Kızartma Fiyatı " + totalFriesPrice);
            //Console.WriteLine();
            //Console.WriteLine(" Toplam Menü Tutarınız = " + totalPrice);
            //Console.WriteLine();
            //Console.WriteLine("*************** Sipariş Özeti ***********");
            #endregion

            #region Double Değişkenler

            //double number;

            //number = 1213.13122;


            //Console.WriteLine("****** Fiyat Listesi ****");

            //double elmaFiyati, portakalFiyatı, cilekFiyatı, patatesFiyatı, domatesFiyatı;

            //elmaFiyati = 14.25;
            //portakalFiyatı = 20.05;
            //cilekFiyatı = 42.10;
            //patatesFiyatı = 5.24;
            //domatesFiyatı = 5.99;

            //Console.WriteLine("----- Elma Birim Fiyatı:" + elmaFiyati + " TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı" + portakalFiyatı + " TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + cilekFiyatı + " TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + patatesFiyatı + " TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + domatesFiyatı + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double elmaGram, portakalGram, cilekGram, patatesGram, domatesGram;

            //elmaGram = 1.245;
            //portakalGram = 2.560;
            //cilekGram = 0.645;
            //patatesGram = 1.123;
            //domatesGram = 3.532;

            //double elmaToplamFiyatı = elmaGram * elmaFiyati;
            //double portakalToplamFiyatı = portakalGram * portakalFiyatı;
            //double cilekToplamFiyatı = cilekGram * cilekFiyatı;
            //double patatesToplamFiyatı = patatesGram * patatesFiyatı;
            //double domatesToplamFiyatı = domatesFiyatı * domatesGram;


            //Console.WriteLine(" Alınan Ürün: Elma -"+"Birim Fiyat: "+elmaFiyati+"- Gramaj: "+elmaGram+"-Toplam tutar :"+elmaToplamFiyatı);
            //Console.WriteLine("ALınan ürün : Portakal-" + "Birim Fiyatı: " + portakalFiyatı + "-Gramaj:" + portakalGram + "-Toplam Tutar: " + portakalToplamFiyatı);
            //Console.WriteLine("Alına ürün : Çilek-" + "Virim Fiyat: " + cilekFiyatı+"-Gramaj:"+cilekGram+"- Toplam Tutar: "+cilekToplamFiyatı);
            //Console.WriteLine("Alınan ürün: Patates-" + "Birim Fiyatı:" + patatesFiyatı + "-Gramaj:" + patatesGram + "-Toplam tutar:" + patatesToplamFiyatı);
            //Console.WriteLine("Alınan ürün domates-" + "Birim Fiyatı" + domatesFiyatı + "Gramaj: " + domatesGram + "Toplam Tutar:" + domatesToplamFiyatı);

            //double alisverisTutarı = elmaToplamFiyatı + portakalToplamFiyatı + cilekToplamFiyatı + patatesToplamFiyatı + domatesToplamFiyatı;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışverişinizin Toplam tutarı :  " + alisverisTutarı + " TL'dir");


            #endregion

            #region Char Değişkenler
            //char sembol;
            //sembol = 'a';

            //Console.WriteLine(sembol);
            #endregion

            #region Klavyeden veri girişleri String Değişkenler

            //Console.WriteLine("***** 12 a Hava yolları yollcu bilgisi ***");
            //Console.WriteLine();

            //string yolcuAdi, yolcuSoyadı, yolcuIlce, yolcuSehir, yolcuYas, yolcuTC;

            //Console.WriteLine("Yolcu Adı: ");
            //yolcuAdi = Console.ReadLine();

            //Console.WriteLine("Yolcu Soyadı: ");
            //yolcuSoyadı = Console.ReadLine();

            //Console.WriteLine("Yolcu Adresi: ");
            //yolcuIlce = Console.ReadLine();

            //Console.WriteLine("Şehir Bilgisi: ");
            //yolcuSehir = Console.ReadLine();

            //Console.WriteLine("Yolcu Yaş: ");
            //yolcuYas = Console.ReadLine();

            //Console.WriteLine("Yolcu TC kimlik No: ");
            //yolcuTC = Console.ReadLine();


            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + yolcuTC + "\nYolcu yaşı : "+ yolcuYas +"\nYolcu AD soyad:  " + yolcuAdi + "  " + yolcuSoyadı + "\nAdres:  " + yolcuIlce + "/" + yolcuSehir);



            #endregion

            #region Klavyeden Tam sayı Girişleri ve dönüşümler

            //int ayakkabiFiyati, bilgisayarFiyati, koltukFiyatı, tvFiyatı;

            //ayakkabiFiyati = 500;
            //bilgisayarFiyati = 20000;
            //koltukFiyatı = 1000;
            //tvFiyatı = 10000;

            //int ayakkabiSayisi, bilgisayarSayisi, koltukSayi, tvSayi;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz:");
            //ayakkabiSayisi = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
            //bilgisayarSayisi = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız koltuk sayısını giriniz: ");
            //koltukSayi= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldğın televizyon sayisini giriniz: ");
            //tvSayi= int.Parse(Console.ReadLine());

            //int toplamFiyat = ayakkabiSayisi * ayakkabiFiyati + bilgisayarFiyati * bilgisayarSayisi + koltukSayi * koltukFiyatı + tvSayi * tvFiyatı;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz gerekebn fiyat = " + toplamFiyat);


            #endregion

            #region Klavyeden ondalıklı sayi işlemleri

            //double sinav1,sinav2,sinav3,sonuc;

            //Console.Write("Lütfen 1.sınav notunu giriniz: ");
            //sinav1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //sinav2 = double.Parse(Console.ReadLine());

            //Console.Write("Lüfen 3.Sınav notunu giriniz:");
            //sinav3 = double.Parse(Console.ReadLine());

            //sonuc = (sinav3 + sinav2 + sinav1) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız: " + sonuc);



            #endregion

            #region Klavyeden Karakter girişleri

            //char cinsiyet;

            //Console.WriteLine("Lütfen Cinsiyet seçiniz: ");
            //cinsiyet = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + cinsiyet);






            #endregion

            #region İf Else Karar Mekanizmalari 

            //eğer söyleyle   eğer böyleyse 
            // koşullara göre şekillen kod ilerlemesi
            // eğer öğrencinin not ortalaması 50 üstündeyse sonuç
            // ortalamanın üstündedir şeklinde yazılan kodlar bu
            // region örneği olarak gösterilebilir.


            //Console.WriteLine("Lütfen şifreyi giriniz:");

            //string sifre;
            //sifre = Console.ReadLine();

            //if (sifre == "abcd")
            //{
            //    Console.WriteLine("Şifreyi Doğru girdiniz. sisteme giriş yapılıyor...");


            //}
            //else
            //{
            //    Console.WriteLine("Girilen şifre Yanlış..");
            //}


            //string baskent, ulke;

            //Console.WriteLine("Başkenti giriniz");
            //baskent=Console.ReadLine();
            //Console.WriteLine("Ülkeyi giriniz:");
            //ulke=Console.ReadLine();

            //if(baskent=="Ankara" & ulke=="Türkiye")
            //{
            //    Console.WriteLine("Girilen veriler doğru");

            //}
            //else
            //{
            //    Console.WriteLine("veriler yanlış");
            //}


            //int sayi;
            //Console.WriteLine("Sayiyi giriniz:");
            //sayi = int.Parse(Console.ReadLine());

            //if (sayi == 5)
            //{
            //    Console.WriteLine("Tahmin edilen sayı doğru");

            //}else
            //{
            //    Console.WriteLine("Tahmin edilen sayı yanlıştır.");
            //}

            //int sınav1, sınav2, sınav3, ortalama;

            //string sonucMesajı = "hata";

            //Console.WriteLine("1.Sınav notunu giriniz.");
            //sınav1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.Sınav notunu giriniz: ");
            //sınav2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("3.Sınav notunu giriniz: ");
            //sınav3 = int.Parse(Console.ReadLine());

            //ortalama = (sınav3 + sınav2 + sınav1) / 3;

            //Console.WriteLine("ortalama not : " + ortalama);


            //if(ortalama >0 & ortalama <= 50)
            //{
            //    sonucMesajı = "Sonuç vasat";

            //}
            //if(ortalama>50 & ortalama <= 70)
            //{
            //    sonucMesajı = "Sonuc Orta";

            //}
            //if(ortalama>70 & ortalama <=84)
            //{
            //    sonucMesajı = "Sonucç iyi";
            //}
            //if (ortalama > 84)
            //{
            //    sonucMesajı = "sonuç Mükkemel";
            //}

            //Console.WriteLine(sonucMesajı);


            //string sehir;

            //Console.WriteLine("Lütfem şehir giriniz:");

            //sehir = Console.ReadLine();

            //if( sehir == "ordu" || sehir == "trabzon" || sehir == "artvin")
            //{

            //    Console.WriteLine(  "Girilen şehir karadeniz bölgesindedir.");
            //}
            //else{
            //    Console.WriteLine( "Girilen şehir karadeniz bölgesinde değildir.");
            //}



            //char sembol;

            //Console.WriteLine("takım sembolu giriniz:");

            //sembol = char.Parse(Console.ReadLine());

            //if(sembol=='G' || sembol == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if(sembol=='F' || sembol== 'f')
            //{
            //    Console.WriteLine("Fenerbahce");
            //}
            //if( sembol== 'b' || sembol == 'B')
            //{
            //    Console.WriteLine("Beşiktsş");
            //}
            //if (sembol == 't' || sembol == 'T')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}


            //Console.WriteLine(" 12-a restoran menü");

            //Console.WriteLine();
            //Console.WriteLine("1- Ana yemek");
            //Console.WriteLine("2- Çorbolar");
            //Console.WriteLine("3- Tatlılar");
            //Console.WriteLine("4- içecekler");

            //int menuSecim = int.Parse(Console.ReadLine());

            //if(menuSecim==1)
            //{
            //    Console.WriteLine(" Ana yemek kategorisi");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri soslu tavuk");
            //    Console.WriteLine("2- Hamburger");
            //    Console.WriteLine("3-Karnıyarık");
            //    Console.WriteLine("4- kebab");


            //}

            //if (menuSecim == 2)
            //{
            //    Console.WriteLine("Çorba kategorisi");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Domates Çorbası");
            //    Console.WriteLine("2- Tavuk çorbası");
            //    Console.WriteLine("3- mercimek");
            //    Console.WriteLine("4- kelle paça");
            //}



            #endregion

            #region switch Case

            //Console.Write("Lütfen Ay girişi yapınız:");
            //int ay=int.Parse(Console.ReadLine());

            //switch (ay)
            //{
            //    case 1: Console.WriteLine("Ocak");
            //        break;
            //    case 2: Console.WriteLine("şubat");
            //        break;
            //    case 3: Console.WriteLine("Mart");
            //        break;
            //    case 4: Console.WriteLine("Nisan");
            //        break;
            //    case 5: Console.WriteLine("Mayıs");
            //        break;
            //    case 6: Console.WriteLine("Haziran");
            //        break;
            //    case 7: Console.WriteLine("Temmuz");
            //        break;
            //    case 8: Console.WriteLine("Ağustos");
            //        break;
            //    case 9: Console.WriteLine("Eylül");
            //        break;
            //    case 10: Console.WriteLine("Ekim");
            //        break;
            //    case 11: Console.WriteLine("Kasım");
            //        break;
            //    case 12: Console.WriteLine("Aralık");
            //        break;
            //    default: Console.WriteLine("Hatalaı veri girişi yılın 12 ayı vardır.");
            //        break;
            //}


            //int ay1 = DateTime.Now.Month;

            //    switch (ay1)
            //    {
            //        case 1:
            //    Console.WriteLine("ocak ayındsınz");
            //    break;
            //case 2:
            //    Console.WriteLine("Şubat ayındsınz");
            //    break;
            //case 3:
            //    Console.WriteLine("Mart ayındsınz");
            //    break;
            //case 4:
            //    Console.WriteLine("Nisan ayındsınz");
            //    break;
            //case 6:
            //    Console.WriteLine("Haziran ayındsınz");
            //    break;
            //case 12:
            //    Console.WriteLine("Aralık ayındsınz");
            //    break;
            //}


            //switch (ay1)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Kış ayındasını!");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("İlkbahar ayındasınız");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Yaz ayındasınız");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Sonbahar ayındasınız");
            //        break;

            //}

            #endregion

            #region Switch Case Hesap Makines

            //int sayi1, sayi2, sonuc;
            //char sembol;

            //Console.WriteLine("SWİTCH CASE MANTIĞIYLA HESAP MAKİNESİ UYGULAMASI");

            //Console.WriteLine("1. sayıyı giriniz: ");
            //sayi1=int.Parse(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz: ");
            //sayi2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğin işlemi seçiniz: (+,-,/,");
            //sembol=char.Parse(Console.ReadLine());

            //switch(sembol)
            //{
            //    case '+':
            //        sonuc = sayi1 + sayi2;
            //        Console.WriteLine("Toplam: "+ sonuc);
            //        break;
            //    case '-':
            //        sonuc = sayi1 - sayi2;
            //        Console.WriteLine("Çıkartma: " + sonuc);
            //        break;
            //    case '*':
            //        sonuc = sayi1 * sayi2;
            //        Console.WriteLine("çarpmım : "+sonuc);
            //        break;
            //    case '/':
            //        sonuc = sayi1 / sayi2;
            //        Console.WriteLine("Bölne işlemi: "+sonuc);
            //        break;

            //}


            // sıralı if kullanımı nedir nasıl çıktı verir?

            //int deger1 = 0;

            //if(deger1 >= 0)
            //{
            //    deger1 = deger1 + 10;

            //}
            //if (deger1 >= 0)
            //{
            //    deger1 += 10;

            //}
            //Console.WriteLine(deger1);



            //if else mantığı nedir?


            //int deger2 = 0;

            //if (deger2 >= 0)
            //{
            //    deger2 = deger2 + 10;
            //}
            //else
            //{
            //    deger2 = deger2 + 10;
            //}

            //Console.WriteLine(deger2);



            // mod operatörü kullanım örneği

            // mod operaötrü ( % ) işareti ile gösterilir. 
            // bu ifade bir sayının bir sayıya bölümünden kalanı
            // ifade eder. Örneğin  20 % 3 ifadesi 20 sayısının
            // 3 e tam bölümünden kalan değeri bize çıktı olarak verir.
            //  yani 20 %3 değerinin çıktısı 2 olarak karşımıza gelir.
            // mantık olarak 6*3 = 18  değerine ulaşıyoruz ardından 3 ün katı
            // 2 olmadığından 2 bize kalan değer olarak geliyor.
            // kalan değeri de çıktı olacağaını söyledik 


            //int sayix = 25;
            //int sayiy = 3;

            //Console.WriteLine(sayix % sayiy);






            #endregion

            Console.ReadKey();






        }
    }
}
