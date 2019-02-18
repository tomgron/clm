using System;
using System.Collections.Generic;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ApiControllerBase
    {
        private readonly ITenantRepository _tenantRepository;
        private readonly ISubscriptionRepository _subscriptionRepository;

        public TenantController(
            ITenantRepository tenantRepository,
            ISubscriptionRepository subscriptionRepository
            )
        {
            _tenantRepository = tenantRepository;
            _subscriptionRepository = subscriptionRepository;
        }

        /// <summary>
        /// Gets single tenant based on id
        /// </summary>
        /// <param name="id">Tenant id</param>
        /// <returns>Tenant object</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Tenant>> Get(string id) => Ok(await _tenantRepository?.GetTenant(id));

        [HttpPost]
        public void Post([FromBody] Tenant tenant) => _tenantRepository?.AddTenant(tenant);

        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Tenant tenant) => _tenantRepository?.UpdateTenant(id, tenant);

        [HttpDelete("{id}")]
        public void Delete(string id) => _tenantRepository?.DeleteTenant(id);

        /// <summary>
        /// Gets all chosen tenant's subscriptions
        /// </summary>
        /// <param name="tenantid">24 characted hex objectid</param>
        /// <returns>array of subscriptions for this tenant</returns>
        [HttpGet("{tenantid}/subscriptions")]
        public async Task<ActionResult<IEnumerable<Subscription>>> GetTenantSubscriptions(string tenantid) => await _subscriptionRepository.GetTenantSubscriptions(tenantid);
    }
}
