using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
    public class Autok :IAdatok
    {
        public string auto { get; set; }
        public string azonosito { get; set; }
        public int loero { get; set; } 
        public int csucssebesseg { get; set; }
        public int urtartalom  {  get; set; }
        public bool javitasalatte { get; set; }

        public Autok(string sor)
        {
            string[] st = sor.Split(';');
            auto = st[0];
            azonosito = st[1];
            loero = Convert.ToInt32(st[2]);
            csucssebesseg = Convert.ToInt32(st[3]);
            urtartalom = Convert.ToInt32(st[4]);
            javitasalatte = Convert.ToBoolean(st[5]);


        }

        public void Kiiratas()
        {
            Console.WriteLine($"{auto} - {azonosito} - {loero} lóerő - {csucssebesseg} km/h - {urtartalom} cm3");
        }

    }
}
