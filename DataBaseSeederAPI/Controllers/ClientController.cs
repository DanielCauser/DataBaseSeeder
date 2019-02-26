using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseSeeder.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using Microsoft.EntityFrameworkCore;

namespace DataBaseSeederAPI.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly ClientContext _db;

        public ClientController(ClientContext dbContext)
        {
            _db = dbContext;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _db.Clients.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Client Get(Guid id)
        {
            return _db.Clients.Single(x => x.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
