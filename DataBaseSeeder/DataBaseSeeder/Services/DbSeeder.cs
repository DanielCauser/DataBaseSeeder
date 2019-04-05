using System;
using System.Threading.Tasks;

namespace DataBaseSeeder
{
    public class DbSeeder : IDbSeeder
    {
        private readonly IReadJsonFromFile _jsonreaderService;

        public DbSeeder(IReadJsonFromFile jsonreaderService)
        {
            _jsonreaderService = jsonreaderService;
        }
        public Task Seed()
        {
            var clients = _jsonreaderService.ReadClientsFromJsonFile();


            return Task.CompletedTask;
        }
    }
}