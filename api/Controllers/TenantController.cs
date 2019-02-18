using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Controllers;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ApiControllerBase
    {
        private readonly ITenantRepository _tenantRepository;

        public TenantController(ITenantRepository tenantRepository) => _tenantRepository = tenantRepository;

        [HttpGet("{id}")]
        public async Task<ActionResult<Tenant>> Get(string id) => Ok(await _tenantRepository?.GetTenant(id));

        [HttpPost]
        public void Post([FromBody] Tenant tenant) => _tenantRepository?.AddTenant(tenant);

        [HttpPut("{id}")]
        public void Put(string id,[FromBody] Tenant tenant) =>_tenantRepository?.UpdateTenant(id, tenant);

        [HttpDelete("{id}")]
        public void Delete(string id) => _tenantRepository?.DeleteTenant(id);
    }
}
