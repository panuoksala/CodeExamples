using Microsoft.AspNetCore.Mvc;

namespace FourthProgram_WeatherAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RainDetectorController : Controller
    {
        private readonly ApiContext _context;

        public RainDetectorController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public IActionResult GetDetection(string city)
        {
            return Ok(_context.RainDetections.Where(_ => _.City == city).FirstOrDefault());
        }

        [HttpGet("maxcity")]
        public IActionResult GetMaxCity()
        {
            return Ok(_context.RainDetections.MaxBy(_ => _.Amount));
        }

        [HttpPost]
        public IActionResult Insert(RainDetection dto)
        {
            _context.RainDetections.Add(dto);
            _context.SaveChanges();
            return Ok();
        }
    }
}
