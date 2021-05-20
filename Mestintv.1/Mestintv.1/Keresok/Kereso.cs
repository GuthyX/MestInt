using Mestintv._1.AllapotTer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestintv._1.Keresok
{
    abstract class Kereso
    {
        private List<Allapot> utvonal = new List<Allapot>(); //adatbázis

        internal List<Allapot> Utvonal { get => utvonal; set => utvonal = value; }
        internal List<Operator> Operatorok { get => operatorok; set => operatorok = value; }

        private List<Operator> operatorok = new List<Operator>();

        public Kereso()
        {
            operatorokFeltoltese();
           
        }

        private void operatorokFeltoltese()
        {
            //Z1
            operatorok.Add(new Operator("Z1", 0, 1));
            operatorok.Add(new Operator("Z1", 1, 1));
            operatorok.Add(new Operator("Z1", 2, 1));
            operatorok.Add(new Operator("Z1", 2, 0));
            operatorok.Add(new Operator("Z1", 3, 1));
            operatorok.Add(new Operator("Z1", 4, 1));
            operatorok.Add(new Operator("Z1", 4, 0));

            //Z2
            operatorok.Add(new Operator("Z2", 1, 1));
            operatorok.Add(new Operator("Z2", 2, 1));
            operatorok.Add(new Operator("Z2", 2, 0));
            operatorok.Add(new Operator("Z2", 3, 1));
            operatorok.Add(new Operator("Z2", 4, 1));
            operatorok.Add(new Operator("Z2", 4, 2));

            //Z3
            operatorok.Add(new Operator("Z3", 0, 1));
            operatorok.Add(new Operator("Z3", 1, 1));
            operatorok.Add(new Operator("Z3", 2, 1));
            operatorok.Add(new Operator("Z3", 2, 0));
            operatorok.Add(new Operator("Z3", 3, 1));
            operatorok.Add(new Operator("Z3", 4, 1));

            //P2
            operatorok.Add(new Operator("P2", 3, 1));
            operatorok.Add(new Operator("P2", 2, 1));
            operatorok.Add(new Operator("P2", 2, 0));
            operatorok.Add(new Operator("P2", 1, 1));
            operatorok.Add(new Operator("P2", 0, 1));
            operatorok.Add(new Operator("P2", 0, 0));

            //P1
            operatorok.Add(new Operator("P1", 4, 1));
            operatorok.Add(new Operator("P1", 3, 1));
            operatorok.Add(new Operator("P1", 2, 1));
            operatorok.Add(new Operator("P1", 2, 0));
            operatorok.Add(new Operator("P1", 1, 1));
            operatorok.Add(new Operator("P1", 0, 1));
            operatorok.Add(new Operator("P1", 0, 2));
            //P3
            operatorok.Add(new Operator("P1", 4, 1));
            operatorok.Add(new Operator("P1", 3, 1));
            operatorok.Add(new Operator("P1", 2, 1));
            operatorok.Add(new Operator("P1", 2, 0));
            operatorok.Add(new Operator("P1", 1, 1));
            operatorok.Add(new Operator("P1", 0, 1));
         

        }

        public abstract void Kereses();

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < Utvonal.Count; i++)
            {
                builder.Append(Utvonal[i]);
                builder.Append("\n");
            }
            builder.Append(Utvonal.Count);
            return builder.ToString();
        }
    }
}
