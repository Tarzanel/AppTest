using System;
using System.Net.Http;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AppTest.Alive
{
    public class AliveAppService : ApplicationService, IAliveAppService
    {
        private HttpClient _httpClient;

        public AliveAppService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> CallAlive()
        {
            using var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://staging.ptranz.com/api/Alive");
            
            requestMessage.Headers.Add("Accept", "application/json");
            requestMessage.Headers.Add("PowerTranz-PowerTranzId", "88800962");
            requestMessage.Headers.Add("PowerTranz-PowerTranzPassword", "SDWRsJPI4fJQMJCJ74NaZyHHgTHcmpTmyuVOlNfqZoGoRTz3UfhwU5");
            requestMessage.Headers.Add("Host", "staging.ptranz.com");

            try
            {
                Console.WriteLine("Astept !!!!");
                var content = await _httpClient.SendAsync(requestMessage);
                Console.WriteLine("Am facut request");
                var result = await content.Content.ReadAsStringAsync();
                return result;
            }
            catch(Exception)
            {
                throw;
            }
            
        }
    }
}
