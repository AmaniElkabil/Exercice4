using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Droite
    {
        //Déclaration des variables
        private Point X1;
        private Point Y1;
        public Point(double pX1, double pY2)
        {
            X1 = pX1;
            Y1 = pY2;
        }
        public double PointX1
        {
            get { return X1;  }
            set { X1 = value; }
        }
        public double PointY1
        {
            get { return Y1; }
            set { Y1 = value; }
        }
        static public bool parallelisme(Point A , Point B , Point C , Point D )
        {
            double D1 = B.PointY1 - A.PointY1 / B.PointX1 - A.PointX1;
            double D2 = D.PointY1 - C.PointY1 / D.PointX1 - C.PointX1;
            if ( D1 == D2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    static public bool perpendicularite(Point A, Point B , Point C , Point D)
    {
        double D3 = B.PointY1 - A.PointY1 / B.PointX1 - A.PointX1;
        double D4 = D.PointY1 - C.PointY1 / D.PointX1 - C.PointX1;
        return (D3 * D4 == 1);
    }
    static public void intersection(droite L, droite M)
    {
        if((droite.parallelisme(L,M) == false) && (droite.perpendicularite(L,M) == true)
        {
            Console.WriteLine("Il y a une intersection");
        }
    }
    static public bool egalite(Point A, Point B, Point C, Point D)
    {
        return(A.PointX1 == C.PointX1 && A.PointY1 == C.PointY1 && B.PointX1 == D.PointX1 && B.PointY1 == D.PointY1)
    }
}
