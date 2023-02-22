using System;
using System.Net.Http;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AppTest.Alive
{
    public class AliveAppService : ApplicationService, IAliveAppService
    {
        private HttpClient _httpClient;

        public AliveAppService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> CallAlive()
        {
            using var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://staging.ptranz.com/api/Alive");
            
           

            try
            {
                var content = await _httpClient.SendAsync(requestMessage);               
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
