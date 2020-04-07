using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private string adresZamieszkania;
        private int iloscSamochodow;
        private const int MaxIloscSamochodow = 3;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public string AdresZamieszkania
        {
            get { return adresZamieszkania; }
            set { adresZamieszkania = value; }
        }
        public int IloscSamochodow
        {
            get { return iloscSamochodow; }
            set { iloscSamochodow = value; }
        }

        public Osoba()
        {
            imie = "nieznane";
            nazwisko = "nieznane";
            adresZamieszkania = "nieznane";
            iloscSamochodow = 0;
        }

        public Osoba(string imie_, string nazwisko_, string adresZamieszkania_, string iloscSamochodow_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            adresZamieszkania = adresZamieszkania_;
            iloscSamochodow = 0;
        }

    }
}
