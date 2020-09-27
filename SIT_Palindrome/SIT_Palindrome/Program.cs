using System;

namespace SIT_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert string");
            string inputString = ReadInput();
            Console.WriteLine("The is string is palindrome:"+CheckPalindrom(inputString));
        }
        static string ReadInput()
        {
            string inputString = Console.ReadLine();
            return inputString;
        }
        static bool CheckPalindrom(string inputString)
        {
            bool check = true;
            string reversedString = "";
            for (int i = inputString.Length-1; i >= 0; i--)
            {
                reversedString = reversedString + inputString[i];
            }
            if (inputString != reversedString)
            {
                check = false;
            }
            return check;
        }
    }
}
