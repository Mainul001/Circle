using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCalculation
{
    class Circle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double getDiameter()
        {
            return Radius*2;
        }

        public double getArea()
        {
            return Math.PI*Math.Pow(Radius, 2);
        }

        public double getPerimeter()
        {
            return 2*Math.PI*Radius;
        }
    }
}
