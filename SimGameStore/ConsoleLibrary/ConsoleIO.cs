using System;
using System.Diagnostics;
using BusinessLibrary;

namespace ConsoleLibrary
{
    public class ConsoleMain
    {
        public void write()
        {
            Console.WriteLine("Welcome to Ray's Store.");
            char choice;
            do
            {
                Console.WriteLine("Console Library");
                Console.WriteLine("Menu:\n" + "Please select the option");
                Console.WriteLine("\t[1] Add Customer\n" +
                    "\t[q] Quit");
                string consoleInput = Console.ReadLine();
                choice = char.Parse(consoleInput.ToLower());

                if (choice == '1')
                    addcustomer();
            } while (choice != 'q');

        }

        public void addcustomer()
        {
            Console.WriteLine("Adding Customer");
            Console.WriteLine("First Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Phone Number");
            string phone = Console.ReadLine();

            BusinessClass cc = new BusinessClass();
            cc.AddCustomertoDB(firstname, lastname, phone);
        }
    }
}
