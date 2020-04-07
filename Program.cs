using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod("Fiat", "126p", "PZL 1234", 2, 650, 6.0);
            Samochod s2 = new Samochod("Syrena", "105", "GDA 57T8", 2, 800, 7.6);
            Garaz g1 = new Garaz();
            Osoba o1 = new Osoba("Zbigniew", "Kowalski", "ul. 23 marca 13");

            g1.Adres = "ul. Garażowa 1";
            g1.Pojemnosc = 1;
            Garaz g2 = new Garaz("ul. Garażowa 2", 2);
            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();
            g1.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod();
            Console.ReadKey();

        }
    }
}
