using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;

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
