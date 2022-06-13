using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ThirdProgram_WeatherAPI_Extended.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RainDetectorController : ControllerBase
    {
        private static List<RainDetection> Detections = new List<RainDetection>
        {
            new RainDetection { Amount = 12.5M, IsRaining = true, City = "Turku" },
            new RainDetection { Amount = 1.0M, IsRaining = true, City = "Helsinki" },
            new RainDetection { Amount = 0, IsRaining = false, City = "Tampere" }
        };

        [HttpGet()]
        public IActionResult GetDetection(string city)
        {
            if(Detections.Any(_ => string.Equals(_.City, city)))
            {
                return Ok(Detections.Single(_ => string.Equals(_.City, city)));
            }
            else
            {
                return BadRequest();
            }            
        }

        [HttpGet("maxcity")]
        public IActionResult GetMaxCity()
        {
            return Ok(Detections.MaxBy(_ => _.Amount));
        }

        [HttpPost]
        public IActionResult Insert(RainDetection dto)
        {
            Detections.Add(dto);
            return Ok();
        }
    }
}
