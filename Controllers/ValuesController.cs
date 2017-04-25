using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netcore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Value> Get()
        {
            return new Value[] {
              new Value { Id = 1, Text = "value1"},
              new Value { Id = 2, Text = "value2"}
            };
        }

        // GET api/values/5
        [HttpGet("{id:int}")]
        public Value Get(int id)
        {
            return new Value { Id = id, Text = "value" };
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
    public class Value {
      public int Id { get; set; }
      public string Text { get; set; }
    }
}
