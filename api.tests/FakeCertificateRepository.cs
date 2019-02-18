using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.tests
{
    public class FakeCertificateRepository : ICertificateRepository
    {

        private List<Certificate> _repository;

        public FakeCertificateRepository() => _repository = new List<Certificate>();

        public async Task<ActionResult<Certificate>> GetCertificate(string thumbprint)
        {
            return await Task.Run(() =>
            {
                return _repository.First(i =>
                    string.Compare(i.Thumbprint, thumbprint, StringComparison.InvariantCultureIgnoreCase) == 0);
            });
        }

        public async Task<ActionResult<List<Certificate>>> GetCertificates(string[] thumbprints)
        {

            var itemsToReturn = Task.Run(() =>
            {
                List<Certificate> retValues = new List<Certificate>();

                foreach (string item in thumbprints)
                {
                    try
                    {
                        var certificate = _repository.First(i => string.Compare(i.Thumbprint, item, StringComparison.InvariantCultureIgnoreCase) == 0);
                        if (certificate != null) retValues.Add(certificate);
                    }
                    catch
                    {

                    }
                }

                return retValues;
            });

            return await itemsToReturn;
        }

        public async Task<ActionResult<Certificate>> AddCertificate(Certificate certificate)
        {
            var cert = Task.Run(() =>
            {
                _repository.Add(certificate);
                return certificate;
            });

            return await cert;
        }

        public async Task<ActionResult<Certificate>> UpdateCertificate(Certificate certificate)
        {
            var retVal = Task.Run(() =>
            {
                for (int i = 0; i < _repository.Count; i++)
                {
                    if (_repository[i].Thumbprint == certificate.Thumbprint) _repository[i] = certificate;
                }

                return certificate;
            });

            return await retVal;
        }

        public async Task<ActionResult<bool>> DeleteCertificate(string thumbprint)
        {
            var result = Task.Run(() =>
            {
                return _repository.Remove(_repository.First(i => i.Thumbprint == thumbprint));
            });

            return await result;
        }
    }
}
