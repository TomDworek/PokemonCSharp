using System.Net.Http;
using System.Text.Json;

namespace Pokemon;

class Program
{
    static async Task Main(string[] args)
    {
        var httpClient = new HttpClient();

        while (true)
        {
            Console.WriteLine("Skriv inn et Pokedex nr eller navn:");
            string input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ugyldig input!");
                continue;
            }

            try
            {
                var response = await httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{input.ToLower()}");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                using var doc = JsonDocument.Parse(json);

                var root = doc.RootElement;
                var id = root.GetProperty("id").ToString();
                var name = root.GetProperty("name").ToString();
                var type = root.GetProperty("types")[0].GetProperty("type").GetProperty("name").ToString();

                var random = new Random();
                int level = random.Next(1, 101); // Level 1-100
                int hp = random.Next(10, 151);   // HP 10-150

                Console.Clear();
                Console.WriteLine($"ID: {id}\nNavn: {name}\nLevel: {level}\nHP: {hp}\nType: {type}");
            }
            catch
            {
                Console.WriteLine("Pokemon er ikke funnet eller API-feil!");
            }
        }
    }
}
