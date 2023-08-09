using Api.Models;

namespace MedisoftDemo.Services
{
    public interface ILoginService
    {
        User Login(LoginModel model);
    }
}