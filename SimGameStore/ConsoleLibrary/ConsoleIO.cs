using System;
using System.Collections.Generic;
using System.Diagnostics;
using BusinessLibrary;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Project1.DataAccess;
using Project1.DataAccess.Entities;

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
                    "\t[2] Search for Customer by last Name\n" +
                    "\t[q] Quit");
                string consoleInput = Console.ReadLine();
                choice = char.Parse(consoleInput.ToLower());

                if (choice == '1')
                    addcustomer();
                if (choice == '2')
                    searchcustomerbyln();
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

            DAL cc = new DAL();
            cc.AddCustomertoDB(firstname, lastname, phone);
        }

        public void searchcustomerbyln()
        {
            Console.Write("Enter the customer's last name: ");
            string lnsearch = Console.ReadLine();
            DAL cc = new DAL();
            List<Customers> results = new List<Customers>(cc.searchbylastname(lnsearch));
            foreach (var x in results)
                Console.WriteLine("[{0}]: {1}, {2}; Phone: {3}", x.Id, x.LastName, x.FirstName, x.Phone);
            if (results.Count == 0)
                Console.WriteLine("No customer records match the last name '" + lnsearch + "'");
            Console.WriteLine("If you would like to see a customer's details (including order history) enter the customer number " +
                "otherwise enter 'r' to return to main menu: ");
            int customerSelect = int.Parse(Console.ReadLine().ToLower());
            foreach (var x in results)
                if (customerSelect == x.Id)
                    displayCustomer(x.Id);
        }

        public void displayCustomer(int id)
        {
            Customers display = new Customers();
            DAL cc = new DAL();
            display = cc.customerDetails(id);

            Console.Write($"\n\nCustomer Details for {display.FirstName} {display.LastName}\n");
            Console.Write("----------------------------------------------------------------------------\n");
            Console.Write($"Name: {display.FirstName} {display.LastName}\t\tPhone Number: {display.Phone}\n");
            Console.Write("----------------------------------------------------------------------------\n");
        }
    }
}
