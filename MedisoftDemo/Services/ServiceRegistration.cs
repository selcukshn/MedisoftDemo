using MedisoftDemo.Services.Request.Auth;
using Microsoft.AspNetCore.Components.Authorization;

namespace MedisoftDemo.Services
{
    public static class ServiceRegistration
    {
        public static void ServiceRegister(this IServiceCollection service)
        {
            service.AddTransient<IAuthRequestService, AuthRequestService>();
            service.AddScoped<AuthenticationStateProvider, AuthenticationService>();
        }
    }
}