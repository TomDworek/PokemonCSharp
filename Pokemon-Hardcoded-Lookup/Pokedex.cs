namespace Pokemon;

public class Pokedex
{
    public List<Pokemon> Pokemons = new List<Pokemon>();
    
    // En liste av Pokemon (objekt) som vi bruker i Program.cs
    public void LoadPokemons()
    {
        Pokemons.Add(new Pokemon(){idPokedex = "0001", Name = "Baulbasaur", Level = 5, Health = 45, Type = "Grass"});
        Pokemons.Add(new Pokemon(){idPokedex = "0002", Name = "Ivysaur", Level = 16, Health = 60, Type = "Grass"});
        Pokemons.Add(new Pokemon(){idPokedex = "0003", Name = "Venusaur", Level = 32, Health = 80, Type = "Grass"});
        Pokemons.Add(new Pokemon(){idPokedex = "0004", Name = "Charmander", Level = 8, Health = 39, Type = "Fire"});
        Pokemons.Add(new Pokemon(){idPokedex = "0005", Name = "Charmeleon", Level = 20, Health = 58, Type = "Fire"});
        Pokemons.Add(new Pokemon(){idPokedex = "0006", Name = "Charizard", Level = 36, Health = 78, Type = "Fire"});
        Pokemons.Add(new Pokemon(){idPokedex = "0007", Name = "Squirtle", Level = 7, Health = 44, Type = "Water"});
        Pokemons.Add(new Pokemon(){idPokedex = "0008", Name = "Wartortle", Level = 16, Health = 59, Type = "Water"});
        Pokemons.Add(new Pokemon(){idPokedex = "0009", Name = "Blastoise", Level = 36, Health = 79, Type = "Water"});
        Pokemons.Add(new Pokemon(){idPokedex = "0010", Name = "Caterpie", Level = 3, Health = 45, Type = "Insect"});
        Pokemons.Add(new Pokemon(){idPokedex = "0011", Name = "Metapod", Level = 7, Health = 50, Type = "Insect"});
        Pokemons.Add(new Pokemon(){idPokedex = "0012", Name = "Butterfree", Level = 10, Health = 60, Type = "Insect"});
        Pokemons.Add(new Pokemon(){idPokedex = "0013", Name = "Weedle", Level = 3, Health = 40, Type = "Insect"});
        Pokemons.Add(new Pokemon(){idPokedex = "0014", Name = "Kakuna", Level = 7, Health = 45, Type = "Insect"});
        Pokemons.Add(new Pokemon(){idPokedex = "0015", Name = "Beedrill", Level = 12, Health = 65, Type = "Insect" });
        Pokemons.Add(new Pokemon(){idPokedex = "0016", Name = "Pidgey", Level = 5, Health = 40, Type = "Flying"});
        Pokemons.Add(new Pokemon(){idPokedex = "0017", Name = "Pidgeotto", Level = 18, Health = 63, Type = "Flying"});
        Pokemons.Add(new Pokemon(){idPokedex = "0018", Name = "Pidgeot", Level = 36, Health = 83, Type = "Flying"});
        Pokemons.Add(new Pokemon(){idPokedex = "0019", Name = "Rattata", Level = 4, Health = 30, Type = "Normal"});
        Pokemons.Add(new Pokemon(){idPokedex = "0020", Name = "Raticate", Level = 20, Health = 55, Type = "Normal"});
        Pokemons.Add(new Pokemon(){idPokedex = "0021", Name = "Spearow", Level = 5, Health = 40, Type = "Flying"});
        Pokemons.Add(new Pokemon(){idPokedex = "0022", Name = "Fearow", Level = 20, Health = 65, Type = "Flying"});
        Pokemons.Add(new Pokemon(){idPokedex = "0023", Name = "Ekans", Level = 7, Health = 35, Type = "Poisen"});
        Pokemons.Add(new Pokemon(){idPokedex = "0024", Name = "Arbok", Level = 22, Health = 60, Type = "Poisen"});
        Pokemons.Add(new Pokemon(){idPokedex = "0025", Name = "Pikachu", Level = 10, Health = 35, Type = "Electric"});
        // ... Fortsett å legge til flere Pokemon etter behov
    }
}

