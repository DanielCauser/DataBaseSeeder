using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DataBaseSeeder.Models;

namespace DataBaseSeeder
{
    public class ReadJsonFromFile : IReadJsonFromFile
    {
        public List<Client> ReadClientsFromJsonFile()
        {
            var list = new List<Client>();
//            using (var reader = new StreamReader(Assembly.GetAssembly(typeof(Startup))
//                                                     .GetManifestResourceStream(Assembly.GetAssembly(typeof(Startup)).GetManifestResourceNames().First()) ?? throw new InvalidOperationException()))
//            {
//                list = JsonConvert.DeserializeObject<List<Client>>(reader.ReadToEnd());
//            }

            return list;
        }
    }
}
