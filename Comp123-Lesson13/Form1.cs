using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp123_Lesson13
{
    public partial class GeneratorForm : Form
    {
        //Private Instance Variable
        Random _random;

        private TextBox _firstAbility;
        private TextBox _secondAbility;
        public GeneratorForm()
        {
            InitializeComponent();
        }
        private Int32 Roll()
        {
            //Create Empty List
            List<Int32> numbers = new List<Int32>();
            int result = 0;

            //Roll 4 Dice        
            for  (int count = 0; count < 4; count++)
            {
                int generatedNumber = this._random.Next(0, 6) + 1;
                numbers.Add(generatedNumber);
            }
            //drop lowest dice
            numbers.Remove(numbers.Min());

            //add the numbers to the result
            foreach(int number in numbers)
            {
                result += number;
            }
            //Lambda Expression Equivalent
            //result = numbers.Sum(number => number);

            return result;
        }
        private void GenerateAbilities()
        {
            StrengthBox.Text = this.Roll().ToString();
            DexterityBox.Text = this.Roll().ToString();
            ConstitutionBox.Text = this.Roll().ToString();
            IntelligenceBox.Text = this.Roll().ToString();
            WisdomBox.Text = this.Roll().ToString();
            CharismaBox.Text = this.Roll().ToString();

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateAbilities();
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            this._random = new Random();

            GenerateAbilities();

            FirstAbilityComboBox.SelectedIndex = 0;
            SecondAbilityComboBox.SelectedIndex = 0;
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            string temporaryAbility;
            temporaryAbility = this._firstAbility.Text;
            this._firstAbility.Text = this._secondAbility.Text;
            this._secondAbility.Text = temporaryAbility;
        }
        private TextBox ChooseAbility (int selectedAbility)
        {
            TextBox textbox = new TextBox();
            switch(selectedAbility)
            {
                case (int)Ability.Strength:
                    break;
                    textbox = StrengthBox;
                case (int)Ability.Dexterity:
                    break;
                    textbox = DexterityBox;
                case (int)Ability.Constitution:
                    break;
                    textbox = ConstitutionBox;
                case (int)Ability.Intelligence:
                    break;
                    textbox = IntelligenceBox;
                case (int)Ability.Wisdom:
                    break;
                    textbox = WisdomBox;
                case (int)Ability.Charisma:
                    break;
                    textbox = CharismaBox;
            }
            return textbox;
        }

        private void CharismaLabel(object sender, EventArgs e)
        {

        }

        private void FirstAbilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //making reference to the first ability selected
            this._firstAbility = ChooseAbility(FirstAbilityComboBox.SelectedIndex);
        }

        private void SecondAbilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //making reference to the second ability selected

            this._secondAbility = ChooseAbility(SecondAbilityComboBox.SelectedIndex);

        }
    }
}
