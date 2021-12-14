using System;
using System.IO;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contactCount;

            Console.WriteLine("Enter number of contacts: ");
            contactCount = int.Parse(Console.ReadLine());
            
            Contact[] contacts = new Contact[contactCount];

            for(int i = 0; i < contactCount; i++)
            {
                Console.WriteLine("Contact name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Contact lastname: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("Contact phone number: ");
                string phoneNumber = Console.ReadLine();

                Console.WriteLine("Contact e-mail: ");
                string email = Console.ReadLine();

                if (!EmailHelper.IsValidAddress(email))
                {
                    while (!EmailHelper.IsValidAddress(email))
                    {
                        email = Console.ReadLine();
                    }
                }

                contacts[i] = new Contact(name, lastName, phoneNumber, email);
            }

            Console.WriteLine("Enter file name: ");
            string fileName = Console.ReadLine();

            StreamWriter writer = new StreamWriter(fileName);

            for(int i = 0; i < contactCount; i++)
            {
                if (EmailHelper.CheckForFeritAddress(contacts[i].eMail))
                    writer.WriteLine(contacts[i].ShowContact());
            }

            writer.Close();
        }
    }
}
