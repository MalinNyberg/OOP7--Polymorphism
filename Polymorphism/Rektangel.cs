using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rektangel : Geometri
    {
        public double Side { get; set; }
        public double Bottom { get; set; }

        public Rektangel() 
        {
            Side = 4;
            Bottom = 10;
        }

        public Rektangel(double side, double bottom) 
        {
            Side = side;
            Bottom = bottom;
        }

        public override double Area() 
        {
            return Side * Bottom / 2;
        }


    }
}
