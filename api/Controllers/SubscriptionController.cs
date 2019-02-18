using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ApiControllerBase
    {
        private ISubscriptionRepository _subscriptionRepository;

        public SubscriptionController(ISubscriptionRepository subscriptionRepository) => _subscriptionRepository = subscriptionRepository;

        /// <summary>
        /// Get all subscriptions in repository. WARNING : this gets all tenants all subscriptions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subscription>>> Get() => await _subscriptionRepository?.GetAllSubscriptions();

        /// <summary>
        /// Get single subscription
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Subscription>> Get(string id) => await _subscriptionRepository?.GetSubscription(id);

        [HttpPost]
        public void Post([FromBody] Subscription subscription) => _subscriptionRepository?.AddSubscription(subscription);

        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Subscription subscription) => _subscriptionRepository?.UpdateSubscription(id, subscription);

        [HttpDelete("{id}")]
        public void Delete(string id) => _subscriptionRepository?.DeleteSubscription(id);
    }
}
