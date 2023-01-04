using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static Points.Client.Pages.FetchData;

namespace Points.Client.Services
{
    public class WeatherForecastClient
    {
        private readonly HttpClient http;

        public WeatherForecastClient(HttpClient http)
        {
            this.http = http;
        }

        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            try
            {
                return await http.GetFromJsonAsync<WeatherForecast[]>(
                    "WeatherForecast");
            }
            catch

            {
                throw;
            }

            return new WeatherForecast[0];
        }
    }
}
