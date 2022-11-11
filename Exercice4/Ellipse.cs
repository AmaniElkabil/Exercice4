using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Ellipse
    {
        private int grandAxe;
        private int petitAxe;
        public Ellipse(int gAxe , int pAxe)
        {
            grandAxe = gAxe;
            petitAxe = pAxe;
        }
        public int grandAxe
        {
            get { return grandAxe; }
            set { grandAxe = value; }

        }
        public double petitAxe
        {
            get { return petitAxe; }
            set { petitAxe = value; }
        }
        public float surface()
        {
            return (float)Math.Pi * grandAxe * petitAxe;
        }
        public float péerimetre()
        {
            return (float) 2 * Math.Pi * (Math.sqrt((Math.pow(grandAxe, 2)) + (Math.pow(petitAxe, 2)) / 2));
        }
    }
}