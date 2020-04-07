using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace pentominov1
{
    class cFigura
    {
        public int[,] mFigure;
        public SolidBrush bojaFigure;
        public SolidBrush bojaSFigure = new SolidBrush(Color.Black);
        //public int tipFigure;
        private int tipFigure;

        public cFigura()
        {
            mFigure = new int[5, 5];
        }

        public int TipFigure
        {
            get { return tipFigure; }
            set
            {
                tipFigure = value;
                napraviFiguru();
            }
        }

        private void napraviFiguru()
        {
            switch (tipFigure)
            {
                case 0: // F
                    mFigure[0, 0] = 0;
                    mFigure[1, 0] = 1;
                    mFigure[2, 0] = 0;
                    mFigure[3, 0] = 0;
                    mFigure[4, 0] = 0;

                    mFigure[0, 1] = 1;
                    mFigure[1, 1] = 1;
                    mFigure[2, 1] = 1;
                    mFigure[3, 1] = 0;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 1;
                    mFigure[1, 2] = 0;
                    mFigure[2, 2] = 0;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.LightBlue);
                    break;
                case 1: // I
                    mFigure[0, 0] = 1;
                    mFigure[1, 0] = 1;
                    mFigure[2, 0] = 1;
                    mFigure[3, 0] = 1;
                    mFigure[4, 0] = 1;

                    mFigure[0, 1] = 0;
                    mFigure[1, 1] = 0;
                    mFigure[2, 1] = 0;
                    mFigure[3, 1] = 0;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 0;
                    mFigure[1, 2] = 0;
                    mFigure[2, 2] = 0;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.LightGreen);
                    break;
                case 2: // L
                    mFigure[0, 0] = 1;
                    mFigure[1, 0] = 1;
                    mFigure[2, 0] = 1;
                    mFigure[3, 0] = 1;
                    mFigure[4, 0] = 0;

                    mFigure[0, 1] = 0;
                    mFigure[1, 1] = 0;
                    mFigure[2, 1] = 0;
                    mFigure[3, 1] = 1;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 0;
                    mFigure[1, 2] = 0;
                    mFigure[2, 2] = 0;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.DeepPink);
                    break;
                case 3: // P
                    mFigure[0, 0] = 1;
                    mFigure[1, 0] = 1;
                    mFigure[2, 0] = 1;
                    mFigure[3, 0] = 0;
                    mFigure[4, 0] = 0;

                    mFigure[0, 1] = 1;
                    mFigure[1, 1] = 1;
                    mFigure[2, 1] = 0;
                    mFigure[3, 1] = 0;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 0;
                    mFigure[1, 2] = 0;
                    mFigure[2, 2] = 0;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.Yellow);
                    break;
                case 4: // N
                    mFigure[0, 0] = 0;
                    mFigure[1, 0] = 1;
                    mFigure[2, 0] = 1;
                    mFigure[3, 0] = 1;
                    mFigure[4, 0] = 0;

                    mFigure[0, 1] = 1;
                    mFigure[1, 1] = 1;
                    mFigure[2, 1] = 0;
                    mFigure[3, 1] = 0;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 0;
                    mFigure[1, 2] = 0;
                    mFigure[2, 2] = 0;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.Blue);
                    break;
                case 5: // T
                    mFigure[0, 0] = 1;
                    mFigure[1, 0] = 0;
                    mFigure[2, 0] = 0;
                    mFigure[3, 0] = 0;
                    mFigure[4, 0] = 0;

                    mFigure[0, 1] = 1;
                    mFigure[1, 1] = 1;
                    mFigure[2, 1] = 1;
                    mFigure[3, 1] = 0;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 1;
                    mFigure[1, 2] = 0;
                    mFigure[2, 2] = 0;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.BlueViolet);
                    break;
                case 6: // U
                    mFigure[0, 0] = 1;
                    mFigure[1, 0] = 1;
                    mFigure[2, 0] = 0;
                    mFigure[3, 0] = 0;
                    mFigure[4, 0] = 0;

                    mFigure[0, 1] = 0;
                    mFigure[1, 1] = 1;
                    mFigure[2, 1] = 0;
                    mFigure[3, 1] = 0;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 1;
                    mFigure[1, 2] = 1;
                    mFigure[2, 2] = 0;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.YellowGreen);
                    break;
                case 7: // V
                    mFigure[0, 0] = 1;
                    mFigure[1, 0] = 1;
                    mFigure[2, 0] = 1;
                    mFigure[3, 0] = 0;
                    mFigure[4, 0] = 0;

                    mFigure[0, 1] = 0;
                    mFigure[1, 1] = 0;
                    mFigure[2, 1] = 1;
                    mFigure[3, 1] = 0;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 0;
                    mFigure[1, 2] = 0;
                    mFigure[2, 2] = 1;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.Violet);
                    break;
                case 8: // W
                    mFigure[0, 0] = 1;
                    mFigure[1, 0] = 1;
                    mFigure[2, 0] = 0;
                    mFigure[3, 0] = 0;
                    mFigure[4, 0] = 0;

                    mFigure[0, 1] = 0;
                    mFigure[1, 1] = 1;
                    mFigure[2, 1] = 1;
                    mFigure[3, 1] = 0;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 0;
                    mFigure[1, 2] = 0;
                    mFigure[2, 2] = 1;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.Orange);
                    break;
                case 9: // X
                    mFigure[0, 0] = 0;
                    mFigure[1, 0] = 1;
                    mFigure[2, 0] = 0;
                    mFigure[3, 0] = 0;
                    mFigure[4, 0] = 0;

                    mFigure[0, 1] = 1;
                    mFigure[1, 1] = 1;
                    mFigure[2, 1] = 1;
                    mFigure[3, 1] = 0;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 0;
                    mFigure[1, 2] = 1;
                    mFigure[2, 2] = 0;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.LightPink);
                    break;
                case 10: // Y
                    mFigure[0, 0] = 0;
                    mFigure[1, 0] = 1;
                    mFigure[2, 0] = 0;
                    mFigure[3, 0] = 0;
                    mFigure[4, 0] = 0;

                    mFigure[0, 1] = 1;
                    mFigure[1, 1] = 1;
                    mFigure[2, 1] = 1;
                    mFigure[3, 1] = 1;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 0;
                    mFigure[1, 2] = 0;
                    mFigure[2, 2] = 0;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.PaleTurquoise);
                    break;
                case 11: // Z
                    mFigure[0, 0] = 1;
                    mFigure[1, 0] = 0;
                    mFigure[2, 0] = 0;
                    mFigure[3, 0] = 0;
                    mFigure[4, 0] = 0;

                    mFigure[0, 1] = 1;
                    mFigure[1, 1] = 1;
                    mFigure[2, 1] = 1;
                    mFigure[3, 1] = 0;
                    mFigure[4, 1] = 0;

                    mFigure[0, 2] = 0;
                    mFigure[1, 2] = 0;
                    mFigure[2, 2] = 1;
                    mFigure[3, 2] = 0;
                    mFigure[4, 2] = 0;

                    mFigure[0, 3] = 0;
                    mFigure[1, 3] = 0;
                    mFigure[2, 3] = 0;
                    mFigure[3, 3] = 0;
                    mFigure[4, 3] = 0;

                    mFigure[0, 4] = 0;
                    mFigure[1, 4] = 0;
                    mFigure[2, 4] = 0;
                    mFigure[3, 4] = 0;
                    mFigure[4, 4] = 0;
                    bojaFigure = new SolidBrush(Color.Magenta);
                    break;
            }
        }
        public int pocetakX;
        public int pocetakY;

        public void PostaviPoziciju(int iX, int iY)
        {
            pocetakX = iX;
            pocetakY = iY;
        }
        public int dKvadratica = 15;
        public int dOkvira = 16;
        private Pen crna = new Pen(Color.Black, 1);
        public void Nacrtaj(Graphics g)
        {
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(mFigure[i,j] == 1)
                    {
                        //g.DrawRectangle(crna, pocetakX + dOkvira * j,
                        //   pocetakY + dOkvira * i, dOkvira, dOkvira);
                        g.DrawRectangle(crna, pocetakX + dKvadratica * j,
                          pocetakY + dKvadratica * i, dKvadratica, dKvadratica);
                        g.FillRectangle(bojaFigure, pocetakX + dKvadratica * j,
                            pocetakY + dKvadratica * i, dKvadratica, dKvadratica);
                    }
                }
            }
            //crna.Dispose();
        }
        public void Selektuj(Graphics g)
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mFigure[i, j] == 1)
                    {
                        //g.DrawRectangle(crna, pocetakX + dOkvira * j,
                        //   pocetakY + dOkvira * i, dOkvira, dOkvira);
                        g.DrawRectangle(crna, pocetakX + dKvadratica * j,
                          pocetakY + dKvadratica * i, dKvadratica, dKvadratica);
                        g.FillRectangle(bojaSFigure, pocetakX + dKvadratica * j,
                            pocetakY + dKvadratica * i, dKvadratica, dKvadratica);
                    }
                }
            }
            //crna.Dispose();
        }


        public bool MisUFiguri(int x, int y)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mFigure[i, j] == 1)
                    {
                        if ((pocetakX + j*dKvadratica <= x && 
                            (pocetakX + (j+1)*dKvadratica) >= x) &&
                            (pocetakY + i*dKvadratica <= y 
                            && (pocetakY + (i+1)*dKvadratica) >= y))
                        {
                            //crna.Color = Color.Red;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        
        public void rotiraj(/*cFigura bla,int[,] mFigure*/)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = i; j < 5 - i - 1; j++)
                {
                    int pom = mFigure[i, j];
                    mFigure[i, j] = mFigure[j, 4 - i];
                    mFigure[j, 4 - i] = mFigure[4 - i, 4 - j];
                    mFigure[4 - i, 4 - j] = mFigure[4 - j, i];
                    mFigure[4 - j, i] = pom;
                }
            }
        }
        
        
            
    }
}
