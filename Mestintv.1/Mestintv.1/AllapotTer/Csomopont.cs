using Mestintv._1.AllapotTer;
using System;

namespace Mestintv._1.Keresok
{
    internal class Csomopont
    {
        internal Allapot Allapot { get => allapot; set => allapot = value; }
        internal Csomopont Szulo { get => szulo; set => szulo = value; }
        public int Kolteg { get => kolteg; set => kolteg = value; }
        public int OperatorIndex { get => operatorIndex; set => operatorIndex = value; }
        public int Heurisztika { get => heurisztika; set => heurisztika = value; }
        public int Osszkolteg { get => osszkolteg; set => osszkolteg = value; }
      
        Csomopont szulo;
        Allapot allapot;
        int kolteg;

        int operatorIndex;

        int heurisztika;

        int osszkolteg;


        public Csomopont(Allapot allapot, int opindex)
        {
            this.allapot = allapot;
            this.operatorIndex = opindex;
        }
        public Csomopont(Allapot allapot, Csomopont szulo)
        {
            this.allapot = allapot;
            this.Szulo = szulo;

            if (szulo == null)
            {
                kolteg = 0;
            }
            else
            {
                this.kolteg = this.Szulo.Kolteg + 1;
            }

            this.heurisztika = 0;
          

            this.osszkolteg = this.kolteg + (-1) * this.heurisztika;


        }
        public override string ToString()
        {
            return allapot.ToString();
        }
        public override bool Equals(object obj)
        {
            Csomopont osszehasonlitandoCsomopont = (Csomopont)obj;
            return Allapot.Equals(osszehasonlitandoCsomopont.Allapot);
        }
    }
}