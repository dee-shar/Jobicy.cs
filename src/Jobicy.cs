using System.Net.Http;

namespace JobicyApi
{
    public class Jobicy
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://jobicy.com/api/v2";
        public Jobicy()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetRemoteJobs()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/remote-jobs");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
