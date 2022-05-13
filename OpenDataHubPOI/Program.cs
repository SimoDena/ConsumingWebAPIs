using OpenDataHubPOI.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenDataHubPOI
{
    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            client.BaseAddress = new Uri("https://tourism.api.opendatahub.bz.it/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ODHActivityPoi oDHActivityPoi = await OttieniPoi(2);
            VisualizzaPoi(oDHActivityPoi.Items);

            Console.ReadKey();
        }

        private static async Task<ODHActivityPoi> OttieniPoi(int pageNumber)
        {
            HttpResponseMessage response = await client.GetAsync($"v1/ODHActivityPoi?pagenumber={pageNumber}");
            if (response.IsSuccessStatusCode)
            {
                using Stream stream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<ODHActivityPoi>(stream);
            }

            return null;
        }

        private static void VisualizzaPoi(Item[] pois)
        {
            foreach (var poi in pois)
            {
                Console.WriteLine($"{poi.Detail.it.Title}");
            }
        }
    }
}
