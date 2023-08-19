using Microsoft.AspNetCore.SignalR;

namespace BtkAkademi.Web.Hubs
{
    public class OrderHub : Hub
    {

        public override Task OnConnectedAsync()
        {

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
        public async Task WriteTyping(string user, bool isTyping)
        {
            await Clients.Others.SendAsync("WriteTyping", user, isTyping);
        }
        public async Task SendTypingNotification(bool isTyping)
        {
            await Clients.Others.SendAsync("ReceiveTypingNotification", isTyping);
        }
    }
}
