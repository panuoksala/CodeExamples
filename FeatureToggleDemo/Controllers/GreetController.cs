using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FeatureToggleDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetController : ControllerBase
    {
        private readonly ILogger<GreetController> _logger;
        private readonly IOptions<FeatureToggles> _featureToggles;

        public GreetController(ILogger<GreetController> logger, IOptions<FeatureToggles> featureToggles)
        {
            _logger = logger;
            _featureToggles = featureToggles;
        }

        [HttpGet]
        public string Greet()
        {
            if (_featureToggles.Value.NewGreetingFeature)
            {
                return "Welcome to the new greeting feature!";
            }
            else
            {
                return "Hello, welcome!";
            }
        }
    }
}