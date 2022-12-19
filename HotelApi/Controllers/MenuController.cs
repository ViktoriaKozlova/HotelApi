using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly ILogger<MenuController> _logger;

        public MenuController(ILogger<MenuController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMenu")]
        public IEnumerable<Menu> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Menu
            {
                name = "",
                description ="",
                price = 1

            })
            .ToArray();
        }
    }
}

