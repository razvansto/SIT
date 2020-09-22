using System;

namespace SITex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number = ");
            int firstNumber = ReadInput();
            Console.Write("Second number = ");
            int secondNumber = ReadInput();
            Console.WriteLine("There are " + DivisionFive(firstNumber, secondNumber) + " numbers that are divisible with 5");
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

        static int DivisionFive(int a, int b)
        {
            int count=0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
  
            }
            return count;
        }

    }
}
