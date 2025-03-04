using H_P_II_Clase1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace H_P_II_Clase3
{
    public partial class Form1 : Form
    {

        int x = 251;
        bool dir = true;
        private List<Bala> balas = new List<Bala>();

        

        public Form1()
        {
            InitializeComponent();
            PicEjemplo.Location = new Point(257, 12);
        }

 
        

        private void btnDisparar_Click_1(object sender, EventArgs e)
        {

             int posX = picBala.Location.X + (picBala.Width / 2) - 10;
            int posY = picBala.Location.Y;

            
            Point posicionInicial = new Point(posX, posY);
            Bala nuevaBala = new Bala(this, posicionInicial, new Size(20, 40), picBala.Image); 
            balas.Add(nuevaBala);
        }

        private void btnDesplazar_Click_1(object sender, EventArgs e)
        {
            tmrDesplazar.Enabled = true;
        }

        private void tmrDesplazar_Tick_1(object sender, EventArgs e)
        {
            PicEjemplo.Location = new Point(x, 35);
            if (dir)
            {
                x += 10;
            }
            else
            {
                x -= 10;
            }
            if (x >= this.Size.Width - PicEjemplo.Width)
            {
                dir = false;
            }
            if (x <= 10)
            {
                dir = true;
            }
        }

        private void tmrBala_Tick(object sender, EventArgs e)
        {
            for (int i = balas.Count - 1; i >= 0; i--)
            {
                if (!balas[i].Mover()) 
                {
                    balas.RemoveAt(i);
                }
                else if (balas[i].ColisionaCon(PicEjemplo)) 
                {
                   
                    balas[i].Destruir(); 
                    balas.RemoveAt(i); 
                   
                }
            }
        }
    }
}