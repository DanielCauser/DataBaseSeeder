using System;
using System.Threading.Tasks;
using SQLitePCL;
using SQLite;
using Xamarin.Essentials;
using DataBaseSeeder.Models;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace DataBaseSeeder
{
    public class DbSeeder : IDbSeeder
    {
        private readonly IReadJsonFromFile _jsonreaderService;
        private List<Type> AlreadyAdded { get; set; }
        private List<Object> List { get; set; }

        public DbSeeder(IReadJsonFromFile jsonreaderService)
        {
            _jsonreaderService = jsonreaderService;
            AlreadyAdded = new List<Type>(); 
        }

        public SQLiteConnection sqliteAsyncConnection { get; private set; }

        public Task Seed()
        {
            var list = _jsonreaderService.ReadClientsFromJsonFile();
            sqliteAsyncConnection = new SQLiteConnection(FileSystem.AppDataDirectory, "DataBase.db");
            string nspace = "DataBaseSeeder.Models";

            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == nspace
                    select t;


            // for each of the items is the object graph

            // grab all the Nx1 and NxN of tyeps that are in the 
            // in the assembly type list.

            // create instances for the types
            // loop thought the lists repeating the steps above

            // exit condition is all the types in the assembly have been added.


            q.ToList().ForEach(t => 
            {

            });


            return Task.CompletedTask;
        }

        // create tables

        // Loop through all entities in payload

        // Save entities to each of the entities 
        // to the database
    }
}