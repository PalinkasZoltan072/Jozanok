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
        static List<Palyak> palyak = new List<Palyak>();
        
        static Random r = new Random();
<<<<<<< HEAD
       
        public static List<Versenyzok> Rendezeses(string rend, string paly)
=======

       /// <summary>
       /// parameterek: rend -> mi alapjan , paly
       /// a rend paraméter alapján rendezi a versenyzoket vagy "helyezes" vagy "kor" vagy "nev" szerint
       /// </summary>
       /// <param name="rend"></param>
       /// <param name="paly"></param>
       /// <returns></returns>
       ///
        private static List<Versenyzok> Rendezeses(string rend, string paly)
>>>>>>> e518b2a3d8432d0ae363b5a53976131c3313be56
        {
            
            if(rend == "helyezes")
            {
                return versenyzok.Where(x => x.palya == paly).OrderByDescending(x => x.helyezes).ToList();
            }
            else if(rend == "kor")
            {
                return versenyzok.Where(x => x.palya == paly).OrderByDescending(x => x.kor).ToList();
            }
            else if(rend == "nev")
            {
                return versenyzok.Where(x => x.palya == paly).OrderByDescending(x => x.nev).ToList();
            }
            else
            {
                return null; // ha nem jó a bekert adat akkor majd hibakezelesnel le kell kezelni addig így lesz megoldva
            }
           

        }
<<<<<<< HEAD

        public static string Adatok(string adat)
=======
        /// <summary>
        /// Az Adatok metódus bekér egy adatot és a kiválasztott adat alapján kiíratja a megadott adat listájának tulajdonságait pl: "csapat" -> csapatnev, ket versenyzo es az auto neve
        /// </summary>
        public static void Adatok()
>>>>>>> e518b2a3d8432d0ae363b5a53976131c3313be56
        {
            //Console.WriteLine("Adjon meg, hogy minek az adatai kellenek: ");
            //string adat = Console.ReadLine();

            if(adat == "versenyzok")
            {
                for (int i = 0; i < versenyzok.Count(); i++)
                {
                        return versenyzok[i].nev + " " + versenyzok[i].palya + " " + versenyzok[i].csapat + " " + versenyzok[i].helyezes + " " + versenyzok[i].auto + " " + versenyzok[i].kor + " " + versenyzok[i].magassag + " " + versenyzok[i].legnagyobbseb + " " + versenyzok[i].atlagseb + " " + versenyzok[i].befejeztee;
                }
            }
            
            else if(adat == "csapat")
            {
                for (int i = 0; i < csapat.Count(); i++)
                {
                    return ($"{csapat[i].csapat} {csapat[i].elsoversenyzo} {csapat[i].masodikversenyzo} {csapat[i].auto}");
                }
            }
            else
            {
                for (int i = 0; i < autok.Count(); i++)
                {
                    return ($"{autok[i].auto} {autok[i].azonosito} {autok[i].loero} {autok[i].csucssebesseg} {autok[i].urtartalom} {autok[i].javitasalatte}");
                }
            }
            return "";
            
        }

        public static void PalyaEredmenyek()
        {
            Console.WriteLine("Adjon meg egy pályát:");
            string palya = Console.ReadLine();
            //kiiratas(palya);
            Console.WriteLine("Mi alapján rendezzünk? :");
            string rend = Console.ReadLine();
            Rendezeses(rend, palya);
            
        }

        

        /*static void kiiratas(string palya) 
        {
            for (int i = 0; i < versenyzok.Count(); i++)
            {
                if (versenyzok[i].palya == palya)
                {
                    Console.WriteLine(versenyzok[i].nev + " " + versenyzok[i].palya + " " + versenyzok[i].csapat + " " + versenyzok[i].helyezes + " " + versenyzok[i].auto + " " + versenyzok[i].kor + " " + versenyzok[i].magassag + " " + versenyzok[i].legnagyobbseb + " " + versenyzok[i].atlagseb + " " + versenyzok[i].befejeztee);
                }
            }

<<<<<<< HEAD
        }*/

=======
        }
        /// <summary>
        /// Beolvassa a "versenyzok.txt" adatállományát és beleteszi a versenyzok listába
        /// </summary>
>>>>>>> e518b2a3d8432d0ae363b5a53976131c3313be56
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
        /// <summary>
        /// Beolvassa a "autok.txt" adatállományát és beleteszi a autok listába
        /// </summary>
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
        /// <summary>
        /// Beolvassa a "csapatok.txt" adatállományát és beleteszi a csapat listába
        /// </summary>
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
