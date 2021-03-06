using RunSomeCode.Piston.Models;
using System.Net.Http.Json;

namespace RunSomeCode.Piston
{
    public interface IPistonService
    {
        public Task<PistonOutput> RunCode(PistonInput pistonInput);
        public Task<PistonRuntime[]> GetRuntimes();
    }
    public class PistonService : IPistonService
    {
        private readonly HttpClient _httpClient;
        public PistonService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<PistonRuntime[]> GetRuntimes()
        {
            var result = await _httpClient.GetFromJsonAsync<PistonRuntime[]>("https://emkc.org/api/v2/piston/runtimes");
            return result;
        }

        public async Task<PistonOutput> RunCode(PistonInput pistonInput)
        {
            var result = await _httpClient.PostAsJsonAsync("https://emkc.org/api/v2/piston/execute", pistonInput);
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }
            else
            {
                var data = await result.Content.ReadFromJsonAsync<PistonOutput>();
                return data;
            }
        }
    }
}
