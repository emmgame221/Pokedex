﻿namespace PokedexGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pokemonListComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.attackLabel = new System.Windows.Forms.Label();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.spAttackLabel = new System.Windows.Forms.Label();
            this.spDefenseLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.ability1Label = new System.Windows.Forms.Label();
            this.ability2Label = new System.Windows.Forms.Label();
            this.ability3Label = new System.Windows.Forms.Label();
            this.ablitiesLabel = new System.Windows.Forms.Label();
            this.hiddenAbilityLabel = new System.Windows.Forms.Label();
            this.evolvesFromLabel = new System.Windows.Forms.Label();
            this.evolvesToComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.levelUpMovesListBox = new System.Windows.Forms.ListBox();
            this.tmHmListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pokemonListComboBox
            // 
            this.pokemonListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokemonListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pokemonListComboBox.FormattingEnabled = true;
            this.pokemonListComboBox.Location = new System.Drawing.Point(12, 12);
            this.pokemonListComboBox.Name = "pokemonListComboBox";
            this.pokemonListComboBox.Size = new System.Drawing.Size(121, 28);
            this.pokemonListComboBox.TabIndex = 0;
            this.pokemonListComboBox.SelectedIndexChanged += new System.EventHandler(this.pokemonListComboBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.typeLabel.Location = new System.Drawing.Point(366, 41);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(45, 20);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hpLabel.Location = new System.Drawing.Point(455, 73);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(43, 20);
            this.hpLabel.TabIndex = 3;
            this.hpLabel.Text = "HP: ";
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.attackLabel.Location = new System.Drawing.Point(455, 113);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(66, 20);
            this.attackLabel.TabIndex = 4;
            this.attackLabel.Text = "Attack: ";
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.defenseLabel.Location = new System.Drawing.Point(455, 153);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(82, 20);
            this.defenseLabel.TabIndex = 5;
            this.defenseLabel.Text = "Defense: ";
            // 
            // spAttackLabel
            // 
            this.spAttackLabel.AutoSize = true;
            this.spAttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.spAttackLabel.Location = new System.Drawing.Point(579, 73);
            this.spAttackLabel.Name = "spAttackLabel";
            this.spAttackLabel.Size = new System.Drawing.Size(95, 20);
            this.spAttackLabel.TabIndex = 6;
            this.spAttackLabel.Text = "Sp. Attack: ";
            // 
            // spDefenseLabel
            // 
            this.spDefenseLabel.AutoSize = true;
            this.spDefenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.spDefenseLabel.Location = new System.Drawing.Point(579, 113);
            this.spDefenseLabel.Name = "spDefenseLabel";
            this.spDefenseLabel.Size = new System.Drawing.Size(111, 20);
            this.spDefenseLabel.TabIndex = 7;
            this.spDefenseLabel.Text = "Sp. Defense: ";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.speedLabel.Location = new System.Drawing.Point(579, 153);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(66, 20);
            this.speedLabel.TabIndex = 8;
            this.speedLabel.Text = "Speed: ";
            // 
            // ability1Label
            // 
            this.ability1Label.AutoSize = true;
            this.ability1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ability1Label.Location = new System.Drawing.Point(223, 93);
            this.ability1Label.Name = "ability1Label";
            this.ability1Label.Size = new System.Drawing.Size(63, 20);
            this.ability1Label.TabIndex = 9;
            this.ability1Label.Text = "Ability1";
            // 
            // ability2Label
            // 
            this.ability2Label.AutoSize = true;
            this.ability2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ability2Label.Location = new System.Drawing.Point(223, 113);
            this.ability2Label.Name = "ability2Label";
            this.ability2Label.Size = new System.Drawing.Size(63, 20);
            this.ability2Label.TabIndex = 10;
            this.ability2Label.Text = "Ability2";
            // 
            // ability3Label
            // 
            this.ability3Label.AutoSize = true;
            this.ability3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ability3Label.Location = new System.Drawing.Point(223, 153);
            this.ability3Label.Name = "ability3Label";
            this.ability3Label.Size = new System.Drawing.Size(63, 20);
            this.ability3Label.TabIndex = 11;
            this.ability3Label.Text = "Ability3";
            // 
            // ablitiesLabel
            // 
            this.ablitiesLabel.AutoSize = true;
            this.ablitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ablitiesLabel.Location = new System.Drawing.Point(223, 73);
            this.ablitiesLabel.Name = "ablitiesLabel";
            this.ablitiesLabel.Size = new System.Drawing.Size(78, 20);
            this.ablitiesLabel.TabIndex = 12;
            this.ablitiesLabel.Text = "Abilities: ";
            // 
            // hiddenAbilityLabel
            // 
            this.hiddenAbilityLabel.AutoSize = true;
            this.hiddenAbilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hiddenAbilityLabel.Location = new System.Drawing.Point(223, 133);
            this.hiddenAbilityLabel.Name = "hiddenAbilityLabel";
            this.hiddenAbilityLabel.Size = new System.Drawing.Size(117, 20);
            this.hiddenAbilityLabel.TabIndex = 13;
            this.hiddenAbilityLabel.Text = "Hidden Ability:";
            // 
            // evolvesFromLabel
            // 
            this.evolvesFromLabel.AutoSize = true;
            this.evolvesFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.evolvesFromLabel.Location = new System.Drawing.Point(12, 93);
            this.evolvesFromLabel.Name = "evolvesFromLabel";
            this.evolvesFromLabel.Size = new System.Drawing.Size(111, 20);
            this.evolvesFromLabel.TabIndex = 14;
            this.evolvesFromLabel.Text = "Evolves From";
            this.evolvesFromLabel.Click += new System.EventHandler(this.evolvesFromLabel_Click);
            // 
            // evolvesToComboBox
            // 
            this.evolvesToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.evolvesToComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.evolvesToComboBox.FormattingEnabled = true;
            this.evolvesToComboBox.Location = new System.Drawing.Point(12, 153);
            this.evolvesToComboBox.Name = "evolvesToComboBox";
            this.evolvesToComboBox.Size = new System.Drawing.Size(121, 28);
            this.evolvesToComboBox.TabIndex = 15;
            this.evolvesToComboBox.SelectedIndexChanged += new System.EventHandler(this.evolvesToComboBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameLabel.Location = new System.Drawing.Point(365, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 29);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name";
            // 
            // levelUpMovesListBox
            // 
            this.levelUpMovesListBox.Font = new System.Drawing.Font("Courier New", 10F);
            this.levelUpMovesListBox.FormattingEnabled = true;
            this.levelUpMovesListBox.HorizontalScrollbar = true;
            this.levelUpMovesListBox.ItemHeight = 20;
            this.levelUpMovesListBox.Items.AddRange(new object[] {
            "Level            Name     Type Category   Power Accuracy Effect% PP Description"});
            this.levelUpMovesListBox.Location = new System.Drawing.Point(12, 237);
            this.levelUpMovesListBox.Name = "levelUpMovesListBox";
            this.levelUpMovesListBox.Size = new System.Drawing.Size(752, 244);
            this.levelUpMovesListBox.TabIndex = 17;
            // 
            // tmHmListBox
            // 
            this.tmHmListBox.Font = new System.Drawing.Font("Courier New", 10F);
            this.tmHmListBox.FormattingEnabled = true;
            this.tmHmListBox.HorizontalScrollbar = true;
            this.tmHmListBox.ItemHeight = 20;
            this.tmHmListBox.Items.AddRange(new object[] {
            "TM/HM            Name     Type Category   Power Accuracy Effect% PP Description"});
            this.tmHmListBox.Location = new System.Drawing.Point(12, 487);
            this.tmHmListBox.Name = "tmHmListBox";
            this.tmHmListBox.Size = new System.Drawing.Size(752, 244);
            this.tmHmListBox.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 737);
            this.Controls.Add(this.tmHmListBox);
            this.Controls.Add(this.levelUpMovesListBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.evolvesToComboBox);
            this.Controls.Add(this.evolvesFromLabel);
            this.Controls.Add(this.hiddenAbilityLabel);
            this.Controls.Add(this.ablitiesLabel);
            this.Controls.Add(this.ability3Label);
            this.Controls.Add(this.ability2Label);
            this.Controls.Add(this.ability1Label);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.spDefenseLabel);
            this.Controls.Add(this.spAttackLabel);
            this.Controls.Add(this.defenseLabel);
            this.Controls.Add(this.attackLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.pokemonListComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pokedex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pokemonListComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.Label spAttackLabel;
        private System.Windows.Forms.Label spDefenseLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label ability1Label;
        private System.Windows.Forms.Label ability2Label;
        private System.Windows.Forms.Label ability3Label;
        private System.Windows.Forms.Label ablitiesLabel;
        private System.Windows.Forms.Label hiddenAbilityLabel;
        private System.Windows.Forms.Label evolvesFromLabel;
        private System.Windows.Forms.ComboBox evolvesToComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox levelUpMovesListBox;
        private System.Windows.Forms.ListBox tmHmListBox;
    }
}

