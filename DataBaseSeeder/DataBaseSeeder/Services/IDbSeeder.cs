using System.Threading.Tasks;

namespace DataBaseSeeder
{
    public interface IDbSeeder
    {
        Task Seed();
    }
}