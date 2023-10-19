using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Fyrkant : Geometri
    {
        public double Side { get; set; }

        public Fyrkant()
        {
            Side = 8;
        }

        public Fyrkant(double side) 
        {
            Side = side; 
        }

        public override double Area()
        {
            return Side * Side;
        }

    }


}
