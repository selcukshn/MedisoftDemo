using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedisoftDemo.Models;

namespace MedisoftDemo.Services.Request.Auth
{
    public interface IAuthRequestService
    {
        Task<User> LoginAsync(UserLoginModel model);
    }
}