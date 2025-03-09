using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
     public class futtatho
    {   
        static List<Versenyzok> versenyzok = new List<Versenyzok>();
        static List<Autok> autok = new List<Autok>();
        static List<Csapatok> csapatok = new List<Csapatok>(); 
       public  static List<Eredmenyek> eredmenyek = new List<Eredmenyek>();
        
        static Random r = new Random();

        /// <summary>
        /// parameterek: rend -> mi alapjan , paly
        /// a rend paraméter alapján rendezi a versenyzoket vagy "helyezes" vagy "kor" vagy "nev" szerint
        /// </summary>
        /// <param name="rend"></param>
        /// <param name="paly"></param>
        /// <returns></returns>
        ///
        

        public static List<Eredmenyek> Rendezeses(string rend, List<Eredmenyek> lista)

        {
            
            if(rend == "Helyezes")
            {
                return lista.OrderBy(x => x.Helyezes).ToList();
            }
            else if(rend == "AtlagSeb")
            {
                return lista.OrderByDescending(x => x.AtlagSeb).ToList();
            }
            else if(rend == "Nev")
            {
                return lista.OrderBy(x => x.Nev).ToList();
            }
            else
            {
                return lista; // ezzel kezeljuk le az adatok validságát
            }
           

        }


       

        /// <summary>
        /// A Csapatadatok metódus kiírja az adott csapat adatait pl: "csapat" -> csapatnev, ket versenyzo es az auto neve
        /// </summary>
        public static List<Csapatok> CsapatAdatok(string cs)

        {
            return csapatok.Where(x => x.csapat == cs).ToList(); // ha nem valid az adat akkor nem megfelelo ertekkel ter vissza tehat ez is le van kezelve (ures lesz a lista)

          
        }
        /// <summary>
        /// A VersenyzoAdatok metódus kiírja az adott csapat adatait pl: "versenyzoneve" -> magassag,kor,csapat amiben versenyzik
        /// </summary>
        public static List<Versenyzok> VersenyzoAdatok(string v)

        {
            return versenyzok.Where(x => x.nev == v).ToList();
        }
        /// <summary>
        /// A AutoAdatok metódus kiírja az adott autó adatait pl: "autoazonosito" -> urtaltalom, javitasalattalle stb....
        /// </summary>
        public static List<Autok> AutoAdatok(string a)

        {
            return autok.Where(x => x.azonosito == a).ToList();
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
        /// <summary>
        /// Beolvassa a "eredmenyek.txt" adatállományát és beleteszi a csapat listába
        /// </summary>
        public static void Fajlbeolvasas4()
        {
            StreamReader sr = new StreamReader("eredmenyek.txt");

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
