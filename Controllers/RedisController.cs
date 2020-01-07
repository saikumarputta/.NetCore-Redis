using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;

namespace coreredis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisController : ControllerBase
    {
        private readonly IDatabase _database;
        public RedisController(IDatabase database)
        {
            _database = database;
        }
        // GET: api/Redis
        [HttpGet]
        public string Get([FromQuery] string key)
        {
            return _database.StringGet(key);
        }

        // POST: api/Redis
        [HttpPost]
        public void Post([FromQuery] KeyValuePair<string,string> keyValue)
        {
            _database.StringSet(keyValue.Key, keyValue.Value);
        }

    }
}
