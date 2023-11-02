namespace Powerball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            LinkedList<int> winningNumbers = new LinkedList<int>();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                winningNumbers.AddLast(random.Next(1, 70));
            }
            winningNumbers.AddLast(random.Next(1, 27));

            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(int.Parse(textBox1.Text));
            numbers.AddLast(int.Parse(textBox2.Text));
            numbers.AddLast(int.Parse(textBox3.Text));
            numbers.AddLast(int.Parse(textBox4.Text));
            numbers.AddLast(int.Parse(textBox5.Text));
            numbers.AddLast(int.Parse(textBox6.Text));

            bool wonPowerball = false;
            int numMatches = 0;
            if (winningNumbers.Last == numbers.Last)
            {
                wonPowerball = true;
            }
            if (wonPowerball == true)
            {
                foreach (int i in winningNumbers)
                {
                    if (numbers.Contains(i))
                    {
                        ++numMatches;
                    }
                }
            }
            String message;
            resultMessage.BackColor = Color.Green;
            if (!wonPowerball && numMatches == 0)
            {
                resultMessage.BackColor = Color.Red;
                message = "NO MATCHES";

            }
            else if (wonPowerball == true && numMatches == 0)
            {
                message = "YOU WON THE POWERBALL";
            }
            else if (!wonPowerball)
            {
                message = "YOU WON WITH " + numMatches + " MATCHES";
            }
            else
            {
                message = "YOU WON WITH " + numMatches + " MATCHES AND THE POWERBALL";
            }
            resultMessage.Text = message;
        }
    }
}