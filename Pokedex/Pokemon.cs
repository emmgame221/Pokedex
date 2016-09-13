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
            get; private set;
        }
        public int ID
        {
            get; private set;
        }
        public Type Type1
        {
            get; private set;
        }
        public Type Type2
        {
            get; private set;
        }
        public int BaseHP
        {
            get; private set;
        }
        public int BaseAttack
        {
            get; private set;
        }
        public int BaseDefense
        {
            get; private set;
        }
        public int BaseSpecialAttack
        {
            get; private set;
        }
        public int BaseSpecialDefense
        {
            get; private set;
        }
        public int BaseSpeed
        {
            get; private set;
        }
        public Dictionary<int, Move> LevelUpMoves
        {
            get; private set;
        }
        #endregion

        public void Serialize()
        {

        }
    }
}
