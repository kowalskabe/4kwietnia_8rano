using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    class Garaz
    {
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;

   
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public int Pojemnosc
        {
            get { return pojemnosc; }
            set 
            { 
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }

        public Garaz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }

        public Garaz (string adres_, int pojemnosc_)
        {
            adres = adres_;
            pojemnosc = pojemnosc_;
            samochody = new Samochod[pojemnosc];
        }

        public void WprowadzSamochod (Samochod s)
        {
            if (liczbaSamochodow >= pojemnosc)
            {
                Console.WriteLine("Nie da się wprowadzić samochodu");
            }
            else
            {
                samochody[liczbaSamochodow] = s;
                liczbaSamochodow++;
            }
        }

        public Samochod WyprowadzSamochod()
        {
            if (liczbaSamochodow == 0)
            {
                Console.WriteLine("Garaż jest pusty");
                return null;
            }
            else
            {
                Samochod kopiaSamochodu = samochody[liczbaSamochodow];
                samochody[liczbaSamochodow] = null;
                liczbaSamochodow--;
                return kopiaSamochodu;
            }
        }


    }
}
