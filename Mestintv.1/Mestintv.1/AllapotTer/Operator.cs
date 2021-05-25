using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mestintv._1.AllapotTer
{
    class Operator
    {

        private string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
      

        public Operator(string nev, int x,  int y)
        {
            Nev = nev;
            X = x;    
            Y = y;
        }
        public Allapot Atrak(Allapot allapot)
        {

            Allapot ujAllapot = new Allapot();
        
            int xSeged = 0;
            int ySeged = 0;
            string s = "";
            for (int i = 0; i < allapot.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < allapot.matrix.GetLength(1); j++)
                {
                    if (nev == allapot.matrix[i, j])
                    {
                        xSeged = i;
                        ySeged = j;
                        ujAllapot.matrix[i, j] = allapot.matrix[x, y];
                         
                    }
                }
            }
            for (int i = 0; i < allapot.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < allapot.matrix.GetLength(1); j++)
                {
                   
                    if (xSeged == i && ySeged == j)
                    {

                    }
                    else if (x == i && y == j)
                    {
                        
                        ujAllapot.matrix[i, j] = nev;
                    }                            
                    else
                    {
                        ujAllapot.matrix[i, j] = allapot.matrix[i, j];
                    }

                }
            }


            //Thread.Sleep(100);
            Console.WriteLine(ujAllapot.ToString());



            return ujAllapot;
        }
       

        public bool Elofeltetel(Allapot allapot)
        {
            if (allapot.matrix[x,y] == "F")
            {
                return false;
            }


            if (allapot.matrix[x, y] == "Z2" || allapot.matrix[x, y] == "Z1" || allapot.matrix[x, y] == "Z3" ||
                allapot.matrix[x, y] == "P1" || allapot.matrix[x, y] == "P2" || allapot.matrix[x, y] == "P3")
            {
                return false;
            }
            
            int segedx = 0;
            int segedy = 0;

            for (int i = 0; i < allapot.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < allapot.matrix.GetLength(1); j++)
                {

                    if (nev == allapot.matrix[i, j])
                    {
                        segedx = i;
                        segedy = j;
                    }
                }
            }
            if (segedx == 4 && segedy == 0 && nev == "Z1" || segedx == 4 && segedy == 1 && nev == "Z2" || segedx == 4 && segedy == 2 && nev == "Z3" ||
              segedx == 4 && segedy == 0 && nev == "Z1" || segedx == 4 && segedy == 1 && nev == "Z3" || segedx == 4 && segedy == 2 && nev == "Z2" ||
              segedx == 4 && segedy == 0 && nev == "Z2" || segedx == 4 && segedy == 1 && nev == "Z1" || segedx == 4 && segedy == 2 && nev == "Z3" ||
              segedx == 4 && segedy == 0 && nev == "Z2" || segedx == 4 && segedy == 1 && nev == "Z3" || segedx == 4 && segedy == 2 && nev == "Z1" ||
              segedx == 4 && segedy == 0 && nev == "Z3" || segedx == 4 && segedy == 1 && nev == "Z2" || segedx == 4 && segedy == 2 && nev == "Z1" ||
              segedx == 4 && segedy == 0 && nev == "Z3" || segedx == 4 && segedy == 1 && nev == "Z1" || segedx == 4 && segedy == 2 && nev == "Z2")
            {
                return false;
            }
            if (segedx == 0 && segedy == 0 && nev == "P1" || segedx == 0 && segedy == 1 && nev == "P2" || segedx == 0 && segedy == 2 && nev == "P3" ||
               segedx == 0 && segedy == 0 && nev == "P1" || segedx == 0 && segedy == 1 && nev == "P3" || segedx == 0 && segedy == 2 && nev == "P2" ||
               segedx == 0 && segedy == 0 && nev == "P2" || segedx == 0 && segedy == 1 && nev == "P1" || segedx == 0 && segedy == 2 && nev == "P3" ||
               segedx == 0 && segedy == 0 && nev == "P2" || segedx == 0 && segedy == 1 && nev == "P3" || segedx == 0 && segedy == 2 && nev == "P1" ||
               segedx == 0 && segedy == 0 && nev == "P3" || segedx == 0 && segedy == 1 && nev == "P2" || segedx == 0 && segedy == 2 && nev == "P1" ||
               segedx == 0 && segedy == 0 && nev == "P3" || segedx == 0 && segedy == 1 && nev == "P1" || segedx == 0 && segedy == 2 && nev == "P2")
            {
                return false;
            }

            if (segedx+1 < x)
            {
                return false;
            }
            if (segedx-1 > x)
            {
                return false;
            }
            if (segedy+1 <y)
            {
                return false;
            }
            if (segedy-1> y )
            {
                return false;
            }

            if (segedx - 1 == x && segedy - 1 == y ||
                segedx - 1 == x && segedy + 1 == y ||
                segedx + 1 == x && segedy - 1 == y ||
                segedx + 1 == x && segedy + 1 == y)
            {
                return false;
            }
         return true;
        }
    }
}
