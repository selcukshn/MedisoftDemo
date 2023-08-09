using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace MedisoftDemo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
    }
}