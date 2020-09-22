using System;
using System.ComponentModel.DataAnnotations;

namespace SITex9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console a series of 5 integers 
            // and prints the smallest and largest of them.
            Console.WriteLine("Insert 5 Numbers:");
            int[] myArr = new int[5];
            myArr = ReadInput();
            BiggerNumber(myArr);    

        }
        static int[] ReadInput()
        {
            int number;
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                string line = Console.ReadLine();
                if (int.TryParse(line, out number))
                {

                }
                arr[i] = number;
            }
           
            return arr;
            

        }
        static void BiggerNumber(int[] a)
        {
            int biggerNumber = a[0];
            for (int i = 1; i < 5; i++)
            {
                if ( biggerNumber < a[i])
                { 
                    biggerNumber = a[i];
                }
            }
            Console.WriteLine("The bigger number is: "+ biggerNumber);
            Console.ReadLine();
        }
    }
}
