using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DataBaseSeeder.Models;
using Newtonsoft.Json;

namespace DataBaseSeeder
{
    public class ReadJsonFromFile : IReadJsonFromFile
    {
        public List<Client> ReadClientsFromJsonFile()
        {
            var list = new List<Client>();
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "DataBaseSeeder.ClientsPayload.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                list = JsonConvert.DeserializeObject<List<Client>>(reader.ReadToEnd());
            }

            return list;
        }
    }
}
