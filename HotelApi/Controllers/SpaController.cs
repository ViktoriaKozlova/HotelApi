using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpaController : ControllerBase
    {
        private readonly ILogger<SpaController> _logger;

        public SpaController(ILogger<SpaController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSpa")]
        public IEnumerable<Spa> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Spa
            {
                name = "",
                price = 1

            })
            .ToArray();
        }
    }
}

