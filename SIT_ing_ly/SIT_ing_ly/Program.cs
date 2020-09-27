using System;

namespace SIT_ing_ly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method to add 'ing' at the end of a given string (length should be at least 3). 
            //If the given string already ends with 'ing' then add 'ly' instead. 
            //If the string length of the given string is less than 3, leave it unchanged.
            PrintOutput(AddIngLy(ReadInput()));

        }
        static string ReadInput()
        {
            Console.WriteLine("Insert string here: ");
            string myString = Console.ReadLine();
            return myString;
        }
        static string AddIngLy(string myString)
        {
            string newString = "";
            if (myString.Length>2 && myString.Substring(myString.Length-3) == "ing")
            {
                newString = myString + "ly";
            }
            else if (myString.Length > 2 && myString.Substring(myString.Length - 3) != "ing")
            {
                newString = myString+"ing";
            }
            else
            {
                newString = myString;
            }

            return newString;
        }
        static void PrintOutput(string newString)
        {
            Console.WriteLine("New string is: "+newString);
        }
    }
}
