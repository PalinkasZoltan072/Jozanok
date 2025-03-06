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
        static List<Csapatok> csapatok = new List<Csapatok>(); 
        static List<Eredmenyek> eredmenyek = new List<Eredmenyek>();
        
        static Random r = new Random();


       


       /// <summary>
       /// parameterek: rend -> mi alapjan , paly
       /// a rend paraméter alapján rendezi a versenyzoket vagy "helyezes" vagy "kor" vagy "nev" szerint
       /// </summary>
       /// <param name="rend"></param>
       /// <param name="paly"></param>
       /// <returns></returns>
       ///
        public static List<Eredmenyek> Rendezeses(string rend, string paly)

        {
            
            if(rend == "helyezes")
            {
                return eredmenyek.Where(x => x.Palya == paly).OrderByDescending(x => x.Helyezes).ToList();
            }
            else if(rend == "kor")
            {
                return eredmenyek.Where(x => x.Palya == paly).OrderByDescending(x => x.Csapat).ToList();
            }
            else if(rend == "nev")
            {
                return eredmenyek.Where(x => x.Palya == paly).OrderByDescending(x => x.Nev).ToList();
            }
            else
            {
                return null; // ha nem jó a bekert adat akkor majd hibakezelesnel le kell kezelni addig így lesz megoldva
            }
           

        }


       

        /// <summary>
        /// Az Adatok metódus bekér egy adatot és a kiválasztott adat alapján kiíratja a megadott adat listájának tulajdonságait pl: "csapat" -> csapatnev, ket versenyzo es az auto neve
        /// </summary>
        public static List<Csapatok> CsapatAdatok(string cs)

        {
            return csapatok.Where(x => x.csapat == cs).ToList();

          
        }
        public static List<Versenyzok> VersenyzoAdatok(string v)

        {
            return versenyzok.Where(x => x.nev == v).ToList();
        }
        public static List<Autok> AutoAdatok(string a)

        {
            return autok.Where(x => x.azonosito == a).ToList();
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

        



        
        /// <summary>
        /// Beolvassa a "versenyzok.txt" adatállományát és beleteszi a versenyzok listába
        /// </summary>

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

                csapatok.Add(sv);
            }

            sr.Close();

        }
        public static void Fajlbeolvasas4()
        {
            StreamReader sr = new StreamReader("csapatok.txt");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                Eredmenyek sv = new Eredmenyek(sr.ReadLine());

                eredmenyek.Add(sv);
            }

            sr.Close();

        }

    }
}
