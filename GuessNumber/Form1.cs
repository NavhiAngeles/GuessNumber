namespace GuessNumber
{
    public partial class Form1 : Form
    {
        private int randomNumber;

        public Form1()
        {
            InitializeComponent();
            GenerateRandomNumber();
        }

        private void GenerateRandomNumber()
        {
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 10);
        }

        private void GuessBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void enter_Click(object sender, EventArgs e)
        {
            int userGuess;

            if (!int.TryParse(GuessBox.Text, out userGuess))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            if (userGuess < 1 || userGuess > 10)
            {
                MessageBox.Show("Please guess a number between 1 and 10.");
                return;
            }

            if (userGuess < randomNumber)
            {
                MessageBox.Show("Too low! Try again.");
            }
            else if (userGuess > randomNumber)
            {
                MessageBox.Show("Too high! Try again.");
            }
            else
            {

                AnswerBox.Text = randomNumber.ToString();
                MessageBox.Show("Correct! You guessed the number 🎉");
                

                GuessBox.Clear();
                AnswerBox.Clear();
                GenerateRandomNumber();
                GuessBox.Focus();
            }
        }
    }
}
