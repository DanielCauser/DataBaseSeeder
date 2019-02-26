using System;
using DataBaseSeeder.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBaseSeederAPI
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractNote> ContractNotes { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed
            //var list = new List<TodoItem>();

            //using (var reader = new StreamReader(Assembly.GetAssembly(typeof(Startup))
            //                                         .GetManifestResourceStream(Assembly.GetAssembly(typeof(Startup)).GetManifestResourceNames().First()) ?? throw new InvalidOperationException()))
            //{
            //    list = JsonConvert.DeserializeObject<List<TodoItem>>(reader.ReadToEnd());
            //}

            //modelBuilder.Entity<TodoItem>().HasData(list.ToArray());
        }
    }
}
