using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
    internal class Versenyzok
    {
        public string nev,palya ,csapat, helyezes, auto;
        public int kor, magassag;
        public double legnagyobbseb, atlagseb;
        public bool befejeztee;

        

    
        public Versenyzok(string sor) // parameterben atadott string segitsegevel atadjuk az adattagoknak az ertekeket
        {
            string[] st = sor.Split(';');
            nev = st[0];
            palya = st[1];
            kor = Convert.ToInt32(st[2]);
            magassag = Convert.ToInt32(st[3]);
            csapat= st[4];
            legnagyobbseb = Convert.ToDouble(st[5]);
            atlagseb = Convert.ToDouble(st[6]);
            auto = st[8];
            //helyezes = Convert.ToInt32(st[7]);
            helyezes = st[7];

            befejeztee = Convert.ToBoolean(st[9]);

        }  
        


    }
}
