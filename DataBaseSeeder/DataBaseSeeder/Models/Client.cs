﻿using System;
using System.Collections.Generic;

namespace DataBaseSeeder.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Contract> Contracts { get; set; }
        public List<Receipt> Receipts { get; set; }
    }
}
