using api.Interfaces;
using api.Models;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Documents.Linq;
using Microsoft.EntityFrameworkCore;

namespace api.Services
{
    public class CertificateRepository : ICertificateRepository
    {
        private readonly IConfiguration _configuration;
        private readonly DocumentClient _client;
        private readonly DocumentCollection _documentCollection;
        private readonly Database _database;
        public CertificateRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            string endpointUri = configuration["CertificateRepositoryUri"];
            SecureString authKey = new SecureString();

            foreach (char c in configuration["CertificateRepositoryAuthKey"])
            {
                authKey.AppendChar(c);
            }

            _client = new DocumentClient(new Uri(endpointUri), authKey);

            _database = GetOrCreateDatabaseAsync(configuration["CertificateRepositoryDatabase"]).Result;

            _documentCollection =
                GetOrCreateDocumentCollectionAsync(configuration["CertificateRepositoryCollection"], _database).Result;
        }

        private async Task<Database> GetOrCreateDatabaseAsync(string id)
        {
            IEnumerable<Database> query = from db in _client.CreateDatabaseQuery()
                where db.Id == id
                select db;


            Database database = query.FirstOrDefault();
            if (database == null)
            {
                // Create the database.
                database = await _client.CreateDatabaseAsync(new Database { Id = id });
            }

            return database;

        }

        private async Task<DocumentCollection> GetOrCreateDocumentCollectionAsync(string id, Database db)
        {
            IEnumerable<DocumentCollection> query = from coll in _client.CreateDocumentCollectionQuery(db.SelfLink)
                where coll.Id == id
                select coll;

            DocumentCollection collection = query.FirstOrDefault();
            if (collection == null)
            {
                collection = await _client.CreateDocumentCollectionAsync(
                    new Uri(_configuration["CertificateRepositoryUri"]), new DocumentCollection() { Id = id});
            }

            return collection;
        }

        public async Task<ActionResult<Certificate>> AddCertificate(Certificate certificate)
        {
            ResourceResponse<Document> result = await _client.CreateDocumentAsync(_documentCollection.SelfLink, certificate);
            return _client.ReadDocumentAsync<Certificate>(result.Resource.SelfLink).Result.Document; // Try to return just created certificate for matching (TODO: creates maybe unnecessary query)
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
