using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");

            double radius = double.Parse(Console.ReadLine());

            Circle aCircle = new Circle(radius);

            Console.WriteLine("The diameter is " + aCircle.getDiameter());
            Console.WriteLine("Area " + aCircle.getArea());
            Console.WriteLine("Perimeter(Circumference) " + aCircle.getPerimeter());

            Console.ReadLine();
        }
    }
}
