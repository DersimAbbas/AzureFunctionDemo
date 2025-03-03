using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using Twilio.TwiML;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace WhatsAppFunction
{
    public class ChuckNorrisFunction
    {
        private readonly ILogger<ChuckNorrisFunction> _logger;
        private static readonly HttpClient httpClient = new HttpClient();
        public ChuckNorrisFunction()
        {
           
        }

        [Function("WhatsApp")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            var response = await httpClient.GetAsync("https://api.chucknorris.io/jokes/random");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(json);

            string joke = doc.RootElement.GetProperty("value").ToString();
            var messagingResponse = new MessagingResponse();

            messagingResponse.Message(joke);

            var result = req.CreateResponse(HttpStatusCode.OK);

            result.Headers.Add("Content-Type", "application/xml");

           await result.WriteStringAsync(messagingResponse.ToString());
            
            return result;
           
        }
    }
}


            
           
               
