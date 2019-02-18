using api.Models;
using System.Threading.Tasks;

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
