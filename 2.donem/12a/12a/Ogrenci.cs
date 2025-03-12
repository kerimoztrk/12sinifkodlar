using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _12a
{
    public class Ogrenci
    {
        public string Ad; // Her yerden erisilir
        public int yas;
        private int OkulNumarası; //ualnızca Sınıf içinde erişilebilri.
        protected string Okul; //Bu sınıf ve kalıtım alan sınıflardan erişilebilir.
        internal string Numara; //Aynı projedeki sınıflar erişebilir.



        public void BilgileriGoster()
        {
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("okul numarası:"+ OkulNumarası);
            Console.WriteLine("okul:" + Okul);
        }

        public int Yass
        {
            get { return yas;}  //get: özelliğin değerini almak için kullanılır.
            set { if (value > 0)
                { yas = value; }
                else
                {
                    Console.WriteLine("Yas 0 dan kcuuk olamaz"); ;
                } 
                        } //set: özelliğin değerini ayarlamak için kullanılır.


        }

    }
}
