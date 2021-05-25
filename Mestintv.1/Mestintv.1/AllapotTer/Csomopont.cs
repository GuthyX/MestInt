using Mestintv._1.AllapotTer;
using System;
using System.Drawing;

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

            int[] z10 = { 4, 0 };
            int[] z11 = { 4, 1 };
            int[] z12 = { 4, 2 };
            int[] z20 = { 4, 0 };
            int[] z21 = { 4, 1 };
            int[] z22 = { 4, 2 };
            int[] z30 = { 4, 0 };
            int[] z31 = { 4, 1 };
            int[] z32 = { 4, 2 };

            int[] p10 = { 0, 0 };
            int[] p11 = { 0, 1 };
            int[] p12 = { 0, 2 };
            int[] p20 = { 0, 0 };
            int[] p21 = { 0, 1 };
            int[] p22 = { 0, 2 };
            int[] p30 = { 0, 0 };
            int[] p31 = { 0, 1 };
            int[] p32 = { 0, 2 };


            if (szulo != null && CélMezőnVanEaBábú(z10[0],z10[1], szulo.allapot,"Z1" ))
            {
                kozelebb(z11[0], z11[1], szulo.allapot, "Z2");
                kozelebb(z12[0], z12[1], szulo.allapot, "Z3");
                kozelebb(p10[0], p10[1], szulo.allapot, "P1");
                kozelebb(p11[0], p11[1], szulo.allapot, "P2");
                kozelebb(p12[0], p12[1], szulo.allapot, "P3");

                if (!CélMezőnVanEaBábú(z10[0], z10[1], szulo.allapot, "Z1"))
                {
                    this.heurisztika -= 10;
                }

            }
            if (szulo != null && CélMezőnVanEaBábú(z10[0], z10[1], szulo.allapot, "Z2"))
            {
                kozelebb(z11[0], z11[1], szulo.allapot, "Z1");
                kozelebb(z12[0], z12[1], szulo.allapot, "Z3");
                kozelebb(p10[0], p10[1], szulo.allapot, "P1");
                kozelebb(p11[0], p11[1], szulo.allapot, "P2");
                kozelebb(p12[0], p12[1], szulo.allapot, "P3");

                if (!CélMezőnVanEaBábú(z10[0], z10[1], szulo.allapot, "Z2"))
                {
                    this.heurisztika -= 10;
                }

            }
            this.osszkolteg = this.kolteg + (-1) * this.heurisztika;



        }
        Point pontErtekVissza(Allapot allapot, string nev)
        {
            Point pont = new Point();
            for (int i = 0; i < allapot.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < allapot.matrix.GetLength(1); j++)
                {
                    if (nev == allapot.matrix[i,j])
                    {
                        pont.X = i;
                        pont.Y = j;
                    }
                }
            }
            return pont;
        }
        void kozelebb(int celX, int celY, Allapot allapot, string s)
        {
            int babuX = pontErtekVissza(allapot, s).X;
            int babuY = pontErtekVissza(allapot, s).Y;
            if (babuX == 0 && babuY == 0 || babuX == 0 && babuY == 2)
            {
                this.heurisztika += 0;
            }
           else if (babuX == 0 && babuY == 1)
            {
                this.heurisztika += 1;
            }
           else if (babuX == 1 && babuY == 1 )
            {
                this.heurisztika += 2;
            }
            else if (babuX == 2 && babuY == 1)
            {
                this.heurisztika += 3;
            }
            else if (babuX == 2 && babuY == 0)
            {
                this.heurisztika += 4;
            }
            else if (babuX == 3 && babuY == 1)
            {
                this.heurisztika += 5;
            }
            else if (babuX == 4 && babuY == 1)
            {
                this.heurisztika += 6;
            }
            else if (babuX == 4 && babuY == 2 || babuX == 4 && babuY == 0)
            {
                this.heurisztika += 7;
            }
        
        }
        bool Check(int x, int y , int i, int j)
        {
            return x == i && y == j;
        }
        bool CélMezőnVanEaBábú(int x, int y,Allapot allapot, string s)
        {
            for (int i = x; i < x; i++)
            {
                for (int j = y; j < y; j++)
                {
                    if (s == allapot.matrix[i,j] && Check(x,y,i,j))
                    {
                        return true;
                    }
                }
            }
           
            return false;
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