using System;
using System.Collections.Generic;

namespace DataBaseSeeder.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Contract> Contracts { get; set; }
        public IList<Receipt> Receipts { get; set; }
    }
}
