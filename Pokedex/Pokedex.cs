using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Pokedex
    {
        public List<Move> Moves
        {
            get; private set;
        }
        public List<Pokemon> pokemonList
        {
            get; private set;
        }

        public Pokemon GetPokemon(string name)
        {
            return pokemonList.Find(p => p.Name == name);
        }

        public Pokemon GetPokemon(int id)
        {
            return pokemonList.Find(p => p.ID == id);
        }
    }
}
