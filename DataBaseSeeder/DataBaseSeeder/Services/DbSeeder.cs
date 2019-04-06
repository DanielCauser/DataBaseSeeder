using System;
using System.Threading.Tasks;
using SQLitePCL;
using SQLite;
using Xamarin.Essentials;
using DataBaseSeeder.Models;
using System.Reflection;
using System.Linq;

namespace DataBaseSeeder
{
    public class DbSeeder : IDbSeeder
    {
        private readonly IReadJsonFromFile _jsonreaderService;

        public DbSeeder(IReadJsonFromFile jsonreaderService)
        {
            _jsonreaderService = jsonreaderService;
        }

        public SQLiteConnection SQLiteAsyncConnection { get; private set; }

        public Task Seed()
        {
            var clients = _jsonreaderService.ReadClientsFromJsonFile();

            //SQLiteAsyncConnection = new SQLiteConnection(FileSystem.AppDataDirectory, "DataBase.db");

            string nspace = "DataBaseSeeder.Models";

            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == nspace
                    select t;
            q.ToList().ForEach(t => Console.WriteLine(t.Name));
            // Reflection + recursion.
            // for a given type find out all the.
            // adjacent and get the type from the given list.

            //SQLiteAsyncConnection.CreateTable<Client>();
            //SQLiteAsyncConnection.CreateTable<Contract>();
            //SQLiteAsyncConnection.CreateTable<ContractNote>();
            //SQLiteAsyncConnection.CreateTable<Receipt>();

            return Task.CompletedTask;
        }

        // create tables

        // Loop through all entities in payload

        // Save entities to each of the entities 
        // to the database
    }
}