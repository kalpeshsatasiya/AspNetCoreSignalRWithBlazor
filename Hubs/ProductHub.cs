using Microsoft.AspNetCore.SignalR;

namespace BlazorAppDemo.Hubs
{
    public class ProductHub : Hub
    {
        public async Task SendProduct(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveProduct", user, message);
        }
    }
}
