using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
    internal class Program
    {    // JAVITASRA SZORUL A BEOLVASAS MIVEL AZ ADATOK EGY KICCCCSSIT OSSZEVANNAK KUTYÚVA
        static List<Versenyzo> versenyzok = new List<Versenyzo>();
        static List<Auto> autok = new List<Auto>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
        }

        private static void Fajlbeolvasas()
        {
            StreamReader sr = new StreamReader("versenyzok.txt");

            while (!sr.EndOfStream)
            {
               Versenyzo sv = new Versenyzo(sr.ReadLine());
                versenyzok.Add(sv);
            }

            sr.Close();

        }
    }
}
