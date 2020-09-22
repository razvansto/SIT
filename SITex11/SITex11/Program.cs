using System;

namespace SITex11
{
    class Program
    {
        // Write a program that converts a given number from decimal to binary notation (numeral system).
        static void Main(string[] args)
        {
            Console.WriteLine("Insert decimal");
            int myNumber = ReadInput();
            CreateBinary(myNumber);
        }

        static void CreateBinary(int a)
        {
            int count = 0;
            int[] myBinary= new int[10];
            for (int i = 0; a>0; i++)
            {
                myBinary[i] = a % 2;
                a /= 2;
                count = i;
            }
            Console.WriteLine("Binary is: ");
            for (int i=count;  i >= 0; i--)
            {
                Console.Write(myBinary[i]);
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
