using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        
        static Random r = new Random();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Fajlbeolvasas2();
            Fajlbeolvasas3();
            PalyaEredmenyek();

            Console.ReadKey();

            //Rendezeses();

        }

        private static void RendezesesFeladat()
        {
            Console.WriteLine("Mi alapján rendezzünk? :");
            string rend = Console.ReadLine();
            Rendezeses(rend);

        }

        private static void Rendezeses(string rend)
        {
           
            
                
            
            //for (int i =  - 1; i > 0; i--)
            //    for (int j = 0; j < i; j++)
            //        if (t[j] > t[j + 1])
            //        {
            //            int tmp = t[j + 1];
            //            t[j + 1] = t[j];
            //            t[j] = tmp;
            //        }

        }

        private static void PalyaEredmenyek()
        {
            Console.WriteLine("Adjon meg egy pályát:");
            string palya = Console.ReadLine();
            kiiratas(palya);
        }

        static void kiiratas(string palya) 
        {
            for (int i = 0; i < versenyzok.Count(); i++)
            {
                if (versenyzok[i].palya == palya)
                {
                    Console.WriteLine(versenyzok[i].nev + " " + versenyzok[i].palya + " " + versenyzok[i].csapat + " " + versenyzok[i].helyezes + " " + versenyzok[i].auto + " " + versenyzok[i].kor + " " + versenyzok[i].magassag + " " + versenyzok[i].legnagyobbseb + " " + versenyzok[i].atlagseb + " " + versenyzok[i].befejeztee);
                }
            }


        }

        private static void Fajlbeolvasas()
        {
            StreamReader sr = new StreamReader("versenyzok.txt");

            sr.ReadLine();
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

            sr.ReadLine();

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

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                Csapatok sv = new Csapatok(sr.ReadLine());

                csapat.Add(sv);
            }

            sr.Close();

        }

    }
}
