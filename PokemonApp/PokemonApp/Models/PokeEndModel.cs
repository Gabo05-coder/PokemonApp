namespace PokemonApp.Models;
public class Pokemon
{
    public string Name { get; set; }
    public string Url { get; set; }
}

public class PokemonResponse
{
    public List<Pokemon> Results { get; set; }
}
