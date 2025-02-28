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
        static List<Versenyzok> versenyzok = new List<Versenyzok>();
        static List<Autok> autok = new List<Autok>();
        static List<Csapatok> csapat = new List<Csapatok>(); 
        
        static Random r = new Random();
       
        private static List<Versenyzok> Rendezeses(string rend, string paly)
        {
            
            if(rend == "helyezes")
            {
                return versenyzok.Where(x => x.palya == paly).OrderByDescending(x => x.helyezes).ToList();
            }
            else if(rend == "kor")
            {
                return versenyzok.Where(x => x.palya == paly).OrderByDescending(x => x.kor).ToList();
            }
            else
            {
                return versenyzok.Where(x => x.palya == paly).OrderByDescending(x => x.nev).ToList();
            }
           

        }

        public static void Adatok()
        {
            Console.WriteLine("Adjon meg, hogy minek az adatai kellenek: ");
            string adat = Console.ReadLine();

            if(adat == "versenyzok")
            {
                for (int i = 0; i < versenyzok.Count(); i++)
                {
                        Console.WriteLine(versenyzok[i].nev + " " + versenyzok[i].palya + " " + versenyzok[i].csapat + " " + versenyzok[i].helyezes + " " + versenyzok[i].auto + " " + versenyzok[i].kor + " " + versenyzok[i].magassag + " " + versenyzok[i].legnagyobbseb + " " + versenyzok[i].atlagseb + " " + versenyzok[i].befejeztee);
                }
            }
            
            else if(adat == "csapat")
            {
                for (int i = 0; i < csapat.Count(); i++)
                {
                    Console.WriteLine($"{csapat[i].csapat} {csapat[i].elsoversenyzo} {csapat[i].masodikversenyzo} {csapat[i].auto}");
                }
            }
            else
            {
                for (int i = 0; i < autok.Count(); i++)
                {
                    Console.WriteLine($"{autok[i].auto} {autok[i].azonosito} {autok[i].loero} {autok[i].csucssebesseg} {autok[i].urtartalom} {autok[i].javitasalatte}");
                }
            }
            
        }

        public static void PalyaEredmenyek()
        {
            Console.WriteLine("Adjon meg egy pályát:");
            string palya = Console.ReadLine();
            kiiratas(palya);
            Console.WriteLine("Mi alapján rendezzünk? :");
            string rend = Console.ReadLine();
            Rendezeses(rend, palya);
            
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

        public static void Fajlbeolvasas()
        {
            StreamReader sr = new StreamReader("versenyzok.txt");

            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Versenyzok sv = new Versenyzok(sr.ReadLine());

                versenyzok.Add(sv);
            }

            sr.Close();

        }
        public static void Fajlbeolvasas2()
        {
            StreamReader sr = new StreamReader("autok.txt");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                Autok sv = new Autok(sr.ReadLine());

                autok.Add(sv);
            }

            sr.Close();

        }
        public static void Fajlbeolvasas3()
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
