using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly ILogger<RoomController> _logger;

        public RoomController(ILogger<RoomController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRoom")]
        public IEnumerable<Room> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Room
            {
                categori = "All", 
                price = 150, 
                number= 1,
                count = 2
               
    })
            .ToArray(); 
        }
        [HttpPost]
        public void Post([FromBody] Room r)
        {
        }
        [HttpPut]
        public void Put([FromBody] Room r)
        {
        }
        [HttpDelete("{id}")]
        public void Delete(Int32 Id)
        {
        }
    }
}

