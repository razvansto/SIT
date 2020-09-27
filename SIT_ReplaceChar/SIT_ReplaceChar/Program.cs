using System;

namespace SIT_ReplaceChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', 
            //except the first char itself.

            Console.WriteLine("Replace first char with $, insert string: ");
            string inputString = ReadInput();
            Console.WriteLine("Replaced chars:\n" + ReplaceChar(inputString));
            Console.ReadLine();

            //Write a method to get a single string from two given strings, separated by a space and swap 
            //the first two characters of each string.

            Console.WriteLine("Single string from two given string and swap.\nInsert first string:");
            string firtString = ReadInput();
            Console.WriteLine("Insert second string:");
            string secondString = ReadInput();
            Console.WriteLine("Result is: " + SingleAndSwap(firtString, secondString));

            //Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, 
            //if 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'. Return the resulting string.

            //Cred ca am hardcodat dar eu asa am inteles ca trebuie metoda doar pe exemplu.

            Console.WriteLine("Insert string here:");
            string myString = ReadInput();
            Console.WriteLine(ReplaceNot(myString));
        }
        static string ReadInput()
        {
            string inputString = Console.ReadLine();
            return inputString;
        }
        static string ReplaceChar(string inputString)
        {
            string replacedCharString = Convert.ToString(inputString[0]);
            for (int i = 1; i < inputString.Length; i++)
            {

                if (inputString[0] == inputString[i])
                {
                    replacedCharString = replacedCharString + "$";
                }
                else
                {
                    replacedCharString = replacedCharString + inputString[i];
                }
            }
            return replacedCharString;
        }
        static string SingleAndSwap(string firstString, string secondString)
        {
            string oneString = "";
            string firstTempString = secondString.Substring(0, 2);
            string secondTempString = firstString.Substring(0, 2);
            for (int i = 2; i < firstString.Length; i++)
            {
                firstTempString = firstTempString + firstString[i];
                secondTempString = secondTempString + secondString[i];
            }
            oneString = firstTempString + " " + secondTempString;
            return oneString;
        }
        static string ReplaceNot(string myString)
        {
            string myNewString = "";
            int index = myString.IndexOf("not");
            if (index != 0)
            {
                myNewString = myString.Remove(index) + "poor!";
            }
            else
            {
                index = myString.IndexOf("good");
                myNewString = myString.Remove(index) + "poor!";
            }
            return myNewString;
        }

    }
}
