
using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        static List<Order> orders = new List<Order>();
        public OrderController(ILogger<OrderController> logger)
        {
            
            _logger = logger;
        }

        [HttpGet(Name = "GetOrder")]
        public IEnumerable<Order> Get()
        {
            return orders;
        }
     
        [HttpPost]
        public void Post([FromBody] Order r)
        {
            orders.Add(r);
        }
        [HttpPut]
        public void Put(int id, [FromBody] Order r)
        {
            orders[id] = r;
        }
        [HttpDelete("{id}")]
        public void Delete(Int32 Id)
        {
           orders.RemoveAt(Id);
        }
    }   
}

