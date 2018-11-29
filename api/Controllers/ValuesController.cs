using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Certificate>> Get()
        {
            return new Certificate[]
            {
                new Certificate
                {
                    Name = "www.calm.fi",
                    ValidFrom = DateTime.Parse("1.1.2017"),
                    ValidThrough =  DateTime.Parse("31.12.2018"),
                    Thumbprint = "6834dd70b477e9618ca303465f4950ef71cf2420"
                },
                new Certificate
                {
                    Name = "*.calm.fi",
                    ValidFrom = DateTime.Parse("4.5.2018"),
                    ValidThrough = DateTime.Parse("8.10.2019"),
                    Thumbprint = "d637ff254c687465ab729c99e3526a8fdbb8dd40"
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
