using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Forma1.teszteles
{
    internal class teszteles
    {




        [TestFixture]
        public class FuttathoTests
        {
            private List<Eredmenyek> eredmenyek;

            [SetUp]
            public void Setup()
            {
                
                eredmenyek = new List<Eredmenyek>
            {
                new Eredmenyek("Max Verstappen;Hungaroring;Red Bull Racing;372;220;1;RB21;True"),
                new Eredmenyek("Carlos Sainz;Hungaroring;Ferrari;345;205;6;SF24;True"),
                new Eredmenyek("Esteban Ocon;Hungaroring;Alpine;320;180;4;A523;True")
            };
            }

            [Test]
            [TestCase("Helyezes", 1)]
            [TestCase("AtlagSeb", 110)] // direkt rossz
            [TestCase("Nev", "Carlos Sainz")]
            [TestCase("Invalid", null)]
            public void Rendezeses_Test(string rend, object expected)
            {
                var result = futtatho.Rendezeses(rend, eredmenyek);

                if (rend == "Helyezes")
                    ClassicAssert.AreEqual(expected, result[0].Helyezes);
                else if (rend == "AtlagSeb")
                    ClassicAssert.AreEqual(expected, result[0].AtlagSeb);
                else if (rend == "Nev")
                    ClassicAssert.AreEqual(expected, result[0].Nev);
                else
                    ClassicAssert.IsTrue(result.Count > 0);
            }

            [Test]
            public void CsapatAdatok_Test()
            {
                var result = futtatho.CsapatAdatok("Red Bull");
                ClassicAssert.IsTrue(result.Count >= 0);
            }

            [Test]
            public void VersenyzoAdatok_Test()
            {
                var result = futtatho.VersenyzoAdatok("Max Verstappen");
                ClassicAssert.IsTrue(result.Count >= 0);
            }

            [Test]
            public void AutoAdatok_Test()
            {
                var result = futtatho.AutoAdatok("RB21");
                ClassicAssert.IsTrue(result.Count >= 0);
            }

            [Test]
            public void Fajlbeolvasas_Test()
            {
                try
                {
                    futtatho.Fajlbeolvasas();
                    ClassicAssert.IsTrue(true);
                }
                catch
                {
                    ClassicAssert.IsTrue(false);
                }
            }

            [Test]
            public void Fajlbeolvasas2_Test()
            {
                try
                {
                    futtatho.Fajlbeolvasas2();
                    ClassicAssert.IsTrue(true);
                }
                catch
                {
                    ClassicAssert.IsTrue(false);
                }
            }

            [Test]
            public void Fajlbeolvasas3_Test()
            {
                try
                {
                    futtatho.Fajlbeolvasas3();
                    ClassicAssert.IsTrue(true);
                }
                catch
                {
                    ClassicAssert.IsTrue(false);
                }
            }

            [Test]
            public void Fajlbeolvasas4_Test()
            {
                try
                {
                    futtatho.Fajlbeolvasas4();
                    ClassicAssert.IsTrue(true);
                }
                catch
                {              
                    ClassicAssert.IsTrue(false);
                }
            }
        }
    }

}

