using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class CertificateRepository : ICertificateRepository
    {

        public CertificateRepository(IConfiguration configuration)
        {
        }

        public async Task<ActionResult<Certificate>> AddCertificate(Certificate certificate)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<bool>> DeleteCertificate(string thumbprint)
        {

            throw new NotImplementedException();
        }

        public async Task<ActionResult<Certificate>> GetCertificate(string thumbprint)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<List<Certificate>>> GetCertificates(string[] thumbprints)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<Certificate>> UpdateCertificate(Certificate certificate)
        {
            throw new NotImplementedException();
        }
    }
}
