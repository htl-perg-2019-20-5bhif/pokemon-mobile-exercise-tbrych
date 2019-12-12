using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokemonList
{
    public class PokemonUrl
    {
        [JsonProperty("results")]
        public List<PokemonShort> Results { get; set; }
    }
    public class PokemonShort
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }


    public class Pokemons
    {
        public List<Pokemon> Results { get; set; }
    }
    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("sprites")]
        public Sprite Sprites { get; set; }

        [JsonProperty("abilities")]
        public List<Ability> Abilities { get; set; }
    }
    public class Sprite
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("back_default")]
        public string BackDefault { get; set; }
    }
    public class Ability
    {
        [JsonProperty("ability.name")]
        public string Name { get; set; }
    }

}
