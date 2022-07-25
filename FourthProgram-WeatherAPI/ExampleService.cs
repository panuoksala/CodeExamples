namespace FourthProgram_WeatherAPI
{
    /// <summary>
    /// This class is required in ExampleRequiringService class
    /// </summary>
    public class ExampleService : IExampleService
    {
        private readonly ApiContext _context;

        public ExampleService(ApiContext context)
        {
            _context = context;
        }

        public List<WeatherForecast> GetForecasts()
        {
            return _context.WeatherForecasts.ToList();
        }
    }
}
