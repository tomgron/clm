using System;
using System.Collections.Generic;
using System.Text;
using api.Interfaces;

namespace api.tests
{
    public class ControllerFixtureBase
    {
        protected ICertificateRepository _repository;
        public ControllerFixtureBase() => _repository = new FakeCertificateRepository();
    }
}
