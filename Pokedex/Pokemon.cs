using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Pokemon
    {
        #region Properties
        public string Name
        {
            get; set;
        }
        public int ID
        {
            get; set;
        }
        public PokemonType Type1
        {
            get; set;
        }
        public PokemonType Type2
        {
            get; set;
        }
        public string Ability1
        {
            get; set;
        }
        public string Ability2
        {
            get; set;
        }
        public string Ability3
        {
            get; set;
        }
        public int BaseHP
        {
            get; set;
        }
        public int BaseAttack
        {
            get; set;
        }
        public int BaseDefense
        {
            get; set;
        }
        public int BaseSpecialAttack
        {
            get; set;
        }
        public int BaseSpecialDefense
        {
            get; set;
        }
        public int BaseSpeed
        {
            get; set;
        }
        public Pokemon EvolvesFrom
        {
            get; set;
        }
        public List<Pokemon> EvolvesTo
        {
            get; set;
        }
        public List<Tuple<int, Move>> LevelUpMoves
        {
            get; set;
        }
        public List<int> LearnableTMs
        {
            get; set;
        }
        public List<int> LearnableHMs
        {
            get; set;
        }
        #endregion

        public static int CompareByID(Pokemon p1, Pokemon p2)
        {
            return p1.ID.CompareTo(p2.ID);
        }

        public static int CompareByName(Pokemon p1, Pokemon p2)
        {
            return p1.Name.CompareTo(p2.Name);
        }
    }
}
