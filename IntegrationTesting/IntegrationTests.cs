using Xunit;
using Flurl;
using Flurl.Http;
using ThirdProgram_WeatherAPI;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace IntegrationTesting
{
    public class IntegrationTests
    {
        [Fact]
        public async Task Get_WeatherAPI_ReturnsWeatherInformation()
        {
            var apiUrl = @"https://localhost:7020";
            var url = apiUrl.AppendPathSegment("weatherforecast");

            var result = await url.GetJsonAsync<WeatherForecast[]>();

            Assert.NotNull(result);
            Assert.NotEmpty(result);

            Assert.True(result.First().Date > DateTime.Now);

        }

        [Fact]
        public async Task Post_WeatherAPI_InsertsNewForecast()
        {
            var apiUrl = @"https://localhost:7020";
            var url = apiUrl.AppendPathSegment("weatherforecast");

            var result = await Assert.ThrowsAsync<FlurlHttpException>(async () =>
            {
                await url.PostJsonAsync(null);
            });

            Assert.Equal(400, result.StatusCode);
        }
    }
}