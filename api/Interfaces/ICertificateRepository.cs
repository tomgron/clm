using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Interfaces
{
    public interface ICertificateRepository
    {
        Task<ActionResult<Certificate>> GetCertificate(string thumbprint);
        Task<ActionResult<List<Certificate>>> GetCertificates(string[] thumbprints);
        Task<ActionResult<Certificate>> AddCertificate(Certificate certificate);
        Task<ActionResult<Certificate>> UpdateCertificate(Certificate certificate);
        Task<ActionResult<bool>> DeleteCertificate(string thumbprint);
    }
}
