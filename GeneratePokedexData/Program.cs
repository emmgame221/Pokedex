using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Pokedex;
using Newtonsoft.Json;

namespace GeneratePokedexData
{
    class Program
    {
        static string fileName = "pokedex.json";

        static void Main(string[] args)
        {
            PokedexData dex = new PokedexData();
            Console.WriteLine("Checking for existing pokedex data");
            if(File.Exists(fileName))
            {
                Console.WriteLine("Pokedex data found");
                dex = JsonConvert.DeserializeObject<PokedexData>(File.ReadAllText(fileName));
            } else
            {
                Console.WriteLine("No data found, creating new data");
                dex.Moves = new List<Move>();
                dex.PokemonList = new List<Pokemon>();
                dex.TMList = new List<Tuple<int, Move>>();
                dex.HMList = new List<Tuple<int, Move>>();
            }
            bool endFlag = false;
            while(!endFlag)
            {
                Console.WriteLine("Type q to exit, p for new pokemon, m for new move, t for tms, h for hms.");
                string input = Console.ReadLine();
                switch (input) {
                    case "q":
                        endFlag = true;
                        continue;
                    case "p":
                        CreateNewPokemon(dex);
                        break;
                    case "m":
                        CreateNewMove(dex);
                        break;
                    case "h":
                        SetupHMs(dex);
                        break;
                    case "t":
                        SetupTMs(dex);
                        break;
                    default:
                        Console.WriteLine("Sorry, That is an invalid command");
                        break;
                }
            }
            SaveData(dex);
        }

        static void CreateNewPokemon(PokedexData dex)
        {
            Console.WriteLine("Name: ");
            string input = Console.ReadLine();
            if (dex.PokemonList.Exists(p => p.Name == input))
            {
                Console.WriteLine("That pokemon is already known. o to Overwrite");
                if(Console.ReadLine() == "o")
                {
                    dex.PokemonList.RemoveAll(p => p.Name == input);
                    CreateNewPokemon(dex, input);
                }
                return;
            }
            CreateNewPokemon(dex, input);
        }

        static void CreateNewPokemon(PokedexData dex, string name)
        {
            Pokemon newPokemon = new Pokemon();
            newPokemon.Name = name;
            dex.PokemonList.Add(newPokemon);
            Console.WriteLine("ID: ");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                newPokemon.ID = id;
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                return;
            }
            Console.WriteLine("Type1: ");
            PokemonType type1;
            if (Enum.TryParse<PokemonType>(Console.ReadLine(), out type1))
            {
                newPokemon.Type1 = type1;
            }
            else
            {
                Console.WriteLine("That is not a valid type.");
                return;
            }
            Console.WriteLine("Type2: ");
            PokemonType type2;
            if (Enum.TryParse<PokemonType>(Console.ReadLine(), out type2))
            {
                newPokemon.Type2 = type2;
            }
            else
            {
                Console.WriteLine("That is not a valid type.");
                return;
            }
            Console.WriteLine("Base HP: ");
            int hp;
            if (int.TryParse(Console.ReadLine(), out hp))
            {
                newPokemon.BaseHP = hp;
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                return;
            }
            Console.WriteLine("Base Attack: ");
            int att;
            if (int.TryParse(Console.ReadLine(), out att))
            {
                newPokemon.BaseAttack = att;
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                return;
            }
            Console.WriteLine("Base Defense: ");
            int def;
            if (int.TryParse(Console.ReadLine(), out def))
            {
                newPokemon.BaseDefense = def;
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                return;
            }
            Console.WriteLine("Base Sp. Attack: ");
            int spatt;
            if (int.TryParse(Console.ReadLine(), out spatt))
            {
                newPokemon.BaseSpecialAttack = spatt;
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                return;
            }
            Console.WriteLine("Base Sp. Defense: ");
            int spdef;
            if (int.TryParse(Console.ReadLine(), out spdef))
            {
                newPokemon.BaseSpecialDefense = spdef;
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                return;
            }
            Console.WriteLine("Base Speed: ");
            int speed;
            if (int.TryParse(Console.ReadLine(), out speed))
            {
                newPokemon.BaseSpeed = speed;
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                return;
            }
            Console.WriteLine("Evolves from: ");
            string prevo = Console.ReadLine();
            if(prevo.Length > 0 && !dex.PokemonList.Exists(p => p.Name == prevo))
            {
                Console.WriteLine("That pokemon doesn't exist yet. Let's create it.");
                CreateNewPokemon(dex, prevo);
                newPokemon.EvolvesFrom = dex.PokemonList.Find(p => p.Name == prevo);
            }
            Console.WriteLine("How many pokemon can this pokemon evolve to?");
            int evoNum;
            newPokemon.EvolvesTo = new List<Pokemon>();
            if(int.TryParse(Console.ReadLine(), out evoNum))
            {
                for(int i = 0; i < evoNum; i++)
                {
                    Console.WriteLine("Evolves to: ");
                    string evo = Console.ReadLine();
                    if(!dex.PokemonList.Exists(p => p.Name == evo))
                    {
                        Console.WriteLine("That pokemon doesn't exist yet. Let's create it.");
                        CreateNewPokemon(dex, evo);
                        newPokemon.EvolvesTo.Add(dex.PokemonList.Find(p => p.Name == evo));
                    } else
                    {
                        newPokemon.EvolvesTo.Add(dex.PokemonList.Find(p => p.Name == evo));
                    }
                }
            } else
            {
                Console.WriteLine("That is not an integer.");
                return;
            }
            Console.WriteLine("How many moves does this pokemon learn by level up?");
            int moveNum;
            newPokemon.LevelUpMoves = new List<Tuple<int, Move>>();
            if(int.TryParse(Console.ReadLine(), out moveNum))
            {
                for(int i= 0; i < moveNum; i++)
                {
                    Console.WriteLine("Level Learned: ");
                    int level = int.Parse(Console.ReadLine());
                    Console.WriteLine("Move Name: ");
                    string move = Console.ReadLine();
                    if (!dex.Moves.Exists(m => m.Name == move))
                    {
                        Console.WriteLine("That move doesn't exist yet. Let's create it.");
                        CreateNewMove(dex, move);
                    }
                    newPokemon.LevelUpMoves.Add(new Tuple<int, Move>(level, dex.Moves.Find(m => m.Name == move)));
                }
            } else
            {
                Console.WriteLine("That is not an integer.");
                SaveData(dex);
            }
            Console.WriteLine("How many tms can this pokemon learn?");
            newPokemon.LearnableTMs = new List<int>();
            int tmNum;
            if(int.TryParse(Console.ReadLine(), out tmNum))
            {
                for(int i = 0; i < tmNum; i++)
                {
                    Console.WriteLine("TM Number: ");
                    int tm = int.Parse(Console.ReadLine());
                    newPokemon.LearnableTMs.Add(tm);
                }
            } else
            {
                Console.WriteLine("That is not an integer.");
                SaveData(dex);
            }
            Console.WriteLine("How many hms can this pokemon learn?");
            newPokemon.LearnableHMs = new List<int>();
            int hmNum;
            if (int.TryParse(Console.ReadLine(), out hmNum))
            {
                for (int i = 0; i < hmNum; i++)
                {
                    Console.WriteLine("HM Number: ");
                    int hm = int.Parse(Console.ReadLine());
                    newPokemon.LearnableTMs.Add(hm);
                }
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                SaveData(dex);
            }
        }

