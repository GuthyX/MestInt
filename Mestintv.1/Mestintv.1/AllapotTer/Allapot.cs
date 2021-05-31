using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestintv._1.AllapotTer
{
   public class Allapot
    {

        public static int jatekosok = 6;
        public string[,] matrix =new string[5,3] { {"Z1","Z2","Z3" },
                                                   { "F","U","F" },
                                                   { "U","U","F" },
                                                   { "F","U","F" },
                                                   { "P1","P2","P3" }};

        public Allapot()
        {

        }
        public bool celfeltetel()
        {
            //if (matrix[2,0] == "P2" && matrix[0,1] == "Z2" && (matrix[1,1] == "Z1" || matrix[1,1] == "Z3"))
            //{
            //    return true;
            //}
            if (matrix[0, 0] == "P1" && matrix[0, 1] == "P2" && matrix[0, 2] == "P3" &&
                   (matrix[4, 0] == "Z1" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z1" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z1" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z1") ||

                matrix[0, 0] == "P1" && matrix[0, 1] == "P3" && matrix[0, 2] == "P2" &&
                  (matrix[4, 0] == "Z1" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z1" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z1" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z1") ||

                matrix[0, 0] == "P2" && matrix[0, 1] == "P1" && matrix[0, 2] == "P3" &&
                  (matrix[4, 0] == "Z1" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z1" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z1" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z1") ||

                matrix[0, 0] == "P2" && matrix[0, 1] == "P3" && matrix[0, 2] == "P1" &&
                  (matrix[4, 0] == "Z1" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z1" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z1" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z1") ||

                matrix[0, 0] == "P3" && matrix[0, 1] == "P2" && matrix[0, 2] == "P1" &&
                  (matrix[4, 0] == "Z1" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z1" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z1" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z1") ||

                matrix[0, 0] == "P3" && matrix[0, 1] == "P1" && matrix[0, 2] == "P2" &&
                  (matrix[4, 0] == "Z1" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z1" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z3" && matrix[4, 2] == "Z1" ||
                matrix[4, 0] == "Z2" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z3" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z1" && matrix[4, 2] == "Z2" ||
                matrix[4, 0] == "Z3" && matrix[4, 1] == "Z2" && matrix[4, 2] == "Z1")
               )
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("==============");
            for (int i = 0; i < matrix.GetLength(0); i ++)
            {
                builder.Append("\n");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    builder.Append(matrix[i,j]+" ");
                }
                builder.Append("\n");
            }
            builder.Append("==============");


            return builder.ToString();
        }
		 public override bool Equals(object obj)
        {
            Allapot osszehasonlitandoAllapot = (Allapot)obj;
            for (int i = 0; i <matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] != osszehasonlitandoAllapot.matrix[i, j])
                    {
                        return false;
                    }
                }
              
            }

            return true;
        }
    }
}
