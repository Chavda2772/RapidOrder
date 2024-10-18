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
        private readonly Producer _producer;

        public OrderController(Producer producer)
        {
            _producer = producer;
        }

        [HttpPost]
        public IActionResult AddOrder()
        {
            _producer.SendMessage("Hello");
            return Ok("Messages Sended.");
        }
    }
}
