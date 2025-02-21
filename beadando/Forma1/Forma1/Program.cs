using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
    internal class Program
    {    // JAVITASRA SZORUL A BEOLVASAS MIVEL AZ ADATOK EGY KICCCCSSIT OSSZEVANNAK KUTYÚVA + tanar ur azt mondta hogy az osztalyba tenne kulon kulon a fajlbeolvasast statikusan!
        static List<Versenyzo> versenyzok = new List<Versenyzo>();
        static List<Auto> autok = new List<Auto>();
        static List<Csapatok> csapat = new List<Csapatok>(); 
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
