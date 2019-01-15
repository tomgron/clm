using System;
using System.Collections.Generic;
using api.Models;
using Xunit;

namespace api.tests
{
    public class CertificateControllerTests : ControllerFixtureBase
    {
        [Fact]
        async void TestAddCertificate()
        {
            var cert = new Certificate
            {
                Thumbprint = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid(),
                Name = Guid.NewGuid().ToString(),
                ValidFrom = DateTime.Today,
                ValidThrough = DateTime.Today.AddYears(1)
            };

            var created = await _repository.AddCertificate(cert).ConfigureAwait(true);

            Assert.Equal(cert.Thumbprint, created.Value.Thumbprint);
            Assert.Equal(cert.Id, created.Value.Id);
            Assert.Equal(cert.Name, created.Value.Name);
            Assert.Equal(cert.ValidFrom, created.Value.ValidFrom);
            Assert.Equal(cert.ValidThrough, cert.ValidThrough);
        }

        [Fact]
        async void TestGetCertificate()
        {
            Certificate cert = new Certificate
            {
                Thumbprint = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid(),
                Name = Guid.NewGuid().ToString(),
                ValidFrom = DateTime.Today,
                ValidThrough = DateTime.Today.AddYears(1)
            };

            var created = await _repository.AddCertificate(cert).ConfigureAwait(true);
            
            var retrieved = await _repository.GetCertificate(created.Value.Thumbprint);

            Assert.Equal(retrieved.Value.Thumbprint, created.Value.Thumbprint);
            Assert.Equal(retrieved.Value.Id, created.Value.Id);
            Assert.Equal(retrieved.Value.Name, created.Value.Name);
            Assert.Equal(retrieved.Value.ValidFrom, created.Value.ValidFrom);
            Assert.Equal(retrieved.Value.ValidThrough, cert.ValidThrough);
        }

        [Fact]
        async void TestUpdateCertificate()
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

            var updated = await _repository.UpdateCertificate(cert).ConfigureAwait(true);

            var retrieved = await _repository.GetCertificate(cert.Thumbprint).ConfigureAwait(true);

            Assert.Equal(updated.Value, retrieved.Value);
            Assert.Equal(retrieved.Value, cert);
        }

        [Fact]
        async void TestDeleteCertificate()
        {
            Certificate cert = new Certificate
            {
                Thumbprint = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid(),
                Name = Guid.NewGuid().ToString(),
                ValidFrom = DateTime.Today,
                ValidThrough = DateTime.Today.AddYears(1)
            };

            var created = await _repository.AddCertificate(cert).ConfigureAwait(true);

            await _repository.DeleteCertificate(created.Value.Thumbprint);

            List<string> thumbprintList = new List<string>();
            thumbprintList.Add(created.Value.Thumbprint);

            var deleted = await _repository.GetCertificates(thumbprintList.ToArray());

            Assert.Empty(deleted.Value);
        }

        [Fact]
        async void TestGetCertificates()
        {
            Certificate cert1 = new Certificate
            {
                Thumbprint = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid(),
                Name = Guid.NewGuid().ToString(),
                ValidFrom = DateTime.Today,
                ValidThrough = DateTime.Today.AddYears(1)
            };

            var created1 = await _repository.AddCertificate(cert1);

            Certificate cert2 = new Certificate
            {
                Thumbprint = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid(),
                Name = Guid.NewGuid().ToString(),
                ValidFrom = DateTime.Today,
                ValidThrough = DateTime.Today.AddYears(2)
            };

            var created2 = await _repository.AddCertificate(cert2).ConfigureAwait(true);
            List<string> thumbprintList = new List<string>();
            thumbprintList.Add(created1.Value.Thumbprint);
            thumbprintList.Add(created2.Value.Thumbprint);

            var retrieved = await _repository.GetCertificates(thumbprintList.ToArray());

            Assert.Equal(2,retrieved.Value.Count);
        }
    }
}
