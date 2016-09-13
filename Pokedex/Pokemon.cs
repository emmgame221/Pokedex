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
        public Type Type1
        {
            get; set;
        }
        public Type Type2
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
        public Dictionary<int, Move> LevelUpMoves
        {
            get; set;
        }
        #endregion

    }
}
