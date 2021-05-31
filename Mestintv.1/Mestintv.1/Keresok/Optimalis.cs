using Mestintv._1.AllapotTer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestintv._1.Keresok
{
    class Optimalis : Kereso
    {

        public Optimalis()
        {
            Kereses();
        }


        public override void Kereses()
        {
            List<Csomopont> ut = new List<Csomopont>();
            ut.Add(new Csomopont(new Allapot(), null));

            while (ut.Count > 0 && !ut.Last().Allapot.celfeltetel())
            {
                Csomopont aktualisCsomopont = ut.Last();
                ut.RemoveAt(ut.Count - 1);
                foreach (Operator op in Operatorok)
                {
                    if (op.Elofeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = op.Atrak(aktualisCsomopont.Allapot);
                        //szülő beállítása
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, aktualisCsomopont);

                        if (!ut.Contains(ujCsomopont))
                        {
                            ut.Add(ujCsomopont);
                        }
                        else
                        {
                            int i = ut.IndexOf(ujCsomopont);
                            Csomopont regiCsomopont = ut[i];

                            if (regiCsomopont.Kolteg > ujCsomopont.Kolteg)
                            {
                                ut[i] = ujCsomopont;
                            }
                        }
                    }
                }

                ut.Sort(
                    delegate (Csomopont cs1, Csomopont cs2)
                    {
                        if (cs1.Kolteg > cs2.Kolteg)
                        {
                            return -1;
                        }
                        else if (cs1.Kolteg < cs2.Kolteg)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    });
            }

            if (ut.Count > 0)
            {
                Csomopont celCsomopont = ut.Last();
                while (celCsomopont != null)
                {
                    this.Utvonal.Add(celCsomopont.Allapot);
                    celCsomopont = celCsomopont.Szulo;
                }

                this.Utvonal.Reverse();
            }
        }
    }
}
