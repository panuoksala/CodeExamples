using Microsoft.AspNetCore.Mvc;

namespace FourthProgram_WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ApiContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApiContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _context.WeatherForecasts.ToList();
        }


        [HttpGet("{amount:int}")]
        public IEnumerable<WeatherForecast> Get(int amount)
        {
            return _context.WeatherForecasts.Take(amount);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody]string summary)
        {
            _context.WeatherForecasts.Add(new WeatherForecast() { Summary = summary });
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}