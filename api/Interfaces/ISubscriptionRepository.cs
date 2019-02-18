using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    public interface ISubscriptionRepository
    {
        Task<Subscription> GetSubscription(string id);
        Task<List<Subscription>> GetAllSubscriptions();
        Task<List<Subscription>> GetTenantSubscriptions(string tenantId);
        void AddSubscription(Subscription subscription);
        void UpdateSubscription(string id, Subscription subscription);
        void DeleteSubscription(string id);
    }
}
