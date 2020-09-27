using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SIT_LastPart
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method to get the last part of a string before a specified character.

            Console.WriteLine("Insert string: ");
            Console.WriteLine(RemoveLastPart(ReadInput()));

            //Write a method to check whether a string starts with specified characters

            Console.WriteLine("Insert string:");
            string inputString = ReadInput();
            Console.WriteLine("Insert char:");
            char inputChar = char.Parse(ReadInput());
            Console.WriteLine(CheckStartsChar(inputString, inputChar));

            //Write a method to count occurrences of a substring in a string

            Console.WriteLine("Insert string: ");
            string inputString = ReadInput();
            Console.WriteLine("Insert substring:");
            string inputSubString = ReadInput();
            Console.WriteLine(CountOccurrences(inputString, inputSubString));

            //Write a method to swap comma and dot in a string.

            Console.WriteLine("Insert string:");
            string inputString = ReadInput();
            Console.WriteLine(ReplaceDot(inputString));

            //Write a method to remove spaces from a given string.

            Console.WriteLine("Insert string:");
            string inputString = ReadInput();
            Console.WriteLine(RemoveWhiteSpaces(inputString));

        }
        static string ReadInput()
        {
            string inputString = Console.ReadLine();
            return inputString;
        }
        static string RemoveLastPart(string inputString)
        {
            string newString = "";
            char[] specialChar = {'@','~','#','$','%','^','&','*','-','_','<','>','/'};
            int index = 0;
            for (int i = 0; i < specialChar.Length; i++)
            {
                index = inputString.LastIndexOf(specialChar[i]);
            }

            newString = inputString.Remove(index);

            return newString;
        }
        static string CheckStartsChar(string inputString, char inputChar)
        {
            string result = "";
            if (inputChar >='A' && inputChar <='Z')
            {
                inputString = inputString.ToUpper();
            }
            else
            {
                inputString = inputString.ToLower();
            }
            if (inputString[0]==inputChar)
            {
                  result="The string contain the char: "+Convert.ToString(inputChar);
            }
            else
            {
                  result = "The string don't start with " + inputChar;
            }
            return result;
        }

        static int CountOccurrences(string inputString, string inputSubString)
        {
            int count = 0;
            string newString = "";
            while (inputString.Contains(inputSubString))
            {
                count++;
                int index = inputSubString.IndexOf(inputSubString);
                newString = inputString.Remove(index, inputSubString.Length);
                inputString = newString;
            }
            
            return count;
        }
        static string ReplaceDot(string inputString)
        {
            string newString = "";

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '.')
                {
                    newString = newString + ',';
                }
                else if (inputString[i]==',')
                {
                    newString = newString + '.';
                }
                else
                {
                    newString = newString + inputString[i];
                }
            }
            return newString;
        }
        static string RemoveWhiteSpaces(string inputString)
        {
            string newString = "";
            //newString = inputString.Replace(" ","");
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ' ')
                {
                    i++;
                }
                else
                {
                    newString = newString + inputString[i];
                }
            }
            return newString;
        }

    }
}
