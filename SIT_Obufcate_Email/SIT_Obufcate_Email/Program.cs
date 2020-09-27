using System;

namespace SIT_Obufcate_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintOutput(ObufcateEmail(ReadInput()));
        }

        static string ReadInput()
        {
            Console.WriteLine("Insert email:");
            string newEmail = Console.ReadLine();
            return newEmail;
        }
        static string ObufcateEmail(string myEmail)
        {
            string obufcateEmail = "";
            int findPlace=0;
            for (int i = 0; i < myEmail.Length; i++)
            {
                if (myEmail[i]=='@')
                {
                    findPlace = i;
                }
            }
            for (int i = 0; i < findPlace; i++)
            {
                obufcateEmail = obufcateEmail + '*';
            }

            obufcateEmail = obufcateEmail + myEmail.Substring(findPlace);

            return obufcateEmail;
        }
        static void PrintOutput(string obufcateEmail)
        {
            Console.WriteLine("Obufcate Email: " + obufcateEmail);
        }
    }
}
