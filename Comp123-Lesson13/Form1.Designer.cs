namespace Comp123_Lesson13
{
    partial class GeneratorForm
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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ConstitutionBox = new System.Windows.Forms.TextBox();
            this.DexterityBox = new System.Windows.Forms.TextBox();
            this.StrengthBox = new System.Windows.Forms.TextBox();
            this.IntelligenceBox = new System.Windows.Forms.TextBox();
            this.WisdomBox = new System.Windows.Forms.TextBox();
            this.CharismaBox = new System.Windows.Forms.TextBox();
            this.AbilitiesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.ConstitutionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CharismaLabell = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FirstAbilityComboBox = new System.Windows.Forms.ComboBox();
            this.SecondAbilityComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SwapButton = new System.Windows.Forms.Button();
            this.SwapAbilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.SwapAbilitiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 29);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(87, 26);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ConstitutionBox
            // 
            this.ConstitutionBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstitutionBox.Location = new System.Drawing.Point(3, 202);
            this.ConstitutionBox.Name = "ConstitutionBox";
            this.ConstitutionBox.Size = new System.Drawing.Size(100, 43);
            this.ConstitutionBox.TabIndex = 1;
            // 
            // DexterityBox
            // 
            this.DexterityBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexterityBox.Location = new System.Drawing.Point(2, 114);
            this.DexterityBox.Name = "DexterityBox";
            this.DexterityBox.Size = new System.Drawing.Size(100, 43);
            this.DexterityBox.TabIndex = 2;
            // 
            // StrengthBox
            // 
            this.StrengthBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthBox.Location = new System.Drawing.Point(3, 563);
            this.StrengthBox.Name = "StrengthBox";
            this.StrengthBox.Size = new System.Drawing.Size(100, 43);
            this.StrengthBox.TabIndex = 3;
            // 
            // IntelligenceBox
            // 
            this.IntelligenceBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntelligenceBox.Location = new System.Drawing.Point(2, 287);
            this.IntelligenceBox.Name = "IntelligenceBox";
            this.IntelligenceBox.Size = new System.Drawing.Size(100, 43);
            this.IntelligenceBox.TabIndex = 4;
            // 
            // WisdomBox
            // 
            this.WisdomBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisdomBox.Location = new System.Drawing.Point(2, 372);
            this.WisdomBox.Name = "WisdomBox";
            this.WisdomBox.Size = new System.Drawing.Size(100, 43);
            this.WisdomBox.TabIndex = 5;
            // 
            // CharismaBox
            // 
            this.CharismaBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharismaBox.Location = new System.Drawing.Point(2, 470);
            this.CharismaBox.Name = "CharismaBox";
            this.CharismaBox.Size = new System.Drawing.Size(100, 43);
            this.CharismaBox.TabIndex = 6;
            // 
            // AbilitiesLabel
            // 
            this.AbilitiesLabel.AutoSize = true;
            this.AbilitiesLabel.Location = new System.Drawing.Point(29, 9);
            this.AbilitiesLabel.Name = "AbilitiesLabel";
            this.AbilitiesLabel.Size = new System.Drawing.Size(56, 17);
            this.AbilitiesLabel.TabIndex = 7;
            this.AbilitiesLabel.Text = "Abilities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Strength";
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexterityLabel.Location = new System.Drawing.Point(-4, 69);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(131, 36);
            this.DexterityLabel.TabIndex = 9;
            this.DexterityLabel.Text = "Dexterity";
            // 
            // ConstitutionLabel
            // 
            this.ConstitutionLabel.AutoSize = true;
            this.ConstitutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstitutionLabel.Location = new System.Drawing.Point(-4, 158);
            this.ConstitutionLabel.Name = "ConstitutionLabel";
            this.ConstitutionLabel.Size = new System.Drawing.Size(174, 36);
            this.ConstitutionLabel.TabIndex = 10;
            this.ConstitutionLabel.Text = "Constitution";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-4, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Intelligence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wisdom";
            // 
            // CharismaLabell
            // 
            this.CharismaLabell.AutoSize = true;
            this.CharismaLabell.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharismaLabell.Location = new System.Drawing.Point(-4, 418);
            this.CharismaLabell.Name = "CharismaLabell";
            this.CharismaLabell.Size = new System.Drawing.Size(140, 36);
            this.CharismaLabell.TabIndex = 13;
            this.CharismaLabell.Text = "Charisma";
            this.CharismaLabell.Click += new System.EventHandler(this.CharismaLabel);
            // 
            // FirstAbilityComboBox
            // 
            this.FirstAbilityComboBox.BackColor = System.Drawing.Color.White;
            this.FirstAbilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstAbilityComboBox.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstAbilityComboBox.FormattingEnabled = true;
            this.FirstAbilityComboBox.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.FirstAbilityComboBox.Location = new System.Drawing.Point(0, 116);
            this.FirstAbilityComboBox.Name = "FirstAbilityComboBox";
            this.FirstAbilityComboBox.Size = new System.Drawing.Size(205, 46);
            this.FirstAbilityComboBox.TabIndex = 0;
            this.FirstAbilityComboBox.SelectedIndexChanged += new System.EventHandler(this.FirstAbilityComboBox_SelectedIndexChanged);
            // 
            // SecondAbilityComboBox
            // 
            this.SecondAbilityComboBox.BackColor = System.Drawing.Color.White;
            this.SecondAbilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecondAbilityComboBox.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondAbilityComboBox.FormattingEnabled = true;
            this.SecondAbilityComboBox.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.SecondAbilityComboBox.Location = new System.Drawing.Point(226, 116);
            this.SecondAbilityComboBox.Name = "SecondAbilityComboBox";
            this.SecondAbilityComboBox.Size = new System.Drawing.Size(208, 46);
            this.SecondAbilityComboBox.TabIndex = 1;
            this.SecondAbilityComboBox.SelectedIndexChanged += new System.EventHandler(this.SecondAbilityComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Ability";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Second Ability";
            // 
            // SwapButton
            // 
            this.SwapButton.Location = new System.Drawing.Point(181, 318);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(134, 42);
            this.SwapButton.TabIndex = 15;
            this.SwapButton.Text = "Swap";
            this.SwapButton.UseVisualStyleBackColor = true;
            this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // SwapAbilitiesGroupBox
            // 
            this.SwapAbilitiesGroupBox.Controls.Add(this.SwapButton);
            this.SwapAbilitiesGroupBox.Controls.Add(this.label3);
            this.SwapAbilitiesGroupBox.Controls.Add(this.label1);
            this.SwapAbilitiesGroupBox.Controls.Add(this.SecondAbilityComboBox);
            this.SwapAbilitiesGroupBox.Controls.Add(this.FirstAbilityComboBox);
            this.SwapAbilitiesGroupBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapAbilitiesGroupBox.Location = new System.Drawing.Point(189, 29);
            this.SwapAbilitiesGroupBox.Name = "SwapAbilitiesGroupBox";
            this.SwapAbilitiesGroupBox.Size = new System.Drawing.Size(440, 366);
            this.SwapAbilitiesGroupBox.TabIndex = 14;
            this.SwapAbilitiesGroupBox.TabStop = false;
            this.SwapAbilitiesGroupBox.Text = "Swap Abilities";
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 618);
            this.Controls.Add(this.SwapAbilitiesGroupBox);
            this.Controls.Add(this.CharismaLabell);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConstitutionLabel);
            this.Controls.Add(this.DexterityLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AbilitiesLabel);
            this.Controls.Add(this.CharismaBox);
            this.Controls.Add(this.WisdomBox);
            this.Controls.Add(this.IntelligenceBox);
            this.Controls.Add(this.StrengthBox);
            this.Controls.Add(this.DexterityBox);
            this.Controls.Add(this.ConstitutionBox);
            this.Controls.Add(this.GenerateButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GeneratorForm";
            this.Text = "Generator";
            this.Load += new System.EventHandler(this.GeneratorForm_Load);
            this.SwapAbilitiesGroupBox.ResumeLayout(false);
            this.SwapAbilitiesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox ConstitutionBox;
        private System.Windows.Forms.TextBox DexterityBox;
        private System.Windows.Forms.TextBox StrengthBox;
        private System.Windows.Forms.TextBox IntelligenceBox;
        private System.Windows.Forms.TextBox WisdomBox;
        private System.Windows.Forms.TextBox CharismaBox;
        private System.Windows.Forms.Label AbilitiesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Label ConstitutionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CharismaLabell;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox FirstAbilityComboBox;
        private System.Windows.Forms.ComboBox SecondAbilityComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SwapButton;
        private System.Windows.Forms.GroupBox SwapAbilitiesGroupBox;
    }
}

