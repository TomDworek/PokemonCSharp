namespace Pokemon;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        while (true)
        {
            // dette er for oss til å bruke metoden LoadPokemons i Pokedex.cs
            var pokedex = new Pokedex();
            pokedex.LoadPokemons();
            
            Console.WriteLine("Skriv in et Pokedex ####(0001):");
            string pdNumber = Console.ReadLine();

            // jeg har laget en "tom" variabel her som referer til Pokemon class (sjekk Pokemon.cs)
            // Sånn at vi kan legge til den pokemon vi har funnet i variablen for å bruke det senere = den kan inneholde Pokemon (objekt) m/ navn, type, osv. hvis en bruker skriver 0025 som en eksempel.
            Pokemon foundPokemon = null;

            // her går vi gjennom i alle Pokemons (objekt) i Pokedex.cs
            foreach (var pokemon in pokedex.Pokemons) // her går vi gjennom i alle Pokemons (objekt) i Pokedex.cs
            {
                if (pokemon.idPokedex == pdNumber)
                {
                    foundPokemon = pokemon;
                    break;
                }
            }
            
            // hvis brukeren skriver noe = ikke null lenger så skal den gjøre dette
            if (foundPokemon != null)
            {
                Console.Clear();
                Console.WriteLine($"ID: {foundPokemon.idPokedex}\n" +
                                  $"Navn: {foundPokemon.Name}\n" +
                                  $"Level: {foundPokemon.Level}\n" +
                                  $"HP: {foundPokemon.Health}\n" +
                                  $"Type: {foundPokemon.Type}");
            }
            else
            {
                Console.WriteLine("Pokemon er ikke funnet!");
            }
        }
    }
}
