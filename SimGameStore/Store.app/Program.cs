using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project1.DataAccess.Entities;
//using System.Linq;
//using System.Collections.Generic;
using System;

namespace Store.app
{
    class Program
    {
        public static readonly ILoggerFactory myLogFactory = LoggerFactory.Create(LogBuilder => LogBuilder.AddConsole());

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    var builder = new SqlConnectionStringBuilder(Configuration.GetConnectionString())
        //}

        //public static readonly DbContextOptions<Project1Context> Options = new DbContextOptionsBuilder<Project1Context>()
        //    .UseLoggerFactory(myLogFactory)
        //    .UseSqlServer("ConnectionString")
        //    .Options;

        static void Main(string[] args)
        {
            //List<int> a = new List<int>();
            Console.WriteLine("Hello World!");

            BusinessLibrary.BusinessClass aa = new BusinessLibrary.BusinessClass();
            aa.write();

            ConsoleLibrary.ConsoleMain bb = new ConsoleLibrary.ConsoleMain();
            bb.write();
        }
    }
}

//Sprint 1:
//   Create Add Customer Functionality
//      1) dotnet - add functionality to VS - Should link to DB & Add customer first, last name + phone
//      2) SSMS - Create the DB for customer with columns for first name, last name, phone number with index
//      3) Use console terminal to be able to add new custmers once per program run

//Sprint 2:
//   Create Customer lookup functionality
//      1) dotnet - add functionality to VS - Should query customer database based on index and last name
//      2) dotnet - Implement unit testing for sprint 1 and transfer to business logic
//      3) SSMS - None
//      4) Use console to enter customer index or last name to be able to search context for either one
//      5) Create a function to repeat functionailty to save time (simple menu)

//Urgent Goals Remaining:
// Add new customer (done)
// Place orders for customer by store
// Search customers by name (done)
// Display order details
// Display order history by location
// Display order history by customer
// Input Validation
// Exception Handling
// Sort order history
// Repository and interface
// Unit Testing!