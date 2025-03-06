using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
    internal class Csapatok :IAdatok
    {
        public string csapat, elsoversenyzo,masodikversenyzo, auto;
        

        public Csapatok(string sor) 
        {

            string[] st = sor.Split(';');
            csapat = st[0];
            string[] versenyzok = st[1].Split(',');
            elsoversenyzo = versenyzok[0];
            // tobb versenyzo van egy csapatban es akk hogy taroljuk el? 
            masodikversenyzo = versenyzok[1];
            auto = st[2];
        }

        public void Kiiratas()
        {
            Console.WriteLine($"{csapat} - {elsoversenyzo} - {masodikversenyzo} - {auto}");
        }
    }

}
