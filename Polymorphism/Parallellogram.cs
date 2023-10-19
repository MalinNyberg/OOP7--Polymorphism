using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Parallellogram : Geometri
    {
        public double Bas {  get; set; }    
        public double Height { get; set; }

        public Parallellogram()
        {
            Bas = 6;
            Height = 3; 
        }

        public Parallellogram(double bas, double height) 
        {
            Bas = bas;
            Height = height;
        }

        public override double Area() 
        {
            return Bas * Height;
        }
    }
}
