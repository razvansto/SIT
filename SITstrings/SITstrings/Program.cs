using System;
using System.Text;

namespace SITstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings: am construit asa tema pentru ca am considerat ca este mai usor de scris si de verificat.

            //Write a method that to remove the nth index character from a nonempty string.

            RemoveIndex();

            //Write a method that to remove the characters which have odd index values of a given string.

            RemoveOddIndex();

            //Write a method that takes input from the user and displays that input back in upper and lower cases.

            ToUpperAndToLower();

            //Write a method that reverses a string if it's length is a multiple of 4

            ReverseString();

            //Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters 
            //in the first 4 characters.

            ToUpperWithCondition();

            //Write a method that to remove a newline.

            RemoveNewLine();

            //Write a method to display formatted text (width=50) as output.

            FormattedText();

            //Write a method that formats a number with a percentage.

            FormatNumberToPercentage();

            //Write a method that reverses a string.

            ReversesString();

            //Write a method that transforms to lowercase first n characters in a string

            ToLowerFirstCharacters();

            //Write a method to capitalize first and last letters of each word of a given string.

            CapitalizeFirstAndLastLetter();

            //Write a method to compute sum of digits of a given string(if any).

            SumDigitsOfString();
        }

        static void RemoveIndex()
        {
            string myString = "Albastru";
            int index = 4;
            string firstPart = myString.Remove(index);
            string secondPart = myString.Remove(0, index + 1);
            Console.WriteLine(firstPart + secondPart);
        }
        static void RemoveOddIndex()
        {
            string myString = "Albastru";
            string myNewString = "";
            for (int i = 0; i < myString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    myNewString = myNewString + myString[i];
                }
            }
            Console.WriteLine(myNewString);
        }
        static void ToUpperAndToLower()
        {
            Console.Write("Insert string: ");
            string myString = Console.ReadLine();
            Console.WriteLine("To Upper " + myString.ToUpper());
            Console.WriteLine("To Lower " + myString.ToLower());
        }
        static void ReverseString()
        {
            Console.WriteLine("Insert string: ");
            string myString = Console.ReadLine();
            string myReversedString = "";
            if (myString.Length%4==0)
            {
                for (int i = myString.Length-1; i>=0 ; i--)
                {
                    myReversedString = myReversedString + myString[i];
                }
                Console.WriteLine("Reverse string: {0}", myReversedString);
            }
            else
            {
                Console.WriteLine("The string is not a multiple of 4");
            }
        }
        static void ToUpperWithCondition()
        {
            string myString = "AnA are mere si pere";
            string myUpperString = myString.ToUpper();
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                if ( myUpperString[i] == myString[i])
                {
                    index++;
                }
            }
            if (index >= 2 )
            {
                Console.WriteLine("Upper String: {0}",myUpperString);
            }
            else
            {
                Console.WriteLine("The string don't contains 2 upper letter in the first 4 char");
            }
        }
        static void RemoveNewLine()
        {
            string myString = " Ana are \n mere \t si \r pere";
            string myNewString ="";
            for (int i = 0; i < myString.Length; i++)
            {
                if (myString[i] != '\n' && myString[i] != '\t' && myString[i] != '\r')
                {
                    myNewString = myNewString + myString[i];
                }

            }
            Console.WriteLine("Removed new line string: {0}",myNewString);


        }
        static void FormattedText()
        {
            Console.WriteLine("Insert text to format: ");
            string myString = Console.ReadLine();
            Console.WriteLine("Insert index where to format:");
            int indexFormat = 50;
            int lines = myString.Length / indexFormat;
            StringBuilder myFormattedString = new StringBuilder();
            myFormattedString.Append(myString);
            int indexInsert = indexFormat;
            for (int i = 0; i < lines; i++)
            {
                myFormattedString.Insert(indexInsert, '\n');
                indexInsert = indexFormat +51;
            }
            Console.WriteLine("Formatted text:");
            Console.WriteLine(myFormattedString);

        }
        static void FormatNumberToPercentage()
        {
            Console.WriteLine("Insert number: ");
            string line = Console.ReadLine();
            double myNumber = double.Parse(line);
            Console.WriteLine($"Formatted number is: {myNumber:P1}");

        }
        static void ReversesString()
        {
            Console.WriteLine("Insert string:");
            string myString = Console.ReadLine();
            string myReversString = "";
            for (int i = myString.Length-1; i >=0; i--)
            {
                myReversString = myReversString + myString[i];
            }
            Console.WriteLine($"Reverses string is: {myReversString}");
        }
        static void ToLowerFirstCharacters()
        {
            Console.WriteLine("Insert string:");
            string myString = Console.ReadLine();
            Console.WriteLine("Insert N");
            int number = int.Parse(Console.ReadLine());
            string subStringOne = "";
            string subStringTwo = "";
            subStringOne = myString.Substring(0, number).ToLower();
            subStringTwo = myString.Substring(number);
            Console.WriteLine("Result is: "+ subStringOne+subStringTwo);

        }
        static void CapitalizeFirstAndLastLetter()
        {
            Console.WriteLine("Insert string");
            string myString = Console.ReadLine();
            string startTempString = myString.Substring(0, 1).ToUpper();
            string midTempString = myString.Substring(1, myString.Length - 2);
            string finalTempString = myString.Substring(myString.Length - 1, 1).ToUpper();
            Console.WriteLine("Capitalized first and last letter: "+startTempString+midTempString+finalTempString);

        }
        static void SumDigitsOfString()
        {
            Console.WriteLine("Insert index:");
            string myString = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < myString.Length; i++)
            {
                if (myString[i] == 1 || myString[i] == 2 || myString[i] == 3 || myString[i] == 4
                    || myString[i] == 5|| myString[i] == 6 || myString[i] == 7 || myString[i] == 8 || myString[i] == 9
                    || myString[i] == 0)
                {
                    int digit = Convert.ToInt32(myString[i]);
                    sum += digit;
                }
            }
            Console.WriteLine("Sum is: ", sum);

        }

    }
}
