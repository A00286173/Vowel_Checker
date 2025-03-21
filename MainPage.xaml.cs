using Microsoft.Maui.Controls;

namespace VowelChecker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCheckVowelClicked(object sender, EventArgs e)
        {
            // Get the user input from the Entry
            string input = LetterEntry.Text;

            // Basic validation
            if (string.IsNullOrWhiteSpace(input))
            {
                ResultLabel.Text = "Please enter a letter.";
                return;
            }

            // Take only the first character
            char letter = input[0];
                
            // Convert to lowercase to check easily
            char lowerCaseLetter = char.ToLower(letter);

            // Check if it's a letter
            if (!char.IsLetter(letter))
            {
                ResultLabel.Text = $"{letter} is not a valid alphabet character.";
                return;
            }

            // Use either an if/else or switch; here's a switch example:
            switch (lowerCaseLetter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    ResultLabel.Text = $"{letter} is a vowel.";
                    break;
                default:
                    ResultLabel.Text = $"{letter} is not a vowel.";
                    break;
            }
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            // Clear the Entry field and the result to allow another check
            LetterEntry.Text = string.Empty;
            ResultLabel.Text = "Result will appear here";
        }
    }
}
