using System;

namespace SITex12
{
    class Program
    {
        //Write a program that by a given integer N prints the numbers from 1 to N in random order
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number: ");
            int myNumber = ReadInput();
            Console.WriteLine("Random numbers:");
            GenerateRandom(myNumber);
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
        static void GenerateRandom(int a)
        {
            int[] myArr = new int[a];
            for (int i = 0; i < a; i++)
            {
                myArr[i] = i;
            }
            Random rnd = new Random();
            int temp, randomNumber;
            foreach (int i in myArr)
            {
                randomNumber = rnd.Next(0, a);
                temp = myArr[i];
                myArr[i] = myArr[randomNumber];
                myArr[randomNumber] = temp;
            }
            foreach (int i in myArr) Console.WriteLine(myArr[i]);
        }

    }
}
