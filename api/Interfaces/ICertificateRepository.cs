using api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Interfaces
{
    public interface ICertificateRepository
    {
        Task<Certificate> GetCertificate(string thumbprint);
        Task<List<Certificate>> GetCertificates(string[] thumbprints);
        void AddCertificate(Certificate certificate);
        void UpdateCertificate(Certificate certificate);
        void DeleteCertificate(string thumbprint);
    }
}
