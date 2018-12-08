using System;
using System.Collections.Generic;
using api.Models;
using Xunit;

namespace api.tests
{
    public class CertificateControllerTests : ControllerFixtureBase
    {
        [Fact]
        public void TestAddCertificate()
        {
            var cert = new Certificate
            {
                Thumbprint = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid(),
                Name = Guid.NewGuid().ToString(),
                ValidFrom = DateTime.Today,
                ValidThrough = DateTime.Today.AddYears(1)
            };

            var created = _repository.AddCertificate(cert);

            Assert.Equal(cert.Thumbprint, created.Thumbprint);
            Assert.Equal(cert.Id, created.Id);
            Assert.Equal(cert.Name, created.Name);
            Assert.Equal(cert.ValidFrom, created.ValidFrom);
            Assert.Equal(cert.ValidThrough, cert.ValidThrough);
        }

        [Fact]
        void TestGetCertificate()
        {
            Certificate cert = new Certificate
            {
                Thumbprint = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid(),
                Name = Guid.NewGuid().ToString(),
                ValidFrom = DateTime.Today,
                ValidThrough = DateTime.Today.AddYears(1)
            };

            var created = _repository.AddCertificate(cert);

            var retrieved = _repository.GetCertificate(created.Thumbprint);

            Assert.Equal(retrieved.Thumbprint, created.Thumbprint);
            Assert.Equal(retrieved.Id, created.Id);
            Assert.Equal(retrieved.Name, created.Name);
            Assert.Equal(retrieved.ValidFrom, created.ValidFrom);
            Assert.Equal(retrieved.ValidThrough, cert.ValidThrough);
        }

        [Fact]
        void TestUpdateCertificate()
        {
            Certificate cert = new Certificate
            {
                Thumbprint = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid(),
                Name = Guid.NewGuid().ToString(),
                ValidFrom = DateTime.Today,
                ValidThrough = DateTime.Today.AddYears(1)
            };

            var created = _repository.AddCertificate(cert);

            cert.ValidThrough = DateTime.Today.AddMonths(3);

            var updated = _repository.UpdateCertificate(cert);

            var retrieved = _repository.GetCertificate(cert.Thumbprint);

            Assert.Equal(updated, retrieved);
            Assert.Equal(retrieved, cert);
        }

        [Fact]
        void TestDeleteCertificate()
        {
            Certificate cert = new Certificate
            {
                Thumbprint = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid(),
                Name = Guid.NewGuid().ToString(),
                ValidFrom = DateTime.Today,
                ValidThrough = DateTime.Today.AddYears(1)
            };

            var created = _repository.AddCertificate(cert);

            _repository.DeleteCertificate(created.Thumbprint);

            List<string> thumbprintList = new List<string>();
            thumbprintList.Add(created.Thumbprint);

            var deleted = _repository.GetCertificates(thumbprintList.ToArray());

            Assert.Empty(deleted);
        }

        [Fact]
        void TestGetCertificates()
        {
            Certificate cert1 = new Certificate
            {
                Thumbprint = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid(),
                Name = Guid.NewGuid().ToString(),
                ValidFrom = DateTime.Today,
                ValidThrough = DateTime.Today.AddYears(1)
            };

            var created1 = _repository.AddCertificate(cert1);

            Certificate cert2 = new Certificate
            {
                Thumbprint = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid(),
                Name = Guid.NewGuid().ToString(),
                ValidFrom = DateTime.Today,
                ValidThrough = DateTime.Today.AddYears(2)
            };

            var created2 = _repository.AddCertificate(cert2);
            List<string> thumbprintList = new List<string>();
            thumbprintList.Add(created1.Thumbprint);
            thumbprintList.Add(created2.Thumbprint);

            var retrieved = _repository.GetCertificates(thumbprintList.ToArray());

            Assert.Equal(2,retrieved.Count);
        }
    }
}
