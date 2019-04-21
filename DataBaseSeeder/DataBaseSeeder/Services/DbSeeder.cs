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

        private List<Object> ResourceGraph { get; set; }
        private Dictionary<Type, List<object>> FlatenedList { get; set; }

        private List<Type> AssemplyEntities { get; set; }

        public DbSeeder(IReadJsonFromFile jsonreaderService)
        {
            _jsonreaderService = jsonreaderService;
            AlreadyAdded = new List<Type>();
            FlatenedList = new Dictionary<Type, List<object>>();
            AssemplyEntities = new List<Type>();
        }

        public SQLiteConnection sqliteAsyncConnection { get; private set; }

        public Task Seed()
        {
            ResourceGraph = _jsonreaderService.ReadClientsFromJsonFile().Cast<object>().ToList();
            //sqliteAsyncConnection = new SQLiteConnection(FileSystem.AppDataDirectory, "DataBase.db"));
            string nspace = "DataBaseSeeder.Models";

            AssemplyEntities = (from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == nspace
                    select t).ToList();

            // for each of the items is the object graph
            foreach (var entity in AssemplyEntities)
            {
                if(!FlatenedList.Any())
                {
                    // looping through the root
                    FlatenedList.Add(entity, ResourceGraph.Distinct()
                                                          .ToList());
                    AlreadyAdded.Add(entity);

                    GrabChildren(FlatenedList.First().Key, FlatenedList.First().Value);
                }

                // create instances for the types
                // loop thought the lists repeating the steps above

                // exit condition is all the types in the assembly have been added.
            }

            // lastly
            // create tables
            // Save entities to each of the entities 
            // to the database
            FlatenedList.Clear();

            return Task.CompletedTask;
        }

        private void GrabChildren(Type parentType, List<object> values)
        {
            // grab all the 1xN and NxN of types that are 
            // in the assembly type list.
            foreach (var item in values)
            {
                var oneToOne = parentType.GetProperties()
                                             .Where(x => AssemplyEntities.Contains(x.PropertyType))
                                             .ToList();

                // TO DO GET LIST PROPERTIES
                var oneToMany = parentType.GetProperties()
                                             .Where(x => x.PropertyType
                                                          .Namespace == "System.Collections.Generic")
                                             .ToList();
            }
        }
    }
}