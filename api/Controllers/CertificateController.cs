using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ApiControllerBase
    {
        private ICertificateRepository _certificateRepository;

        public CertificateController(ICertificateRepository certificateRepository) => _certificateRepository = certificateRepository;

        /// <summary>
        /// Gets multiple certificates as an array
        /// </summary>
        /// <param name="thumbprints">string array of thumbprints</param>
        /// <returns>array of certificates</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Certificate>>> Get(string[] thumbprints) => Ok(await _certificateRepository?.GetCertificates(thumbprints));

        /// <summary>
        /// Gets single certificate based on thumbprint
        /// </summary>
        /// <param name="thumbprint">PKCS thumbprint</param>
        /// <returns>Single certificate object</returns>
        [HttpGet("{thumbprint}")]
        public async Task<ActionResult<Certificate>> Get(string thumbprint) => Ok(await _certificateRepository?.GetCertificate(thumbprint));

        [HttpPost]
        public void Post([FromBody] Certificate certificate) => _certificateRepository?.AddCertificate(certificate);

        [HttpPut("{thumbprint}")]
        public void Put([FromBody] Certificate certificate) => _certificateRepository?.UpdateCertificate(certificate);

        [HttpDelete("{thumbprint}")]
        public void Delete(string thumbprint) => _certificateRepository?.DeleteCertificate(thumbprint);
    }
}
