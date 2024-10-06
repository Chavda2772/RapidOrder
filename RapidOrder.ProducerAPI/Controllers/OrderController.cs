using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RapidOrder.ProducerAPI.Models;
using RapidOrder.Common.RabbitMQ;

namespace RapidOrder.ProducerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly Producer _messageProducer;

        public OrderController()
        {
            _messageProducer = new Producer();
        }

        [HttpPost]
        public IActionResult AddOrder()
        {
            _messageProducer.SendMessage("Hello Mahesh Chavda");
            return Ok("Message Sended.");
        }
    }
}
