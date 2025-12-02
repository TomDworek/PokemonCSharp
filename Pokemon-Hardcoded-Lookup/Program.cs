namespace Pokemon;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        while (true)
        {
            var pokedex = new Pokedex();
            pokedex.LoadPokemons();
            
            Console.WriteLine("Skriv in et Pokedex ####(0001):");
            string pdNumber = Console.ReadLine();
            
            Pokemon foundPokemon = null;

            foreach (var pokemon in pokedex.Pokemons)
            {
                if (pokemon.idPokedex == pdNumber)
                {
                    foundPokemon = pokemon;
                    break;
                }
            }
            
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
