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
        const string DataFileName = @"C:\Users\Eric\Documents\Visual Studio 2015\Projects\Pokedex\GeneratePokedexData\bin\Debug\pokedex.json";

        public MainForm()
        {
            pokedex = JsonConvert.DeserializeObject<PokedexData>(File.ReadAllText(DataFileName));
            currentPokemon = pokedex.PokemonList[0];
            InitializeComponent();
            BindComboBoxes();
        }

        void BindComboBoxes()
        {
            pokemonListComboBox.DataSource = pokedex.PokemonList;
            pokemonListComboBox.DisplayMember = "Name";
        }

        void UpdateDisplay()
        {
            typeLabel.Text = currentPokemon.Type1.ToString();
            if(currentPokemon.Type2 != PokemonType.None)
            {
                typeLabel.Text += " / " + currentPokemon.Type2.ToString();
            }
            hpLabel.Text = string.Format("HP: {0}", currentPokemon.BaseHP);
            attackLabel.Text = string.Format("Attack: {0}", currentPokemon.BaseAttack);
            defenseLabel.Text = string.Format("Defense: {0}", currentPokemon.BaseDefense);
            spAttackLabel.Text = string.Format("Sp. Attack: {0}", currentPokemon.BaseSpecialAttack);
            spDefenseLabel.Text = string.Format("Sp. Defense: {0}", currentPokemon.BaseSpecialDefense);
            speedLabel.Text = string.Format("Speed: {0}", currentPokemon.BaseSpeed);
        }

        private void pokemonListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pokemon newPokemon = (pokedex.PokemonList.Find(p => p.Name == pokemonListComboBox.Text));
            if (newPokemon != null)
                currentPokemon = newPokemon;
            UpdateDisplay();
        }
    }
}
