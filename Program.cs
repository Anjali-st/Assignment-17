using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment_17
{
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(3, 4);
            Triangle triangle = new Triangle(4, 3, 2);

            Console.WriteLine("Circle Info:");
            circle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Rectangle Info:");
            rectangle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Triangle Info:");
            triangle.PrintInfo();

            Console.ReadLine();
        }
    }
}
