﻿using System;
using System.Collections.Generic;

namespace Project1.DataAccess.Entities
{
    public partial class Customers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
