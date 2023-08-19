using BtkAkademi.Service.ChatAPI.Hubs;
using BtkAkademi.Service.ChatAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace BtkAkademi.Service.ChatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {

        private readonly IHubContext<OrderHub> _orderHub;
        public OrderController(IHubContext<OrderHub> orderHub)
        {

            _orderHub = orderHub;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("[Controller]")]
        [HttpPost]
        public IActionResult Order([FromBody] Order order, bool? isTyping)
        {
            //same bussines rules
            _orderHub.Clients.All.SendAsync("lastOrder", order);
            //_orderHub.Clients.All.SendAsync("deneme", "typing");
            //_orderHub.Clients.All.SendAsync("ReceiveTypingNotification", isTyping);

            return Accepted();
        }

        [HttpPost]
        public IActionResult SendTypingNotification(bool isTyping)
        {
            _orderHub.Clients.All.SendAsync("ReceiveTypingNotification", isTyping);
            return Ok();
        }
    }
}
