using System;

namespace SITex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert N=");
            int n = ReadInput();
            Console.WriteLine("The numbers are:");
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
                Console.WriteLine(i);
            }
        }

    }
}
