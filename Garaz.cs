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
    }
}
