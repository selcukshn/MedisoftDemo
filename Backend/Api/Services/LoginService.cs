using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Api.Models;
using Microsoft.IdentityModel.Tokens;

namespace MedisoftDemo.Services
{
    public class LoginService : ILoginService
    {
        private readonly IConfiguration Configuration;

        public LoginService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public User Login(LoginModel model)
        {
            var user = Api.Models.User.Users.Find(e => e.Username == model.Username && e.Password == model.Password);

            if (user == null)
                throw new Exception("E-posta adresi veya şifre hatalı.");
            var claims = new Claim[]{
                new Claim("Id",user.Id.ToString()),
                new Claim("Username",user.Username),
            };
            user.Token = GenerateJWTToken(claims);

            return user;
        }
        private string GenerateJWTToken(IEnumerable<Claim> claims)
        {
            try
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("abcdefghijklmnoprstuvyz0123456789"));
                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expiry = DateTime.Now.AddDays(Convert.ToDouble(1));
                var token = new JwtSecurityToken("medisoft", "medisoft", claims, null, expiry, credentials);
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}