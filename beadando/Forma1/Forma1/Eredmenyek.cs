using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
    internal class Eredmenyek:IAdatok
    {
        public string Nev {  get; set; }
        public string Palya;
        public string Csapat { get; set; }

        public int LegnagyobbSeb { get; set; }
        public int AtlagSeb { get; set; }
        public int Helyezes {  get; set; }

        public string AutoAzonostio {  get; set; }
        public bool BefejezteE { get; set; }

        public Eredmenyek(string sor) // parameterben atadott string segitsegevel atadjuk az adattagoknak az ertekeket
        {
            string[] st = sor.Split(';');
            Nev = st[0];
            Palya = st[1];
            Csapat = (st[2]);
            LegnagyobbSeb = Convert.ToInt32(st[3]);
            AtlagSeb = Convert.ToInt32( st[4]);
            Helyezes = Convert.ToInt32(st[5]);
            AutoAzonostio = (st[6]);
            BefejezteE = Convert.ToBoolean( st[8]);
            

        }
        public void Kiiratas()
        {
            Console.WriteLine($"{Nev} - {Palya} - {Csapat}  - {LegnagyobbSeb} km/h - {AtlagSeb} km/h - {Helyezes}. - {AutoAzonostio} - {BefejezteE} ");
        }
    }
}
