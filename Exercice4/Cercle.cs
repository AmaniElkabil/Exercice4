using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Cercle
    {
        private Point C; // le centre
        private int r; //le rayon 
        public Cercle(Point C , int r)
        {
            this.C = C;
            this.r = r;
        }
        public Point GetC()
        {
            return C;
        }
        public void SetC(Point ctr)
        {
            this.C = ctr;
        }
        public Point Getr()
        {
            return r;
        }
        public void Setr(Point ryn)
        {
            this.r = ryn;
        }
        public bool Egal(Point ctr , Point ryn)
        {
            if ((this.C == ctr) && (this.r == ryn))
                return true;
            else
                return false;
        }
        public double Circonference()
        {
            return Math.Round(2 * Math.P1 * r);
        }
        public double CircleArea()
        {
            return Math.P1 * (r * r);
        }
    }
}
