using System;

namespace SIT_CleanTheText
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will get a text from where you will need to clean the 
            //text because it contains a lot of strange characters that don’t belong there ( ^ <, > &+ @%$)

            PrintOutput(CleanText(ReadInput()));
        }
        static string ReadInput()
        {
            Console.Write("Insert text here: ");
            string myString = Console.ReadLine();
            return myString;
        }
        static string CleanText(string myString)
        {
            string cleanString="";
            char[] specialChar = {'^','<','>','&','+','@','%','$'};
            bool isSpecialChar;
            for (int i = 0; i < myString.Length; i++)
            {
                isSpecialChar = false;
                for (int j = 0; j < specialChar.Length; j++)
                {
                    if (myString[i] == specialChar[j])
                    {
                        isSpecialChar = true;
                    }
                }
                if (isSpecialChar ==  false )
                {
                    cleanString = cleanString + myString[i];
                }
                else
                {
                    cleanString = cleanString +' ';
                }
                
            }
            string cleanWhiteSpace = "";
            for (int i = 0; i < cleanString.Length; i++)
            {
                if (cleanString[i] == ' ' && cleanString[i+1] == ' ')
                {
                    cleanWhiteSpace = cleanWhiteSpace + ' ';
                    i++;
                }
                else
                {
                    cleanWhiteSpace = cleanWhiteSpace + cleanString[i];
                }
            }
           
            return cleanWhiteSpace;
        }
        static void PrintOutput(string myString)
        {
            Console.WriteLine("Clean text: "+myString);
        }

    }
}
