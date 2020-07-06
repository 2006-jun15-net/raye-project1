using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Project1.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Project1.DataAccess
{
    public class DAL
    {
        public static readonly ILoggerFactory myLogFactory = LoggerFactory.Create(LogBuilder => LogBuilder.AddConsole());

        public static readonly DbContextOptions<Project1Context> Options = new DbContextOptionsBuilder<Project1Context>()
            .UseLoggerFactory(myLogFactory)
            .UseSqlServer(SecretConfiguration.ConnectionString)
            .Options;

        public void AddCustomertoDB(string fn, string ln, string phone)
        {
            using (var context = new Project1Context(Options))
            {
                var _tempcustomer = new Customers
                {
                    FirstName = fn,
                    LastName = ln,
                    Phone = phone
                };

                context.Add(_tempcustomer);
                context.SaveChanges();
            }
        }

        public List<Customers> searchbylastname(string ln)
        {
            List<Customers> _tempList = new List<Customers>();

            using (var context = new Project1Context(Options))
            {
                var query = from Customers in context.Customers where Customers.LastName == ln select Customers;
                foreach(var x in query)
                {
                    _tempList.Add(x);
                }
            }

            return _tempList;
        }

        public Customers customerDetails(int id)
        {
            Customers _customerDetails = new Customers();

            using (var context = new Project1Context(Options))
            {
                var query = from Customers in context.Customers where Customers.Id == id select Customers;
                foreach(var x in query)
                {
                    _customerDetails.Id = x.Id;
                    _customerDetails.FirstName = x.FirstName;
                    _customerDetails.LastName = x.LastName;
                    _customerDetails.Phone = x.Phone;
                }
            }

            return _customerDetails;
        }
    }
}
