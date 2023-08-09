using Blazored.LocalStorage;

namespace MedisoftDemo.Extensions
{
    public static class LocalStorageExtension
    {
        public static async Task<string> GetJWTAsync(this ILocalStorageService storage)
        {
            return await storage.GetItemAsStringAsync("token");
        }
        public static async Task SetJWTAsync(this ILocalStorageService storage, string token)
        {
            await storage.SetItemAsStringAsync("token", token);
        }
        public static async Task RemoveJWTAsync(this ILocalStorageService storage)
        {
            await storage.RemoveItemAsync("token");
        }
    }
}