using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using api.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace api.Services
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly IMongoCollection<Subscription> _subscriptions;

        public SubscriptionRepository(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("mongoDbConnection"));
            var database = client.GetDatabase(configuration.GetValue<string>("mongoDbDatabase"));
            _subscriptions =
                database.GetCollection<Subscription>(configuration.GetValue<string>("subscriptionCollection"));
        }

        public async void AddSubscription(Subscription subscription) => await _subscriptions.InsertOneAsync(subscription);

        public async void DeleteSubscription(string id) => await _subscriptions.DeleteOneAsync(sub => sub.Id == id);

        public async Task<List<Subscription>> GetAllSubscriptions() => await _subscriptions.FindAsync(sub => sub.Id != null).Result.ToListAsync();

        public async Task<Subscription> GetSubscription(string id) => await _subscriptions?.FindAsync(sub => sub.Id == id).Result.FirstOrDefaultAsync();

        public async Task<List<Subscription>> GetTenantSubscriptions(string tenantId) => await _subscriptions?.FindAsync(sub => sub.TenantId == tenantId).Result.ToListAsync();

        public async void UpdateSubscription(string id, Subscription subscription) => await _subscriptions?.ReplaceOneAsync(sub => sub.Id == id, subscription);
    }
}
