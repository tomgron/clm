using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    public interface ICertificateRepository
    {
        Certificate GetCertificate(string thumbprint);
        List<Certificate> GetCertificates(string[] thumbprints);
        Certificate AddCertificate(Certificate certificate);
        Certificate UpdateCertificate(Certificate certificate);
        bool DeleteCertificate(string thumbprint);
    }
}
