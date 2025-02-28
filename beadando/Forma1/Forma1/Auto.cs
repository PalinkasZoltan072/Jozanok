using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
    internal class Auto:IKozos
    {
        public string auto,azonosito;
        public int loero ,csucssebesseg, urtartalom;
        public bool javitasalatte;

        public Auto(string sor)
        {
            string[] st = sor.Split(';');
            auto = st[0];
            azonosito = st[1];
            loero = Convert.ToInt32(st[2]);
            csucssebesseg = Convert.ToInt32(st[3]);
            urtartalom = Convert.ToInt32(st[4]);
            javitasalatte = Convert.ToBoolean(st[5]);


        }

    }
}
