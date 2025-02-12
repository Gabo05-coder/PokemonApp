namespace PokemonApp.Client.PokeDetailService;

using System.Text.Json.Serialization;

public class PokemonDetails
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("base_experience")]
    public int BaseExperience { get; set; }

    [JsonPropertyName("sprites")]
    public SpriteSprites Sprites { get; set; }

    public class SpriteSprites
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }
}
