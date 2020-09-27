using System;

namespace SIT_RE_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method to get a string made of the first 2 and the last 2 chars from a given a string.
            //If the string length is less than 2, return instead of the empty string.
            PrintOutput(ReString(ReadInput()));
        }
        static string ReadInput()
        {
            Console.WriteLine("Insert string here: ");
            string myString = Console.ReadLine();
            return myString;
        }
        static string ReString(string myString)
        {
            string newString = "";
            if (myString.Length>2)
            {
                newString = myString.Substring(0, 2);
                newString = newString + myString.Substring(myString.Length - 2);
            }
            else if (myString.Length == 2)
            {
                newString = myString + myString;
            }
            else
            {
                newString = "Empty string";
            }


            return newString;
        }
        static void PrintOutput(string newString)
        {
            Console.WriteLine("Output is:" + newString);
        }
    }
}
