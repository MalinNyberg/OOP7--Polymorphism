using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Geometri
    {
        public virtual double Area()
        {
            return 0.0;
        }

        public string Output()
        {
            return $"{this.GetType().Name} -  Area: {this.Area()}";
        }

    }
}
