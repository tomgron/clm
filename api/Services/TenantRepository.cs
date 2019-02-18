using api.Interfaces;
using api.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class TenantRepository : ITenantRepository
    {
        private readonly IMongoCollection<Tenant> _tenants;

        public TenantRepository(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("mongoDbConnection"));
            var database = client.GetDatabase(configuration.GetValue<string>("mongoDbDatabase"));
            _tenants =
                database.GetCollection<Tenant>(configuration.GetValue<string>("tenantCollection"));
        }

        public async void AddTenant(Tenant tenant) => await _tenants?.InsertOneAsync(tenant);

        public async void DeleteTenant(string id) => await _tenants?.DeleteOneAsync(ten => ten.Id == id);

        public async Task<Tenant> GetTenant(string id) => await _tenants?.FindAsync(ten => ten.Id == id).Result.FirstOrDefaultAsync();

        public async void UpdateTenant(string id, Tenant tenant) => await _tenants?.ReplaceOneAsync(ten => ten.Id == id, tenant);
    }
}
