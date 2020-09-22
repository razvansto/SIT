using System;

namespace SITex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert numbers:");
            Console.Write("First number = "); 
            int firstNumber = ReadInput();
            Console.Write("Second number = ");
            int secondNumber = ReadInput();
            Console.Write("Third number = ");
            int thirdNumber = ReadInput();
            Console.WriteLine("Sum is = " + CalculatedSum(firstNumber,secondNumber,thirdNumber));
            Console.ReadLine();
          
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

        static int CalculatedSum(int a, int b, int c)
        {
            return (a + b + c);
        }
    }
}
