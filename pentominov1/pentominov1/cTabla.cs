using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace pentominov1
{
    class cTabla
    {
        private int[,] mTable;
        public Point tackaumartici = new Point();
        private SolidBrush bojaTable = new SolidBrush(Color.White);
        private int dKvadratica = 15;
        //public Color[] boje = { Color.LightBlue, Color.LightGreen, Color.DeepPink, Color.Yellow, Color.Blue, Color.BlueViolet, Color.YellowGreen,
        //          Color.Violet, Color.Orange, Color.PaleTurquoise, Color.LightPink, Color.Magenta};

        public SolidBrush[] boje = {new SolidBrush(Color.LightBlue),new SolidBrush(Color.LightGreen),new SolidBrush(Color.DeepPink),new SolidBrush(Color.Yellow),new SolidBrush(Color.Blue),
            new SolidBrush(Color.BlueViolet),new SolidBrush(Color.YellowGreen),
            new SolidBrush(Color.Violet),new SolidBrush(Color.Orange),new SolidBrush(Color.PaleTurquoise),
            new SolidBrush(Color.LightPink),new SolidBrush(Color.Magenta)};

        public cTabla()
        {
            mTable = new int[8, 8];
            napraviTablu();
        }
        private void napraviTablu()
        {
            for (int i = 2; i <= 5; i++)
            {
                mTable[i, i] = -1;
            }
        }
        private int pocX = 300;
        private int pocY = 15;
        public void NacrtajTablu(Graphics g)
        {
            Pen crna = new Pen(Color.Black, 2);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (mTable[i, j] == 0)
                    {
                        g.DrawRectangle(crna, pocX + dKvadratica * j,
                           pocY + dKvadratica * i, dKvadratica, dKvadratica);
                        g.FillRectangle(bojaTable, pocX + dKvadratica * j,
                            pocY + dKvadratica * i, dKvadratica, dKvadratica);
                    }
                }
            }
            crna.Dispose();
        }

        public bool FiguraUTabli(int x, int y)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (mTable[i, j] == 0)
                    {
                        if ((pocX + j * dKvadratica <= x &&
                            (pocX + (j + 1) * dKvadratica) >= x) &&
                            (pocY + i * dKvadratica <= y
                            && (pocY + (i + 1) * dKvadratica) >= y))
                        {
                            //crna.Color = Color.Red;
                            return true;
                        }
                    }
                }
            }
            if ((pocX <= x && (pocX + 8 * dKvadratica) >= x) && (pocY <= y) && (pocY + 8 * dKvadratica) >= y)
            {
                return true;
            }
            return false;
        }
        public void poljeumatrici(int x, int y)
        {
            
            tackaumartici.Y = (y - pocY) / dKvadratica;
            tackaumartici.X = (x - pocX) / dKvadratica;
        }
        public bool jelmozedastane(cFigura figura)
        {
            int maxsirina = -1, maxduzina = -1;
            for (int i = 0; i < 5; i++)
            {
                int duzina = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (figura.mFigure[i, j] == 1)
                        duzina++;
                    else
                    {
                        maxduzina = Math.Max(maxduzina, duzina);
                        duzina = 0;
                    }
                }
            }
            for (int j = 0; j < 5; j++)
            {
                int sirina = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (figura.mFigure[j, i] == 1)
                        sirina++;
                    else
                    {
                        maxsirina = Math.Max(maxsirina, sirina);
                        sirina = 0;
                    }
                }
            }

            if (8 - tackaumartici.X < maxsirina || 8 - tackaumartici.Y < maxduzina)
                return false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(figura.mFigure[i,j] == 1 && mTable[tackaumartici.Y+i,tackaumartici.X+j]!=0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void upisiFiguru(cFigura figura,int selektovano)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mTable[tackaumartici.Y + i, tackaumartici.X + j] = selektovano + 1;
                }
            }
        }
        public void obojTablu(Graphics g)
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(mTable[i,j]>0)
                    {
                        int x=pocX + j * dKvadratica;
                        int y=pocY + i * dKvadratica;
                        g.FillRectangle(boje[mTable[i, j] - 1], x, y, dKvadratica, dKvadratica);
                    }
                }
            }
        }







        public int mI, mJ;

        public void poljeumatriciPar(int x, int y)
        {

            mI = (y - pocY) / dKvadratica;
            mJ = (x - pocX) / dKvadratica;
        }

        public bool MisUTabli(int x, int y)
        {
            
            if ((pocX <= x && (pocX + 8 * dKvadratica) >= x) && (pocY <= y) && (pocY + 8 * dKvadratica) >= y)
            {
                poljeumatriciPar(x, y);
                return true;
            }
            return false;
        }

        public bool slobodno(cFigura figura, int x, int y)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(figura.mFigure[i, j] == 1 && (mI+i>7 || mJ+j>7 || mTable[mI + i, mJ + j] != 0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void Ubaci(cFigura figura,Graphics g, int selektovano)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(figura.mFigure[i,j]==1)
                    {

                        g.FillRectangle(boje[selektovano], pocX + mJ * dKvadratica, pocY + mI * dKvadratica, dKvadratica, dKvadratica);
                    }
                }
            }
        }


        public void probajDaDas(cFigura figura, int x, int y, Graphics g, int selektovano)
        {
            if (!MisUTabli(x, y))
                return;
            if (!slobodno(figura,x,y))
                return;
            Ubaci(figura,g, selektovano);
        }
    }
}
