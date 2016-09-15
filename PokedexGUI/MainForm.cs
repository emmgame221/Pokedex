using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokedex;
using Newtonsoft.Json;
using System.IO;

namespace PokedexGUI
{
    public partial class MainForm : Form
    {
        PokedexData pokedex;
        Pokemon currentPokemon;
        const string DataFileName = @"C:\Users\Eric\Documents\Visual Studio 2015\Projects\Pokedex\Data\pokedex.json";

        bool updatingDisplay = false;
        List<string> levelUpMoveStrings;
        string levelUpMoveHeader = "Level            Name     Type Category   Power Accuracy Effect% PP Description";
        List<string> tmHMMoveStrings;
        string tmHmMoveHeader =    "TM/HM            Name     Type Category   Power Accuracy Effect% PP Description";

        public MainForm()
        {
            pokedex = JsonConvert.DeserializeObject<PokedexData>(File.ReadAllText(DataFileName));
            currentPokemon = pokedex.PokemonList[0];
            InitializeComponent();
            BindComboBox();
        }

        void BindComboBox()
        {
            pokemonListComboBox.DataSource = pokedex.PokemonList;
            pokemonListComboBox.DisplayMember = "Name";
        }

        void UpdateDisplay()
        {
            updatingDisplay = true;
            nameLabel.Text = currentPokemon.Name;
            typeLabel.Text = currentPokemon.Type1.ToString();
            if (currentPokemon.Type2 != PokemonType.None)
            {
                typeLabel.Text += " / " + currentPokemon.Type2.ToString();
            }
            hpLabel.Text = string.Format("HP: {0}", currentPokemon.BaseHP);
            attackLabel.Text = string.Format("Attack: {0}", currentPokemon.BaseAttack);
            defenseLabel.Text = string.Format("Defense: {0}", currentPokemon.BaseDefense);
            spAttackLabel.Text = string.Format("Sp. Attack: {0}", currentPokemon.BaseSpecialAttack);
            spDefenseLabel.Text = string.Format("Sp. Defense: {0}", currentPokemon.BaseSpecialDefense);
            speedLabel.Text = string.Format("Speed: {0}", currentPokemon.BaseSpeed);
            ability1Label.Text = currentPokemon.Ability1;
            if (currentPokemon.Ability2 == currentPokemon.Ability1)
            {
                ability2Label.Text = "";
            }
            else
            {
                ability2Label.Text = currentPokemon.Ability2;
            }
            if (currentPokemon.Ability3 == currentPokemon.Ability2)
            {
                ability3Label.Text = "";
            }
            else
            {
                ability3Label.Text = currentPokemon.Ability3;
            }
            evolvesFromLabel.Text = (currentPokemon.EvolvesFrom != null) ? currentPokemon.EvolvesFrom.Name : "";
            evolvesToComboBox.DataSource = currentPokemon.EvolvesTo;
            evolvesToComboBox.DisplayMember = "Name";
            levelUpMoveStrings = new List<string>();
            levelUpMoveStrings.Add(levelUpMoveHeader);
            foreach(var v in currentPokemon.LevelUpMoves)
            {
                levelUpMoveStrings.Add(string.Format("{0,5}{1}", v.Item1, v.Item2.ToString()));
            }
            levelUpMovesListBox.DataSource = levelUpMoveStrings;
            tmHMMoveStrings = new List<string>();
            tmHMMoveStrings.Add(tmHmMoveHeader);
            foreach(int tm in currentPokemon.LearnableTMs)
            {
                tmHMMoveStrings.Add(string.Format("{0,5}{1}", tm, pokedex.TMList[tm - 1].Item2));
            }
            foreach (int hm in currentPokemon.LearnableHMs)
            {
                tmHMMoveStrings.Add(string.Format("{0,5}{1}", hm, pokedex.HMList[hm - 1].Item2));
            }
            tmHmListBox.DataSource = tmHMMoveStrings;
            updatingDisplay = false;
        }

        private void pokemonListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatingDisplay) return;
            Pokemon newPokemon = (pokedex.PokemonList.Find(p => p.Name == pokemonListComboBox.Text));
            if (newPokemon != null)
                currentPokemon = newPokemon;
            UpdateDisplay();
        }

        private void evolvesFromLabel_Click(object sender, EventArgs e)
        {
            Pokemon newPokemon = pokedex.PokemonList.Find(p => p.Name == evolvesFromLabel.Text);
            if(newPokemon != null)
            {
                currentPokemon = newPokemon;
            }
            pokemonListComboBox.SelectedIndex = pokedex.PokemonList.IndexOf(currentPokemon);
            UpdateDisplay();
        }

        private void evolvesToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatingDisplay) return;
            Pokemon newPokemon = pokedex.PokemonList.Find(p => p.Name == evolvesToComboBox.Text);
            if (newPokemon != null)
            {
                currentPokemon = newPokemon;
            }
            pokemonListComboBox.SelectedIndex = pokedex.PokemonList.IndexOf(currentPokemon);
            UpdateDisplay();
        }
    }
}
