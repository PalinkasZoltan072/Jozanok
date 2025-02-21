using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1
{
    internal class Csapatok
    {
        public string csapat, versenyzo, auto;
        

        public Csapatok(string sor) 
        {

            string[] st = sor.Split(';');
            csapat = st[0];
            // tobb versenyzo van egy csapatban es akk hogy taroljuk el? 
            versenyzo = st[1];
            auto = st[2];
        }
    }

}
