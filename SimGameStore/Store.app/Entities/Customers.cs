using System;
using System.Collections.Generic;

namespace Store.app.Entities
{
    public partial class Customers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
