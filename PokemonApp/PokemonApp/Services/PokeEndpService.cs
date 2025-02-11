namespace PokemonApp.Services;

using Models;
using RestSharp;
using System.Threading.Tasks;

public class PokemonService
{
    private readonly RestClient _client;

    public PokemonService()
    {
        _client = new RestClient("https://pokeapi.co/api/v2/");
    }

    public async Task<PokemonResponse> GetPokemonsAsync(int limit = 20)
    {
        var request = new RestRequest("pokemon", Method.Get);
        request.AddParameter("limit", limit); // Limitar el número de resultados

        var response = await _client.ExecuteAsync<PokemonResponse>(request);

        if (response.IsSuccessful)
        {
            return response.Data;
        }

        return null;
    }
}
