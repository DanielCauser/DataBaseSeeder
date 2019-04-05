using System.Collections.Generic;
using System.Threading.Tasks;
using DataBaseSeeder.Models;

namespace DataBaseSeeder
{
    public interface IReadJsonFromFile
    {
        List<Client> ReadClientsFromJsonFile();
    }
}
