namespace FourthProgram_WeatherAPI
{
    public class ExampleRequiringService
    {
        private readonly IExampleService _exampleService;

        public ExampleRequiringService(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

    }
}
