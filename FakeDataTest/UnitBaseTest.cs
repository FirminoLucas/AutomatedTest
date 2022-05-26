using NUnit.Framework;
using RestSharp;

namespace FakeDataTest
{
    public class UnitBaseTest
    {
        protected RestClient _client;
        private const string _UrlBase = "https://fakerapi.it/api/v1"; 
        [SetUp]
        public virtual void Setup()
        {
            _client = new RestClient(_UrlBase);
        }

    }
}