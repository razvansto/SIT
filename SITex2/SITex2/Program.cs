using System;

namespace SITex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The biggest number is = " + BiggestNumber());
            Console.ReadLine();
        }

        static int BiggestNumber()
        {
            int number;
            int biggestNumber = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Insert number " + i +" = ");
                number = ReadInput();
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }
            return biggestNumber;
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
