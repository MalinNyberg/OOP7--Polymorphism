using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Ellips : Geometri
    {
        public double BigRadius { get; set; }
        public double LittleRadius { get; set; }

        public Ellips() 
        {
            BigRadius = 7;
            LittleRadius = 4;
        }

        public Ellips(double bigradius, double littleradius)
        {
            BigRadius = bigradius;
            LittleRadius= littleradius;
        }

        public override double Area() 
        {
            return Math.PI * BigRadius * LittleRadius;
        
        }

    }
}
