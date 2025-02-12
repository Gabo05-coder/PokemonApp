
using System.Text.Json;
using RestSharp;
using System.Threading.Tasks;
using PokemonApp.Client.PokeDetailService;


namespace YourNamespace.Services
{
    public class PokemonDetailsService
    {
        private readonly RestClient _client;

        public PokemonDetailsService()
        {
            _client = new RestClient("https://pokeapi.co/api/v2/");
        }

        public async Task<PokemonDetails> GetPokemonDetailsAsync(int id)
        {
            var request = new RestRequest($"pokemon/{id}", Method.Get);

            try
            {
                // Realizamos la solicitud GET
                var response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Console.WriteLine($"[DEBUG] Respuesta JSON: {response.Content}");

                    // Deserializamos manualmente para detectar errores
                    var pokemonDetails = JsonSerializer.Deserialize<PokemonDetails>(
                        response.Content,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    return pokemonDetails;
                }
                else
                {
                    Console.WriteLine($"[ERROR] La API devolvió un error: {response.StatusCode} - {response.ErrorMessage}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[EXCEPTION] Error en la solicitud: {ex.Message}");
            }

            return null;
        }
    }
}
