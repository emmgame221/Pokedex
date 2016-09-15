using System.Collections.Generic;

namespace Pokedex
{
    public class PokedexData
    {
        public List<Move> Moves
        {
            get; set;
        }
        public List<Pokemon> PokemonList
        {
            get; set;
        }
        public Dictionary<int, Move> TMList
        {
            get; set;
        }
        public Dictionary<int, Move> HMList
        {
            get; set;
        }

        public Pokemon GetPokemon(string name)
        {
            return PokemonList.Find(p => p.Name == name);
        }

        public Pokemon GetPokemon(int id)
        {
            return PokemonList.Find(p => p.ID == id);
        }
    }
}
