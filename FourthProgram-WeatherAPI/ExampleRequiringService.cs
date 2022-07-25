namespace FourthProgram_WeatherAPI
{
    public class ExampleRequiringService
    {
        private readonly IExampleService _exampleService;
        private readonly ApiContext _context;

        public ExampleRequiringService(IExampleService exampleService, ApiContext context)
        {
            _exampleService = exampleService;
            _context = context;
        }

        public void IncreaseAllTemperatures()
        {
            var forecasts = _exampleService.GetForecasts();
            foreach(var forecast in forecasts)
            {
                forecast.TemperatureC += 10;
            }

            _context.SaveChanges();
        }

    }
}
