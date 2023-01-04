using Points.Shared.Models;
using System.Text.Json;
using Ardalis.SmartEnum.SystemTextJson;

namespace Points.Client.Services
{
    public interface IModuleService
    {
        Task<IEnumerable<Module>> GetModulesAsync();
    }

    public class ModuleService : IModuleService
    {
        private readonly HttpClient _httpClient;

        public ModuleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Module>> GetModulesAsync()
        {
            var response = await _httpClient.GetAsync($"/api/modules");

            response.EnsureSuccessStatusCode();


            await using var responseStream = await response.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            var crap = await JsonSerializer.DeserializeAsync<IEnumerable<Module>>(responseStream, options);
            Console.WriteLine(crap);
            return crap;

        }
    }
}
