using api.Interfaces;
using api.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class CertificateRepository : ICertificateRepository
    {
        private readonly IMongoCollection<Certificate> _certificates;

        public CertificateRepository(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("mongoDbConnection"));
            var database = client.GetDatabase(configuration.GetValue<string>("mongoDbDatabase"));
            _certificates =
                database.GetCollection<Certificate>(configuration.GetValue<string>("certificateCollection"));
        }

        public async void AddCertificate(Certificate certificate) => await _certificates.InsertOneAsync(certificate);

        public async void DeleteCertificate(string thumbprint) => await _certificates.DeleteOneAsync(cert => cert.Thumbprint == thumbprint);

        public async Task<Certificate> GetCertificate(string thumbprint) => await _certificates.FindAsync<Certificate>(cert => cert.Thumbprint == thumbprint).Result.FirstOrDefaultAsync();

        public async Task<List<Certificate>> GetCertificates(string[] thumbprints)
        {
            var results = new List<Certificate>();

            foreach (string thumbprint in thumbprints)
            {
                var res = await GetCertificate(thumbprint);
                if (res != null) results.Add(res);
            }

            return results;
        }

        public async void UpdateCertificate(Certificate certificate) => await _certificates.ReplaceOneAsync(cert => cert.Thumbprint == certificate.Thumbprint, certificate);
    }
}
