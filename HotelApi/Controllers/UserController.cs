using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public IEnumerable<User> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new User
            {
                FullName = "",
                Email = "",
                Password = ""

            })
            .ToArray();
        }
        [HttpPost]
        public void Post([FromBody] User r)
        {
        }
        [HttpPut]
        public void Put([FromBody] User r) 
        { 
        }
        [HttpDelete("{id}")]
        public void Delete(Int32 Id)
        {
        }
    }
}

