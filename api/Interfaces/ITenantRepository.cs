using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    public interface ITenantRepository
    {
        Task<Tenant> GetTenant(string id);
        void AddTenant(Tenant tenant);
        void UpdateTenant(string id, Tenant tenant);
        void DeleteTenant(string id);
    }
}
