using FakeDataTest.Models;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataTest
{
    public class UserTest : UnitBaseTest
    {
        [Test]
        public async Task GetDataUser_CheckStatusCode_ShouldBeHttpOK()
        {
            RestRequest request = new RestRequest("users", Method.Get)
                .AddQueryParameter("_quantity", 10);

            var response = await _client.ExecuteAsync<ResposeUser>(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }


        [Test]
        public async Task GetDataUser_Has50DataLength()
        {
            RestRequest request = new RestRequest("users", Method.Get)
                .AddQueryParameter("_quantity", 50);

            var response = await _client.ExecuteAsync<ResposeUser>(request);

            Assert.That(response.Data?.Data?.Count(), Is.EqualTo(50));
        }


        [Test]
        public async Task GetDataUser_CheckStatusCode_ShouldBeHttpNotFound()
        {
            RestRequest request = new RestRequest("user", Method.Get)
                .AddQueryParameter("_quantity", 0);

            var response = await _client.ExecuteAsync<ResposeUser>(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
        }

    }
}
