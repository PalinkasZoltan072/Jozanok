using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
    public class Versenyzok : IAdatok
    {
        public string nev { get; set; } 
        public string csapat { get; set; }
        public int kor { get; set; }
        public int magassag { get; set; }





        public Versenyzok(string sor) // parameterben atadott string segitsegevel atadjuk az adattagoknak az ertekeket
        {
            string[] st = sor.Split(';');
            nev = st[0];
           
            kor = Convert.ToInt32(st[1]);
            magassag = Convert.ToInt32(st[2]);
            csapat= st[3];
            
           
           

        }

        public void Kiiratas()
        {
            Console.WriteLine($"{nev} - {csapat} - {magassag} cm - {kor} éves ");
        }



    }
}
