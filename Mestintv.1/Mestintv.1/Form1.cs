using Mestintv._1.AllapotTer;
using Mestintv._1.Keresok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mestintv._1
{
    public partial class Form1 : Form
    {
        List<Kereso> keresok = new List<Kereso>();
        List<Allapot> megoldasok = new List<Allapot>();
        int aktualisAllapotIndex = 0;
        public Form1()
        {
            keresok.Add(new Backtrack());
            InitializeComponent();
            foreach (Kereso k in keresok)
            {
                Console.WriteLine(" \n----Utvonalak----\n" + k.GetType().Name + "\n------------");
                foreach (Allapot a in k.Utvonal)
                {
                  
                    Console.WriteLine(a.ToString());
                }
            }
            label1.Text = keresok[0].Utvonal.Count.ToString();
        }
    }
}
