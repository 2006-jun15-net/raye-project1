using System;
using System.Collections.Generic;

namespace Project1.DataAccess.Entities
{
    public partial class Orders
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual Customers Customer { get; set; }
    }
}
