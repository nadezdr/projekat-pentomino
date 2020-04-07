using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pentominov1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int maliKvadrat = 15; //jedinicni kv figurice
        cFigura[] nizFigura = new cFigura[12];
        public Point[] nizPocPozicija = new Point[12];
        //public Graphics g;
        cTabla tabla = new cTabla();
        /*public SolidBrush[] boje = {new SolidBrush(Color.LightBlue),new SolidBrush(Color.LightGreen),new SolidBrush(Color.DeepPink),new SolidBrush(Color.Yellow),new SolidBrush(Color.Blue),
            new SolidBrush(Color.BlueViolet),new SolidBrush(Color.YellowGreen),
            new SolidBrush(Color.Violet),new SolidBrush(Color.Orange),new SolidBrush(Color.PaleTurquoise),
            new SolidBrush(Color.LightPink),new SolidBrush(Color.Magenta)};*/

        public bool podignutmis = false;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 12; i++)
            {
                nizFigura[i] = new cFigura();
                nizFigura[i].TipFigure = i;
                //nizFigura[i].PostaviPoziciju(20 + ((i % 6) * 110), i >= 6 ? 180 : 70);
                nizPocPozicija[i].X = 15 + (i % 3) * 100;
                if (i < 3) nizPocPozicija[i].Y = 30;
                else if (i < 6) nizPocPozicija[i].Y = 110;
                else if (i < 9) nizPocPozicija[i].Y = 190;
                else nizPocPozicija[i].Y = 270;
                nizPocPozicija[0].X = 300;
                nizPocPozicija[0].Y = 15;
                nizFigura[i].PostaviPoziciju(nizPocPozicija[i].X, nizPocPozicija[i].Y);

            }

        }
        public int selektovano = -1;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            tabla.NacrtajTablu(e.Graphics);
            for (int i = 0; i < 12; i++)
            {
                if (selektovano == i)
                    nizFigura[i].Selektuj(e.Graphics);
                else
                    nizFigura[i].Nacrtaj(e.Graphics);
            }

            /*if (podignutmis && selektovano != -1 && tabla.FiguraUTabli(mis.X - rX, mis.Y - rY) && tabla.jelmozedastane(nizFigura[selektovano]))
            {
                tabla.obojTablu(e.Graphics);
                podignutmis = false;
                selektovano = -1;
            }*/
            if(selektovano!=-1)
                tabla.probajDaDas(nizFigura[selektovano], mis.X, mis.Y, e.Graphics, selektovano);
            this.Text = selektovano.ToString();
        }

        private void bOkreni_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point mis = PointToClient(MousePosition);
            for (int i = 0; i < 12; i++)
            {
                if (nizFigura[i].MisUFiguri(mis.X, mis.Y))
                {
                    selektovano = i;

                    //Invalidate();
                    break;
                }
                else
                    selektovano = -1;
            }
        }
        
        public Point mis;
        public int rX;
        public int rY;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mis = PointToClient(MousePosition);
            
            for (int i = 0; i < 12; i++)
            {
                if (nizFigura[i].MisUFiguri(mis.X, mis.Y))
                {
                    selektovano = i;
                    rX = mis.X - nizFigura[i].pocetakX;
                    rY = mis.Y - nizFigura[i].pocetakY;
                    Invalidate();
                    break;
                }
                else
                {
                    selektovano = -1;
                    Invalidate();
                }
                    
            }
            /*if(!tabla.MisUTabli(mis.X,mis.Y))
            {
                selektovano = -1;
            }*/
            if(e.Button==MouseButtons.Right)
            {
                if (selektovano != -1)
                {
                    nizFigura[selektovano].rotiraj();
                    Invalidate();
                }
            }
            timerPomeranje.Enabled = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            

            mis = PointToClient(MousePosition);

            
            if (selektovano != -1)
            {
                nizFigura[selektovano].pocetakX = mis.X - rX;
                nizFigura[selektovano].pocetakY = mis.Y - rY;
                //Invalidate();
                //Refresh();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
            podignutmis = true;
            

            selektovano = -1;
            Invalidate();
            timerPomeranje.Enabled = false;
            
        }

        private void timerPomeranje_Tick(object sender, EventArgs e)
        {
            if(timerPomeranje.Enabled && selektovano != -1)
            {
                Invalidate();
            }

        }

        private void bOdoznaci_Click(object sender, EventArgs e)
        {
            selektovano = -1;
            Invalidate();
        }
    }
}
