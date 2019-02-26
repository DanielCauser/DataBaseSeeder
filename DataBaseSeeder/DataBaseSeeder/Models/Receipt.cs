using System;
namespace DataBaseSeeder.Models
{
    public class Receipt
    {
        public Guid Id { get; set; }
        public string Detail { get; set; }
        public Guid ClientId { get; set; }
        public ReceiptContractStatus ContractStatus { get; set; }
        public string Balance { get; set; }
    }
}
