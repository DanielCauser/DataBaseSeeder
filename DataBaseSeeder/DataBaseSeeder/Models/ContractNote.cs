using System;
namespace DataBaseSeeder.Models
{
    public class ContractNote
    {
        public Guid Id { get; set; }
        public string Detail { get; set; }
        public Guid ClientId { get; set; }
    }
}
