using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ApiControllerBase
    {
        private ICertificateRepository _certificateRepository;
        public CertificateController(ICertificateRepository certificateRepository)
        {
            _certificateRepository = certificateRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Certificate>>> Get(string[] thumbprints) => Ok(await _certificateRepository?.GetCertificates(thumbprints));

        [HttpGet("{thumbprint}", Name = "Get")]
        public async Task<ActionResult<Certificate>> Get(string thumbprint) => Ok(await _certificateRepository?.GetCertificate(thumbprint));

        [HttpPost]
        public ActionResult Post([FromBody] Certificate certificate)
        {
            _certificateRepository?.AddCertificate(certificate);
            return Ok();
        }

        [HttpPut("{thumbprint}")]
        public ActionResult Put([FromBody] Certificate certificate)
        {
            _certificateRepository?.UpdateCertificate(certificate);
            return Ok();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{thumbprint}")]
        public ActionResult Delete(string thumbprint)
        {
            _certificateRepository?.DeleteCertificate(thumbprint);
            return Ok();
        }
    }
}
