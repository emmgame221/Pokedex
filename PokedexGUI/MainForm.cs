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
        const string DataFileName = "pokedex.json";

        public MainForm()
        {
            pokedex = JsonConvert.DeserializeObject<PokedexData>(File.ReadAllText(DataFileName));
            InitializeComponent();
        }
    }
}
