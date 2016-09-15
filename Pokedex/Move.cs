using Newtonsoft.Json;

namespace Pokedex
{
    [JsonObject(IsReference = true)]
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

        public override string ToString()
        {
            string powerString = Power.ToString();
            if(Power == 0)
            {
                powerString = "--";
            } else if(Power == -1)
            {
                powerString = "??";
            }
            string accString = Accuracy.ToString();
            if (Accuracy == 0)
            {
                accString = "--";
            }
            string effString = EffectChance.ToString();
            if (EffectChance == 0)
            {
                effString = "--";
            }
            return string.Format("{0,16}{1,9}{2,9}{3,8}{4,8}{5,8}%{6,3} \n{7}",
                Name, Type, DamageType, powerString, accString, effString, PP, Description);
        }
    }
}
