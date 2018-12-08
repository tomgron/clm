using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.Interfaces;
using api.Models;

namespace api.tests
{
    public class FakeCertificateRepository : ICertificateRepository
    {

        private List<Certificate> _repository;

        public FakeCertificateRepository() => _repository = new List<Certificate>();

        public Certificate GetCertificate(string thumbprint) => _repository.First(i => string.Compare(i.Thumbprint, thumbprint, StringComparison.InvariantCultureIgnoreCase) == 0);

        public List<Certificate> GetCertificates(string[] thumbprints)
        {
            List<Certificate> retValues = new List<Certificate>();
            foreach (string item in thumbprints)
            {
                try
                {
                    var certificate = _repository.First(i => string.Compare(i.Thumbprint, item, StringComparison.InvariantCultureIgnoreCase) == 0);
                    if (certificate != null) retValues.Add(certificate);
                }
                catch (Exception ex)
                {
                    
                }
            }

            return retValues;
        }

        public Certificate AddCertificate(Certificate certificate)
        {
            _repository.Add(certificate);
            return certificate;
        }

        public Certificate UpdateCertificate(Certificate certificate)
        {
            for (int i = 0; i < _repository.Count; i++)
            {
                if (_repository[i].Thumbprint == certificate.Thumbprint) _repository[i] = certificate;
            }

            return certificate;
        }

        public bool DeleteCertificate(string thumbprint) =>_repository.Remove(_repository.First(i => i.Thumbprint == thumbprint));
    }
}
