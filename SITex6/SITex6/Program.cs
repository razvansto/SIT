using System;

namespace SITex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Number {0} = ",(i+1));
                string line = Console.ReadLine();
                int number = 0;
                bool isNumber = int.TryParse(line, out number);

                if (isNumber == false)
                {
                    Console.WriteLine("This is not a valid integer");
                    break;
                }
                else
                {
                    sum += number;
                    count++;
                }
            }
            if (count==5)
            {
                Console.WriteLine("Sum is {0} ", (sum));
            }
            
        }    
    }
}
