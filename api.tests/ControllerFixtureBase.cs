using api.Interfaces;
using System;

namespace api.tests
{
    public class ControllerFixtureBase
    {
        protected ICertificateRepository _repository;
        public ControllerFixtureBase() => _repository = new FakeCertificateRepository();
    }
}
