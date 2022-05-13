using CoureLibraryConsumer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoureLibraryConsumer
{
    //Applicazione client che consuma la mia WebApi CourseLibrary

    internal class Program
    {
        private static HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            client.BaseAddress = new Uri("https://localhost:44329/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            await GetAuthors();
            await PostAuthor();
            await PostAuthor2();
            await DeleteAuthor(new Guid("08d9c13a-3c30-4665-8f63-d0bab32d0687"));

            Console.ReadKey();
        }

        private static async Task GetAuthors()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "api/authors");

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                using Stream authorsAsStream = await response.Content.ReadAsStreamAsync();
                var authors = await JsonSerializer.DeserializeAsync<IEnumerable<Author>>(authorsAsStream);

                VisualizzaAuthors(authors);
            }
        }

        private static async Task PostAuthor()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "api/authors");
            string newAuthJson = "{\"firstName\": \"Mario\", \"lastName\": \"Verdi\", \"mainCategory\": \"Boh\", \"dateOfBirth\": \"2022-05-12T07:55:19.534Z\"}";
            request.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
            request.Content = new StringContent(newAuthJson);

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string authorsAsString = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Autore creato: {response.Headers.Location}");
                Console.WriteLine(authorsAsString);
            }
        }

        private static async Task DeleteAuthor(Guid id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/authors/{id}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
        }

        private static void VisualizzaAuthors(IEnumerable<Author> authors)
        {
            foreach (var author in authors)
            {
                Console.WriteLine($"{author.name} {author.age}");
            }
        }

        //Installare Microsoft.AspNet.WebApi.Client
        private static async Task PostAuthor2()
        {
            CreateAuthor author = new CreateAuthor
            {
                firstName = "Simone",
                lastName = "Denardi",
                dateOfBirth = new DateTime(2000, 4, 10),
                mainCategory = "Fishing"
            };

            HttpResponseMessage response = await client.PostAsJsonAsync("api/authors", author);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Headers.Location);
            }
        }

    }
}
