using System;

namespace SITex10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write program that outputs a triangle made of stars with variable size, depending on an input parameter
            Console.WriteLine("Insert Input:");
            int myNumber = ReadInput();
            MakePiramid(myNumber);
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
        static void MakePiramid(int a)
        {
            Console.WriteLine("The Great Piramid from Egipt");
            for (int i = 1; i <= a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = a-1; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
