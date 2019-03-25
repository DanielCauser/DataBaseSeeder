using DataBaseSeeder;
using DataBaseSeeder.Models;
using Microsoft.EntityFrameworkCore;
using DataBaseSeederAPI.Controllers;

namespace DataBaseSeederAPI
{
    public class ClientContext : DbContext
    {
        private readonly IReadJsonFromFile _seedService;

        public ClientContext(DbContextOptions<ClientContext> options,
            IReadJsonFromFile seedService)
            : base(options)
        {
            _seedService = seedService;
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractNote> ContractNotes { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed
            var list = _seedService.ReadClientsFromJsonFile();
            modelBuilder.Entity<Client>().HasData(list.ToArray());
        }
    }
}
