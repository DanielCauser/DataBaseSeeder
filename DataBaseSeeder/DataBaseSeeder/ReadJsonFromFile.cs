using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataBaseSeeder.Models;

namespace DataBaseSeeder
{
    public class ReadJsonFromFile : IReadJsonFromFile
    {
        public Task<List<Client>> ReadClientsFromJsonFile()
        {
            var list = new List<Client>();
            //using (var reader = new StreamReader(Assembly.GetAssembly(typeof(Startup))
            //                                         .GetManifestResourceStream(Assembly.GetAssembly(typeof(Startup)).GetManifestResourceNames().First()) ?? throw new InvalidOperationException()))
            //{
            //    list = JsonConvert.DeserializeObject<List<TodoItem>>(reader.ReadToEnd());
            //}

            return Task.CompletedTask;
        }
    }
}
