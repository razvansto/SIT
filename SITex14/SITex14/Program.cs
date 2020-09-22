using System;

namespace SITex14
{
    class Program
    {
        static void Main(string[] args)
        {
            // A given company has name, address, phone number, fax number, web site and manager.
            //The manager has name, surname and phone number. 
            //Write a program that reads information about the company and its manager and then prints it on the console.
            string[] companyData = new string[6];
            companyData=InputCompanyData();
            string[] managerData = new string[3];
            managerData = InputManagerData();
            OutputCompanyData(companyData);
            OutputManagerData(managerData);
        }
        static string[] InputCompanyData()
        {
            string[] companyData = new string[6];
            Console.WriteLine("Company Name:");
            companyData[0] = Console.ReadLine();
            Console.WriteLine("Comapany Address:");
            companyData[1] = Console.ReadLine();
            Console.WriteLine("Company Phone Number:");
            companyData[2] = Console.ReadLine();
            Console.WriteLine("Company Fax Number");
            companyData[3] = Console.ReadLine();
            Console.WriteLine("Company Web Site:");
            companyData[4] = Console.ReadLine();
            Console.WriteLine("Company Manager");
            companyData[5] = Console.ReadLine();

            return companyData;
        }
        static string[] InputManagerData()
        {
            string[] managerData = new string[3];
            Console.WriteLine("Manager first name:");
            managerData[0] = Console.ReadLine();
            Console.WriteLine("Manager surname:");
            managerData[1] = Console.ReadLine();
            Console.WriteLine("Manager phone number:");
            managerData[2] = Console.ReadLine();
            return managerData;
        }
        static void OutputCompanyData(string[] a)
        {
            Console.WriteLine("\nCompany\nName: {0}\nAddress: {1}\nPhone Number: {2}\nFax Number: {3}\nWeb Site: {4}\nManger: {5}\n", a[0], a[1], a[2], a[3], a[4], a[5]);
        }
        static void OutputManagerData(string[] a)
        {
            Console.WriteLine("\nManager\nFirst name: {0}\nSurname: {1}\nPhone Number: {2}\n",a[0], a[1], a[2]);
        }
    }
    
}
