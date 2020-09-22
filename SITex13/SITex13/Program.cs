using System;

namespace SITex13
{
    class Program
    {
        // A program which iterates the integers from 1 to 50 For multiples of three print "Fizz" 
        //instead of the number and for the multiples of five print "Buzz". 
        //For numbers which are multiples of both three and five print "FizzBuzz
        static void Main(string[] args)
        {
            
            for (int i = 0; i <= 50; i++)
            {
                string result = "";
                if(i%3==0)
                {
                    result += "Fizz";
                }
                if (i%5==0)
                {
                    result += "Buzz";
                }
                if (i%3 !=0 && i%5 !=0)
                {
                    Console.WriteLine(i);

                }
                else
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
