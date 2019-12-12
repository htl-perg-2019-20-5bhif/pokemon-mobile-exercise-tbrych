using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokemonList
{
    public class PokemonClient
    {
        private static readonly HttpClient HttpClient = new HttpClient();

        async public static Task<Pokemons> GetAllPokemons()
        {
            try
            {
                Pokemons pokemons = new Pokemons();
                pokemons.Results = new System.Collections.Generic.List<Pokemon>();

                var result = await HttpClient.GetStringAsync("https://pokeapi.co/api/v2/pokemon");
                PokemonUrl pokemonsUrl = JsonConvert.DeserializeObject<PokemonUrl>(result);
                foreach (PokemonShort curPokemonShort in pokemonsUrl.Results)
                {
                    pokemons.Results.Add(JsonConvert.DeserializeObject<Pokemon>(await HttpClient.GetStringAsync(curPokemonShort.Url)));
                }

                return pokemons;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /*
        pokemons.Results.Add(
            new Pokemon()
            {
                Name = "Test",
                Weight = 42,
                Sprites = new Sprite()
                {
                    FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                    BackDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png"
                },
                Abilities = new System.Collections.Generic.List<Ability>()
                {
                    new Ability()
                    {
                        Name = "Test1"
                    },
                    new Ability()
                    {
                        Name = "Test2"
                    }
                }
            });
        */
    }
}
