using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    class Samochod
    {
        private string marka;
        private string model;
        private string numerRejestracyjny;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;


        public string Marka
        {
            get { return marka; }
            set { marka  = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string NumerRejestracyjny
        {
            get { return numerRejestracyjny; }
            set { numerRejestracyjny = value; }
        }


        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }

        public int PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }

        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        private static int iloscSamochodow = 0;

        public Samochod ()
        {
            marka = "nieznana";
            model = "nieznany";
            numerRejestracyjny = "nieznany";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0.0;

            iloscSamochodow++;
        }

        public Samochod (string marka_, string model_, string numerRejestracyjny_, int iloscDrzwi_, int pojemnoscSilnika_, double srednieSpalanie_)
        {
            marka = marka_;
            model = model_;
            numerRejestracyjny = numerRejestracyjny_;
            iloscDrzwi = iloscDrzwi_;
            pojemnoscSilnika = pojemnoscSilnika_;
            srednieSpalanie = srednieSpalanie_;

            iloscSamochodow++;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (srednieSpalanie * dlugoscTrasy) / 100;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double spalanie = ObliczSpalanie(dlugoscTrasy);
            double kosztPrzejazdu = spalanie * cenaPaliwa;
            return kosztPrzejazdu;
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Marka:{marka}");
            Console.WriteLine($"Model:{model}");
            Console.WriteLine($"Numer rejestracyjny:{numerRejestracyjny}");
            Console.WriteLine($"Ilosc drzwi:{iloscDrzwi}");
            Console.WriteLine($"Pojemność silnika:{pojemnoscSilnika}");
            Console.WriteLine($"Srednie spalanie:{srednieSpalanie}\n");
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine($"Ilość utworzonych obiektów typu Samochód: {iloscSamochodow}\n");
        }

    }
}
