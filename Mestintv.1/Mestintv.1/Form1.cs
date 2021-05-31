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
        private const int size = 40;
        private const int space = 30;
        List<Kereso> keresok = new List<Kereso>();
        List<Allapot> megoldasok = new List<Allapot>();
        int aktualisAllapotIndex = 366;
        Graphics formGraphics;
        public Form1()
        {
            keresok.Add(new Backtrack());
            keresok.Add(new Melysegi());
            keresok.Add(new BestFirst());
            InitializeComponent();
            //foreach (Kereso k in keresok)
            //{
            //    Console.WriteLine(" \n----Utvonalak----\n" + k.GetType().Name + "\n------------");
            //    foreach (Allapot a in k.Utvonal)
            //    {
                  
            //        Console.WriteLine(a.ToString());
            //    }
            //}
            foreach (Kereso kereso in keresok)
            {
                comboBox1.Items.Add(kereso.GetType().Name);
            }
            
           
        }
      
        public void Draw( Graphics g ,Allapot a)
        {
            int pB_W = pictureBox1.Width;
            int pB_H = pictureBox1.Height;
            Bitmap image = new Bitmap(pB_W, pB_H);
            pictureBox1.Image = image;
            g = Graphics.FromImage(image);

            Brush brush;
            for (int j = 0; j < a.matrix.GetLength(0); j++)
            {
                for (int i = 0; i < a.matrix.GetLength(1); i++)
                {
                    if (a.matrix[j, i] == "F")
                        brush = Brushes.Black;
                    else if (a.matrix[j, i] == "U")
                    {
                        brush = Brushes.White;
                    }
                    else if (a.matrix[j, i] == "Z1" || a.matrix[j, i] == "Z2" || a.matrix[j, i] == "Z3")
                    {
                        brush = Brushes.Green;
                    }
                    else if (a.matrix[j, i] == "P1" || a.matrix[j, i] == "P2" || a.matrix[j, i] == "P3")
                    {
                        brush = Brushes.Red;
                    }
                    else brush = Brushes.AliceBlue;
                    g.FillRectangle(brush, i * (size + space), j * (size + space), size, size);
                }
            }
           
        }
        static Graphics g;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
                
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (keresok[comboBox1.SelectedIndex].Utvonal.Count == aktualisAllapotIndex)
            {

            }
            else
            {
                Draw(g, keresok[comboBox1.SelectedIndex].Utvonal[aktualisAllapotIndex]);
                aktualisAllapotIndex++;
                label2.Text = aktualisAllapotIndex.ToString();
                label1.Text = keresok[comboBox1.SelectedIndex].Utvonal.Count.ToString();
            }
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (aktualisAllapotIndex == 0)
            {
                Draw(g, keresok[comboBox1.SelectedIndex].Utvonal[aktualisAllapotIndex]);
                
                label2.Text = aktualisAllapotIndex.ToString();
           
            }
            else if (aktualisAllapotIndex > 0)
            {
                Draw(g, keresok[comboBox1.SelectedIndex].Utvonal[aktualisAllapotIndex]);
                
                label2.Text = aktualisAllapotIndex.ToString();
                aktualisAllapotIndex--;
            }
            else if (aktualisAllapotIndex == keresok[comboBox1.SelectedIndex].Utvonal.Count)       
            {
                aktualisAllapotIndex--;
                Draw(g, keresok[comboBox1.SelectedIndex].Utvonal[aktualisAllapotIndex]);

                label2.Text = aktualisAllapotIndex.ToString();
            }
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktualisAllapotIndex =0;
        }
    }
}
