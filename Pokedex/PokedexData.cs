using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Tuple<int, Move>> TMList
        {
            get; set;
        }
        public List<Tuple<int, Move>> HMList
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
