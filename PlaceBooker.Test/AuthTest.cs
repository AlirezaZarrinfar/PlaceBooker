using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace PlaceBooker.Test
{
    public class AuthTest
    {
        private HttpClient _client;
        public AuthTest()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = server.CreateClient();
        }
        [Fact]
        public async Task SignUp_Test()
        {
            var user = new User { Username = "Zarrinfar@gmail.com", Password = "1234" };
            var jsonUser = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/auth/signup" , content).Result.Content.ReadAsStringAsync();
            Assert.Equal("true",response);
        }

        [Fact]
        public void Login_Test()
        {
            var user = new User { Username = "Zarrinfar@gmail.com", Password = "1234" };
            var jsonUser = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
            var response =  _client.PostAsync("api/auth/login", content).Result;
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }
    }

    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
