using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RapidOrder.ProducerAPI.Models;

namespace RapidOrder.ProducerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<Product> GetProducts()
        {
            return new List<Product>();
        }
    }
}
