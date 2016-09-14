namespace PokedexGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pokemonListComboBox = new System.Windows.Forms.ComboBox();
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokedexDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.attackLabel = new System.Windows.Forms.Label();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.spAttackLabel = new System.Windows.Forms.Label();
            this.spDefenseLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokedexDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemonListComboBox
            // 
            this.pokemonListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokemonListComboBox.FormattingEnabled = true;
            this.pokemonListComboBox.Location = new System.Drawing.Point(12, 28);
            this.pokemonListComboBox.Name = "pokemonListComboBox";
            this.pokemonListComboBox.Size = new System.Drawing.Size(121, 24);
            this.pokemonListComboBox.TabIndex = 0;
            this.pokemonListComboBox.SelectedIndexChanged += new System.EventHandler(this.pokemonListComboBox_SelectedIndexChanged);
            // 
            // pokemonBindingSource
            // 
            this.pokemonBindingSource.DataSource = typeof(Pokedex.Pokemon);
            // 
            // pokedexDataBindingSource
            // 
            this.pokedexDataBindingSource.DataSource = typeof(Pokedex.PokedexData);
            // 
            // pokemonListBindingSource
            // 
            this.pokemonListBindingSource.DataMember = "PokemonList";
            this.pokemonListBindingSource.DataSource = this.pokedexDataBindingSource;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 69);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 17);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(158, 35);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(35, 17);
            this.hpLabel.TabIndex = 3;
            this.hpLabel.Text = "HP: ";
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Location = new System.Drawing.Point(158, 69);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(55, 17);
            this.attackLabel.TabIndex = 4;
            this.attackLabel.Text = "Attack: ";
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Location = new System.Drawing.Point(158, 107);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(69, 17);
            this.defenseLabel.TabIndex = 5;
            this.defenseLabel.Text = "Defense: ";
            // 
            // spAttackLabel
            // 
            this.spAttackLabel.AutoSize = true;
            this.spAttackLabel.Location = new System.Drawing.Point(158, 143);
            this.spAttackLabel.Name = "spAttackLabel";
            this.spAttackLabel.Size = new System.Drawing.Size(80, 17);
            this.spAttackLabel.TabIndex = 6;
            this.spAttackLabel.Text = "Sp. Attack: ";
            // 
            // spDefenseLabel
            // 
            this.spDefenseLabel.AutoSize = true;
            this.spDefenseLabel.Location = new System.Drawing.Point(158, 178);
            this.spDefenseLabel.Name = "spDefenseLabel";
            this.spDefenseLabel.Size = new System.Drawing.Size(94, 17);
            this.spDefenseLabel.TabIndex = 7;
            this.spDefenseLabel.Text = "Sp. Defense: ";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(158, 213);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(57, 17);
            this.speedLabel.TabIndex = 8;
            this.speedLabel.Text = "Speed: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 329);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.spDefenseLabel);
            this.Controls.Add(this.spAttackLabel);
            this.Controls.Add(this.defenseLabel);
            this.Controls.Add(this.attackLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.pokemonListComboBox);
            this.Name = "MainForm";
            this.Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokedexDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pokemonListComboBox;
        private System.Windows.Forms.BindingSource pokemonListBindingSource;
        private System.Windows.Forms.BindingSource pokedexDataBindingSource;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.Label spAttackLabel;
        private System.Windows.Forms.Label spDefenseLabel;
        private System.Windows.Forms.Label speedLabel;
    }
}

