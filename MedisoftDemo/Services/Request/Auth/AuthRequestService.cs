using System.Net.Http.Headers;
using System.Net.Http.Json;
using Blazored.LocalStorage;
using MedisoftDemo.Extensions;
using MedisoftDemo.Models;
using Microsoft.AspNetCore.Components.Authorization;

namespace MedisoftDemo.Services.Request.Auth
{
    public class AuthRequestService : IAuthRequestService
    {
        private readonly AuthenticationService AuthenticationState;
        private readonly HttpClient HttpClient;
        private readonly ILocalStorageService LocalStorage;
        public AuthRequestService(HttpClient client, AuthenticationStateProvider authenticationState, ILocalStorageService localStorage)
        {
            HttpClient = client;
            AuthenticationState = (authenticationState as AuthenticationService);
            LocalStorage = localStorage;
        }
        public async Task<User?> LoginAsync(UserLoginModel model)
        {
            var response = await HttpClient.PostAsync("/api/auth/login", JsonContent.Create(model));
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<User>();
                if (!string.IsNullOrEmpty(result?.Token))
                {
                    await LocalStorage.SetJWTAsync(result.Token);
                    AuthenticationState.NotifyLogin(result.Token);
                    HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", result.Token);
                    return result;
                }
            }
            return null;

        }
        public async Task LogoutAsync()
        {
            await LocalStorage.RemoveJWTAsync();
            AuthenticationState.NotifyLogout();
            HttpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}