using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SWAPIConsole
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Console.WriteLine("Виберіть API для отримання даних:");
            Console.WriteLine("1 - People");
            Console.WriteLine("2 - Films");
            Console.WriteLine("3 - Starships");
            Console.WriteLine("4 - Vehicles");
            Console.WriteLine("5 - Species");
            Console.WriteLine("6 - Planets");

            int choice = int.Parse(Console.ReadLine() ?? "1");

            string resource = choice switch
            {
                1 => "people",
                2 => "films",
                3 => "starships",
                4 => "vehicles",
                5 => "species",
                6 => "planets",
                _ => "people"
            };

            string url = $"https://swapi.py4e.com/api/{resource}/";

            try
            {
                await FetchData(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        static async Task FetchData(string url)
        {
            string response = await client.GetStringAsync(url);

            JObject jsonResponse = JObject.Parse(response);
            var results = jsonResponse["results"];

            Console.WriteLine("\nОтримані дані:");

            foreach (var item in results)
            {
                Console.WriteLine($"- {item["name"]}");
            }
        }
    }
}
