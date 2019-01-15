﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        // GET: api/Certificate
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _certificateRepository?.GetCertificate("foofoo");
            return new string[] { "value1", "value2" };
        }

        // GET: api/Certificate/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Certificate
        [HttpPost]
        public async Task<ActionResult<Certificate>> Post([FromBody] Certificate certificate)
        {
            return await _certificateRepository?.AddCertificate(certificate);
        }

        // PUT: api/Certificate/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{thumbprint}")]
        public async Task<ActionResult<bool>> Delete(string thumbprint)
        {
            return await _certificateRepository.DeleteCertificate(thumbprint);
        }
    }
}
