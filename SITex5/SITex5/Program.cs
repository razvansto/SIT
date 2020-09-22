using System;

namespace SITex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number = ");
            int firstNumber = ReadInput();
            Console.Write("Second number = ");
            int secondNumber = ReadInput();
            Console.WriteLine("Without using conditional statement the greater number is = " + Math.Max(firstNumber, secondNumber));
            Console.WriteLine("Using conditional statement the greater number is " + GreaterNumber(firstNumber, secondNumber));
        }

        static int GreaterNumber(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static int ReadInput()
        {
            int number;
            string line = Console.ReadLine();
            if (int.TryParse(line, out number))
            {

            }
            return number;
        }

    }
}
