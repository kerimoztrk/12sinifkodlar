using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _12a
{
    public class Hayvan //BASİT ŞEKİLDE CLASS(SINIF) TANIMLAMA
    {

    }
    internal class Program
    {


        class Telefon2
        {
            public void aramaYap()
            {
                Console.WriteLine("nımara aranıyor");
            }
        }


        class AkilliTelefon : Telefon2
        {
            public new void AramaYap()
            {
                Console.WriteLine("whatsap Araması yapılıyor.");
            }
        }

        class Arac
        {
            public void hareketEt()
            {
                Console.WriteLine("Araç hareket ediyor.");
            }
        }

        class araba2: Arac
        {
            public void CamAc()
            {
                Console.WriteLine("Arabanın camı açılıyor");
            }
        }
        //Hiyerarşik kalıtım örneği
        class Motosiklet : Arac
        {
            public void TekTekerSur()
            {
                Console.WriteLine("Motosiklet tek teker yaptı.");
            }
        }


        



        class Hayvan
        {
            public string Ad;
            public void Sescİkar()
            {
                Console.WriteLine("Bir hayvan ses çıkardı.");
            }
        }

        class Kedi : Hayvan
        {
            public void Miyavla()
            {
                Console.WriteLine("Miyavvvv!");
            }
        }


        class Kopek : Hayvan 
        {
            public void Havla()
            {
                Console.WriteLine("Hav havv");
            }
        }


        class Telefon
        {
            public string marka;
            public int pilSeviyesi;

            //yapıcı metot (constructor örneği)
            public Telefon (string markAdi)
            {
                marka = markAdi;
                pilSeviyesi = 100;
                Console.WriteLine($"{marka} telefonu açıldı. Pil: {pilSeviyesi}%");
            }


            //Yıkıcı metot (destructor)
            ~Telefon()
            {
                Console.WriteLine($"{marka} kapatıldı, hafıza temizlendi.");
            }


        }
        public void Yazdir(int sayi)
        {
            Console.WriteLine(sayi);
        }
        static void Main(string[] a1rgs)
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

            /*
             * değişken isimlendirme kuralları
             * 
             * degisken sayıyla başlayamaz
             * degisken eğer birden fazla kelimeden oluşuyorsa veya kelimenın harflerinin arasında
             * herhangi bir boşuk ifadesi konulamaz
             * Programlama dilindeki özel kelimeler degisken ismi olarak
             * adlandırılamaz bunlar örenk olarak if,else,for,while gibi kelimeler
             * örnek verilebilir. Bu tarz kelimeler dehisken ismi
             * olarak asla görülemez. for diye bulumaz ancak for2 gibi bir kullanım
             * özel bir anahtar kelimeye denk gelmediğinden kullanılabilir.
             * 
             * geçerli bir değişken adlandırmasına örnek =    ogrenciNumarasi
             * geçersiz bir değişken adlandırmasına örnek = 12öğrenciAdı 
             * 
             */


            /* 
             * degisken tanımlama tekrar
             * 
             * eğer sayısal (tamsayi bir değişken tanımlanması isteniyorsa örnek bir alt satırdaki gibi olmalıdır.
             * 
             * int ogrenciNumarasi= 14321 ;
             * 
             * eğer Metin karakterleri içeren bir değişken tanımlanması isteniyorsa örnek bir alt satırdaki gbi olmalıdır.
             * 
             * string gunlukGorevler = " Bugun ders çalışılacak" ;
             * 
             * eğer tek bir karakter içeren değişken tanımlanması isteniyorsa örnek bir alt satırdaki gibidir.
             * 
             * char karakter = ' A ' ;
             * 
             * eğer ondalıklı bir sayı değeri tutan değişken oluşturulması isteniyorsa örnek bir alt satırdaki gibi olmalıdır.
             * 
             * double meyveFiyatı= 12.53 ;
             * 
             * 
             * örnek değişken tanımlamaları bu şekildedir kontrol ediniz.
            */


            #endregion

            #region For Döngüsü

            //döngüler 1+2+3+5

            // for (x;u;z)

            // x = başlangıc
            // y= bitiş
            // z = artış veya azalış miktarı

            //int i;

            //for(i=1;i<=5; i++)
            //{
            //    Console.WriteLine(i+")c# eğitiim dersi");
            //}

            //for(int i = 1; i<5; i++)
            //{
            //    Console.WriteLine(i+") ikinci çıktı sayısı");
            //}


            //for( int i= 5; i >= 1; i--)
            //{
            //    Console.WriteLine(i+") üçüncü kod çıktısı");
            //}

            //for (int i = 3; i <= 51; i += 3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("Lütfen ekrana yazılmasıı istediğiniz adeti giriniz.");
            //int bitisDegeri=int.Parse(Console.ReadLine());

            //for(int i=1; i <= bitisDegeri; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion


            #region For döngüsü ile karar yapıları

            //for (int i=1;i <=100;i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int toplamDeger = 0;
            //for(int i=1; i <= 10; i++)
            //{
            //    toplamDeger = toplamDeger + i;
            //}
            //Console.WriteLine(toplamDeger);

            //int toplam2 = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //         toplam2 += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine( "--------------");
            //Console.WriteLine(toplam2);

            //int sayac = 0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        sayac++;
            //    }

            //}
            //Console.WriteLine( "-------------");
            //Console.WriteLine(sayac);


            //int bakteri = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine( i +".Saat sonunda : "+ bakteri);
            //}

            #endregion

            #region While Döngüsü

            //while(şart)
            //{
            //    işlemler ve kodları
            //}


            //int i = 1;
            //while( i<= 10)
            //{
            //    Console.WriteLine("merhaba Dünya");
            //    i++;
            //}


            //int i = 1;

            //while (i <= 10)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}






            #endregion

            #region oop
            //Ogrenci ogrenci = new Ogrenci();

            //ogrenci.BilgileriGoster();


            //metotlar 


            //void SelamVer()
            //{
            //    Console.WriteLine("Merhaba!!");
            //}


            //Varsayılan Değerli Parametreler( Optional ParameterS)


            //void SelamVer(string isim = " Ziyaretçi")
            //{
            //    Console.WriteLine("Merhaba "+isim);
            //}

            //SelamVer();
            //SelamVer("Ali");


            //isimlendirilmiş parametreler


            //void BilgiYaz(string ad,int yas)
            //{
            //    Console.WriteLine($"Ad: {ad}, Yas: {yas}");
            //}

            //BilgiYaz("Ali", 145);

            //BilgiYaz(yas:32, ad:"ahmet");



            //PARAMAETRE DİZİLERİ PARAMS


            //void SayilarıTopla(params int[] sayilar)
            //{
            //    int toplam = 0;

            //    foreach (int sayi in sayilar)
            //    {
            //        toplam += sayi;
            //    }
            //    Console.WriteLine("Toplam="+ toplam);
            //}

            //SayilarıTopla(2,3,5,6,1,5234,234,234,234);
            //SayilarıTopla(2, 3, 5, 6, 1, 5234, 234, 234, 234, 123, 213, 123, 123, 123, 12);


            //metodu sonlandırma (return)


            //int KareAl(int sayi)
            //{
            //    return sayi * sayi;
            //}

            //int sonuc = KareAl(5);
            //Console.WriteLine(sonuc);




            // method overloading ( Aşırı yükleeme)


            //void Yazdir(string mesaj)
            //{
            //    Console.WriteLine(mesaj);
            //}

            //Yazdir("mesajjasasdaasd");








            #endregion


            #region Constructor ve Destructor ( Yapıcı ve yıkıcı metot)



            // Yapıcı metotlar  Constructor: bir sınıftan nesne oluşturulduğıunda çalışan özel bir metotdur.
            // yapıcı metot sınıf adıyla aynı olmalı ve geriye değer döndürmemelidir.

            //Telefon telefon1 = new Telefon("Samsung");
            //Telefon telefon2 = new Telefon("Iphone");
            //Telefon telefon3 = new Telefon("Xioami");




            ////Yıkıcı Metotlar Destructor : Bir nesne ile işimiz bittiğinde hafızadan temizlenmesi gerekir. İşte Yıkıcı metolar yani destructorlar bu işlevi görür.
            ////yıkıcı metot özellikleri;  - Tilde (~) işareti ile tanımlanır   -Parametre almaz - Geriye değer döndürmez.w





            //// ref kullaıımı örenği mektuo gönderme
            //void Degistir(ref int sayi)
            //{
            //    sayi += 10;
            //}

            //int x = 5;
            //Degistir(ref x);
            //Console.WriteLine(x);
            ////burada x değerinin değişme sebebi referans olarak gönderilmesidir.




            ////out kulllanımı

            //void Hesapla(out int sonuc)
            //{
            //    sonuc = 100;
            //}

            //int notDegeri;
            //Hesapla(out notDegeri);
            //Console.WriteLine(notDegeri);

            //bazı metotlar bieden fazla değer döndürmek isteyebilir.Bu durumda out parametresi kullanılarak bir değişkeni başlatmadan metoda gmnderebilriz.
            //out kullanınca değişkenin ilk başta değer alması gerekmez.

            #endregion

            //kalıtıma giriş

            #region KALITIM


            //Kedi kedi1 = new Kedi();

            //kedi1.Ad = "Boncuk";
            //kedi1.Sescİkar();
            //kedi1.Miyavla();


            //Kopek kopek1= new Kopek();

            //kopek1.Ad = "Karabaş";
            //kopek1.Sescİkar();
            //kopek1.Havla();



            //Hiyararsik kalıtım
            //araba2 araba1=new araba2);

            //araba1.hareketEt();
            //araba1.CamAc();


            //Motosiklet motor1=new Motosiklet();
            //motor1.hareketEt();
            //motor1.TekTekerSur();


            //new anahtar kelimesi ile metot gölgeleme

            #endregion


            #region Bir boyutlu diziler

            //en temel haliyle dizi tanımı
            //int[] sayiler = new int[5];

            ////Diziler oluşturulurken tanımlama yapılabalir

            //int[] sayilar2 = { 10, 20, 30, 40 };


            ////new anahtar kelimesi ile değer atama

            //int[] sayiler3 = new int []{ 10, 20, 30 };

            ////bir boyutlu dizilerde değer aktarmaa

            //int[] sayiler5 = new int[3];

            //sayiler5[0] = 5;
            //sayiler5[1] = 10;
            //sayiler5[2] = 20;

            //// Bir boyulu dizi elemanlarına erişim

            int[] sayilar7 = { 5, 10, 15 };
            //Console.WriteLine(sayilar7[2]);
            //Console.WriteLine(sayilar7[2]);
            //Console.WriteLine(sayilar7[2]);


            //for (int i = 0;i < sayilar7.Length; i++)
            //{
            //    Console.WriteLine(sayilar7[i]);
            //}


            // ÖRNEK


            //int[] notlar = { 60, 70, 80, 85, 90 };
            //int toplam = 0;

            //for (int i = 0; i < notlar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}. öğrencinin notu: {notlar[i]}");
            //    toplam = toplam+ notlar[i];

            //}

            //int ortalama = toplam / notlar.Length;

            //Console.WriteLine($"Sınıfın ortalaması: {ortalama}");

            //dizilerde foreach döngüsü kullanımı

            //string[] meyveler = { "Elma", "Armut", "Muz", "Kiraz" };


            //foreach (string eleman in meyveler)
            //{
            //    Console.WriteLine(eleman);
            //}


            // Bir boyutlu dizilerde kullanılan özellikler ve metotlar


            //length = dizinin eleman sayısını verir.

            //Rank = Dizinin boyut sayısını verir ( tek boyutluysa her zaman 1 döner)


            int[] sayilar12 = { 13, 26, 9, 12 };

            Console.WriteLine("Eleman sayısını: "+ sayilar12.Length);
            Console.WriteLine("Boyut Sayısı: " + sayilar12.Rank);

            //Array.Sort() = bu fonksiyon diziyi küçükten büyüğe sıralar

            Array.Sort(sayilar12);

            foreach (int eleman in sayilar12)
            {
                Console.WriteLine(eleman);
            }

            #endregion




            Console.ReadLine();



        }
    }
}