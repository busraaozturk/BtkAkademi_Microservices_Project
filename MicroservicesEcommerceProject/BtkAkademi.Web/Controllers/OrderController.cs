using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using BtkAkademi.Web.Hubs;
using BtkAkademi.Web.Models;

namespace BtkAkademi.Web.Controllers
{
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
            _orderHub.Clients.All.SendAsync("lastOrder", order);
            
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
