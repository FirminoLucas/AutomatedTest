using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataTest.Models
{
    public class ResposeUser
    {
        public string Status { get; set; }
        public int Code { get; set; }
        public int Total { get; set; }
        public IEnumerable<User> Data { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public Guid uuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Ip { get; set; }
        public string MacAddress { get; set; }
        public string Website { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
    }
}
