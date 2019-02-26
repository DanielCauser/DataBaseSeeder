
using System;
using System.Collections.Generic;

namespace DataBaseSeeder.Models
{
    public class Contract
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public ContractContractStatus ContractStatus { get; set; }
        public List<ContractNote> ContractNotes { get; set; }
    }
}