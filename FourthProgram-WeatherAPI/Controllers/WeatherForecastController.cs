using Microsoft.AspNetCore.Mvc;

namespace FourthProgram_WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ApiContext _context;
        private readonly IExampleService service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApiContext context, IExampleService service)
        {
            _logger = logger;
            _context = context;
            this.service = service;
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
        public async Task<IActionResult> Insert([FromBody] string summary)
        {
            var weatherForecast = new WeatherForecast();
            weatherForecast.Summary = summary;
            _context.WeatherForecasts.Add(weatherForecast);


            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }

            var forecast = _context.WeatherForecasts.FirstOrDefault(_ => _.Id == id);
            if (forecast is null)
            {
                return NotFound();
            }

            _context.WeatherForecasts.Remove(forecast);
            try
            {
                throw new Exception("Failed to save something to database");
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Failed to delete weather forecast from database with id {id}.");
                return BadRequest();
            }


        }

    }
}