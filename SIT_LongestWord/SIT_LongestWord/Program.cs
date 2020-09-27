using System;

namespace SIT_LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestWord(ReadArrayInput()));
        }
        static string[] ReadArrayInput()
        {
            string[] stringArray = new string[5];
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("Insert string number "+i+1);
                stringArray[i] = Console.ReadLine();
            }

            return stringArray;
        }
        static int LongestWord(string[] stringArray)
        {
            int count = 0;
            foreach (var item in stringArray)
            {
                if (item.Length>count)
                {
                    count = item.Length;
                }
            }
            return count;
        }
    }
}
