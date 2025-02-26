using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
    internal class futtatho
    {    // JAVITASRA SZORUL A BEOLVASAS MIVEL AZ ADATOK EGY KICCCCSSIT OSSZEVANNAK KUTYÚVA + tanar ur azt mondta hogy az osztalyba tenne kulon kulon a fajlbeolvasast statikusan!
        static List<Versenyzo> versenyzok = new List<Versenyzo>();
        static List<Auto> autok = new List<Auto>();
        static List<Csapatok> csapat = new List<Csapatok>(); 
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Fajlbeolvasas2();
            Fajlbeolvasas3();

            Console.ReadKey();

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
        private static void Fajlbeolvasas2()
        {
            StreamReader sr = new StreamReader("autok.txt");


            while (!sr.EndOfStream)
            {
                Auto sv = new Auto(sr.ReadLine());

                autok.Add(sv);
            }

            sr.Close();

        }
        private static void Fajlbeolvasas3()
        {
            StreamReader sr = new StreamReader("csapatok.txt");


            while (!sr.EndOfStream)
            {
                Csapatok sv = new Csapatok(sr.ReadLine());

                csapat.Add(sv);
            }

            sr.Close();

        }

    }
}
