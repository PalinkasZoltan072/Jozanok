using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
    internal class Versenyzo
    {
        public string nev, csapat, auto;
        public int kor, magassag, helyezes;
        public double legnagyobbseb, atlagseb;
        public bool befejeztee;

        

    
        public Versenyzo(string sor) 
        {
            string[] st = sor.Split(';');
            nev = st[0];
            kor = Convert.ToInt32(st[1]);
            magassag = Convert.ToInt32(st[2]);
            csapat= st[3];
            legnagyobbseb = Convert.ToDouble(st[4]);
            atlagseb = Convert.ToDouble(st[5]);
            helyezes = Convert.ToInt32(st[6]);
            auto = st[7];
            befejeztee = Convert.ToBoolean(st[8]);

        }  
        


    }
}
