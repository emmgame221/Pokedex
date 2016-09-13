using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{ 
    public class Move
    {
        public string Name
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public int PP
        {
            get; set;
        }
        public int Power
        {
            get; set;
        }
        public int Accuracy
        {
            get; set;
        }
        public int EffectChance
        {
            get; set;
        }
        public PokemonType Type
        {
            get; set;
        }
        public Category DamageType
        {
            get; set;
        }

        public static int CompareByName(Move m1, Move m2)
        {
            return m1.Name.CompareTo(m2.Name);
        }
    }
}
