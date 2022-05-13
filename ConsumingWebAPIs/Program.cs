using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using ConsumingWebAPIs.Models;
using System.Text.Json;

namespace ConsumingWebAPIs
{
    //Vari modi per chiamare un'api web con C# senza librerie esterne

    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            //Vari modi per fare la stessa cosa:
            await OttieniDrinks();
            await OttieniDrinks1();
            await OttieniDrinks2();
        }

        private static async Task OttieniDrinks()
        {
            client.BaseAddress = new Uri("https://www.thecocktaildb.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Add("Key", "Value"); Custom Header

            Rootobject rootObj = null;
            HttpResponseMessage response = await client.GetAsync("api/json/v1/1/search.php?s=margarita");
            if (response.IsSuccessStatusCode)
            {
                //Aggiungere il pacchetto Microsoft.AspNet.WebApi.Client
                rootObj = await response.Content.ReadAsAsync<Rootobject>();
                VisualizzaDrinks(rootObj);
            }
        }

        private static async Task OttieniDrinks1()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var stringTask = await client.GetStringAsync("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita");
            //var streamTask = await client.GetStreamAsync("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita"); Analogo
            var rootObj = JsonSerializer.Deserialize<Rootobject>(stringTask);
            VisualizzaDrinks(rootObj);
        }

        private static async Task OttieniDrinks2()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var request = new HttpRequestMessage(HttpMethod.Get, "https://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita");

            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                using (var responseSrteam = await response.Content.ReadAsStreamAsync())
                {
                    var rootObj = await JsonSerializer.DeserializeAsync<Rootobject>(responseSrteam);
                    VisualizzaDrinks(rootObj);
                }
            }
        }

        private static void VisualizzaDrinks(Rootobject rootObj)
        {
            foreach (var drink in rootObj.drinks)
            {
                Console.WriteLine($"{drink.strDrink}: \n\t{drink.strIngredient1} \n\t{drink.strIngredient2}");
            }
        }
    }
}
