
using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
      
        public OrderController(ILogger<OrderController> logger)
        {
            
            _logger = logger;
        }

        [HttpGet(Name = "GetOrder")]
        public IEnumerable<Order> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Order
            {
                _user = new Models.User(),
                _room = new Models.Room(),
                _spa = new Models.Spa(),
                _menu = new Models.Menu()

            })
          .ToArray();
        }
        [HttpPost]
        public void Post([FromBody] Order r)
        {
        }
        [HttpPut]
        public void Put([FromBody] Order r)
        {
        }
        [HttpDelete("{id}")]
        public void Delete(Int32 Id)
        {
        }
    }
    
}

