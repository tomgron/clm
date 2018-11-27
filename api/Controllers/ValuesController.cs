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
                    Name = "Foocert1",
                    ValidFrom = DateTime.Parse("1.1.2017"),
                    ValidThrough =  DateTime.Parse("31.12.2018")
                },
                new Certificate
                {
                    Name = "Barcert2",
                    ValidFrom = DateTime.Parse("4.5.2018"),
                    ValidThrough = DateTime.Parse("8.10.2019")
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
