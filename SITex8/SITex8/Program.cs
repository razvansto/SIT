using System;

namespace SITex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert N=");
            int n = ReadInput();
            Console.WriteLine("Numbers which are not divisible by 3 and 7:");
            PrintOutput(n);
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
        static void PrintOutput(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
