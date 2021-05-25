using Mestintv._1.AllapotTer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestintv._1.Keresok
{
    class Backtrack : Kereso
    {
        int f = 0;
        public Backtrack()
        {
            Kereses();
        }

        public override void Kereses()
        {
            Stack<Csomopont> ut = new Stack<Csomopont>();
            ut.Push(new Csomopont(new Allapot(), 0));

            while (ut.Count > 0 && !ut.Peek().Allapot.celfeltetel())
            {
                Csomopont aktualisCsomopont = ut.Peek();
                if (aktualisCsomopont.OperatorIndex < Operatorok.Count)
                {
                    Operator aktualisOperator = Operatorok[aktualisCsomopont.OperatorIndex];
                    if (aktualisOperator.Elofeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = aktualisOperator.Atrak(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, 0);
                        if (!ut.Contains(ujCsomopont))
                        {
                            ut.Push(ujCsomopont);
                            if (f > 100)
                            {
                                break;
                            }
                            f++;
                        }
                    }
                    aktualisCsomopont.OperatorIndex++;
                }
                else
                {
                    //visszalépés
                    ut.Pop();
                }
            }

            foreach (Csomopont csomopont in ut)
            {
                Utvonal.Add(csomopont.Allapot);
            }
            Utvonal.Reverse();
        }
    }
}
