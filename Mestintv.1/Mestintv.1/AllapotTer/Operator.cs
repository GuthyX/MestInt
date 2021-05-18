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


            Thread.Sleep(500);
            Console.WriteLine(ujAllapot.ToString());
            //lépés
         

            return ujAllapot;
        }

        public bool Elofeltetel(Allapot allapot)
        {
            if (allapot.matrix[x, y] == "F")
            {
                return false;
            }
            if ((allapot.matrix[x, y] == "P2" || allapot.matrix[x, y] == "P3" || allapot.matrix[x, y] == "P1") ||
                (allapot.matrix[x, y] == "Z2" || allapot.matrix[x, y] == "Z3" || allapot.matrix[x, y] == "Z1"))
            {
                return false;
            }
              
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                   
                       
                        if (allapot.matrix[i,j] == "Z1")
                        {
            
                        if (i + 1 < x || j - 1 >y ||
                                    j + 1 < y || j - 1 > y || i+1 == x && j-1 == y)
                        {
                            break;
                        }
                        }
                        if (allapot.matrix[i, j] == "Z2")
                        {
                        if (i + 1 < x || j - 1 > y ||
                                      j + 1 < y || j - 1 > y  )
                        {
                           break;
                        }
                    }
                        if (allapot.matrix[i, j] == "Z3")
                        {
                        if (i + 1 < x || j - 1 > y ||
                                 j + 1 < y || j - 1 > y || i == x && j-1 == y)
                        {
                            break;
                        }
                    }
                        if (allapot.matrix[i, j] == "P1")
                    {
                        if (i + 1 < x || j - 1 > y ||
                                  j + 1 < y || j - 1 > y)
                        {
                            break;
                        }
                    }
                        if (allapot.matrix[i, j] == "P2")
                    {
                        if (i + 1 < x || j - 1 > y ||
                                  j + 1 < y || j - 1 > y)
                        {
                           break;
                        }

                    }
                        if (allapot.matrix[i, j] == "P3")
                        {
                        if (i + 1 < x || j - 1 > y ||
                                 j + 1 < y || j - 1 > y)
                        {
                            break;
                        }
                    }
                   
                }
            }
            return true;
        }
        }
}
