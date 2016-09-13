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
            get; private set;
        }
        public int Power
        {
            get; private set;
        }
        public int Accuracy
        {
            get; private set;
        }
        public Type Type
        {
            get; private set;
        }
    }
}
