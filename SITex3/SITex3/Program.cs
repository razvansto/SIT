using System;
using System.Reflection.Metadata.Ecma335;

namespace SITex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert radius = " );
            double radius = ReadInput();
            Console.WriteLine("Perimeter is = " + CalculatedPerimeter(radius));
            Console.WriteLine("Area is = " + CalculatedArea(radius));
            Console.ReadLine();
        }

        static double CalculatedPerimeter(double r)
        {
            double perimeter;
            perimeter = 2 * (Math.PI * r);
            return perimeter;
        }

        static double CalculatedArea(double r)
        {
            double area;
            area = Math.PI *(r*r);
            return area;
        }

        static double ReadInput()
        {
            double radius;
            string line = Console.ReadLine();
            if (double.TryParse(line, out radius))
            {

            }
            return radius;
        }
    }
}
