using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace EventEaseApp.Services
{
    public class SessionStateService
    {
        private readonly IJSRuntime jsRuntime;

        public SessionStateService(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async Task SetSessionStateAsync(string key, string value)
        {
            await jsRuntime.InvokeVoidAsync("sessionStorage.setItem", key, value);
        }

        public async Task<string> GetSessionStateAsync(string key)
        {
            return await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", key);
        }

        public async Task RemoveSessionStateAsync(string key)
        {
            await jsRuntime.InvokeVoidAsync("sessionStorage.removeItem", key);
        }
    }
}