        static void CreateNewMove(PokedexData dex)
        {
            Console.WriteLine("Name: ");
            string input = Console.ReadLine();
            if (dex.Moves.Exists(m => m.Name == input))
            {
                Console.WriteLine("That move is already known.");
                SaveData(dex);
            }
            CreateNewMove(dex, input);
        }

        private static void CreateNewMove(PokedexData dex, string name)
        {
            Move newMove = new Move();
            newMove.Name = name;
            Console.WriteLine("Description: ");
            newMove.Description = Console.ReadLine();

            Console.WriteLine("Type: ");
            PokemonType type;
            if (Enum.TryParse<PokemonType>(Console.ReadLine(), out type))
            {
                newMove.Type = type;
            }
            else
            {
                Console.WriteLine("That is not a valid type.");
                SaveData(dex);
            }
            Console.WriteLine("Category: ");
            Category category;
            if (Enum.TryParse<Category>(Console.ReadLine(), out category))
            {
                newMove.DamageType = category;
            }
            else
            {
                Console.WriteLine("That is not a valid category.");
                SaveData(dex);
            }
            Console.WriteLine("Power: ");
            int power;
            if (int.TryParse(Console.ReadLine(), out power))
            {
                newMove.Power = power;
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                SaveData(dex);
            }
            Console.WriteLine("Accuracy: ");
            int acc;
            if (int.TryParse(Console.ReadLine(), out acc))
            {
                newMove.Accuracy = acc;
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                SaveData(dex);
            }
            Console.WriteLine("Effect Chance: ");
            int eff;
            if (int.TryParse(Console.ReadLine(), out eff))
            {
                newMove.EffectChance = eff;
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                SaveData(dex);
            }
            Console.WriteLine("Max PP: ");
            int pp;
            if (int.TryParse(Console.ReadLine(), out pp))
            {
                newMove.PP = pp;
            }
            else
            {
                Console.WriteLine("That is not an integer.");
                SaveData(dex);
            }
            dex.Moves.Add(newMove);
        }

        public static void SetupTMs(PokedexData dex)
        {
            Console.WriteLine("How many HMs are there?");
            int tmNo;
            if (int.TryParse(Console.ReadLine(), out tmNo))
            {
                for (int i = 1; i <= tmNo; i++)
                {
                    Console.WriteLine("Name of TM number {0}: ", i);
                    string move = Console.ReadLine();
                    if (!dex.Moves.Exists(m => m.Name == move))
                    {
                        Console.WriteLine("That move doesn't exist yet. Let's create it.");
                        CreateNewMove(dex, move);
                    }
                    dex.TMList.Add(new Tuple<int, Move>(i, dex.Moves.Find(m => m.Name == move)));
                }
            }
            else
            {
                Console.WriteLine("That is not an integer");
                SaveData(dex);
            }
        }

        public static void SetupHMs(PokedexData dex)
        {
            Console.WriteLine("How many HMs are there?");
            int hmNo;
            if(int.TryParse(Console.ReadLine(), out hmNo))
            {
                for(int i = 1; i <= hmNo; i++)
                {
                    Console.WriteLine("Name of HM number {0}: ", i);
                    string move = Console.ReadLine();
                    if(!dex.Moves.Exists(m => m.Name == move))
                    {
                        Console.WriteLine("That move doesn't exist yet. Let's create it.");
                        CreateNewMove(dex, move);
                    }
                    dex.HMList.Add(new Tuple<int, Move>(i, dex.Moves.Find(m => m.Name == move)));
                }
            } else
            {
                Console.WriteLine("That is not an integer");
                SaveData(dex);
            }
        }

        public static void SaveData(PokedexData dex)
        {
            dex.PokemonList.Sort(Pokemon.CompareByID);
            dex.Moves.Sort(Move.CompareByName);
            string json = JsonConvert.SerializeObject(dex, Formatting.Indented,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            File.WriteAllText(fileName, json);
            Environment.Exit(0);
        }
    }
}
