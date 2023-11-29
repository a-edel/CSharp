namespace String_Reverser_Word_Stacks_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string chuckNorrisJoke = JokeTextBox.Text;
            string reversedChuckNorrisJoke = ReverseWords(chuckNorrisJoke);
            ReversedJokeLabel.Text = reversedChuckNorrisJoke;
        }

        private string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Stack<char> charStack = new Stack<char>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (currentWord != "" && currentWord != null)
                {
                    char[] chars = currentWord.ToCharArray();

                    char lastChar = chars[chars.Length - 1];
                    if (lastChar == ',' || lastChar == '.' || lastChar == '?')
                        charStack.Push(chars[chars.Length - 1]);

                    foreach (char c in chars)
                    {
                        if (c != ',' && c != '.' && c != '?')
                            charStack.Push(c);
                    }
                    for (int j = 0; j < chars.Length; j++)
                    {
                        chars[j] = charStack.Pop();
                    }

                    words[i] = new string(chars);
                }
            }
            return string.Join(" ", words);
        }

        private void getJokesButton_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Avrumy\\source\\repos\\String Reverser Word Stacks GUI\\String Reverser Word Stacks GUI\\Chuck Norris Jokes.txt";
            string reversedJokes = "";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    string reversedLine;
                    while ((line = reader.ReadLine()) != null)
                    {
                        reversedJokes += ReverseWords(line) + "\n";
                    }
                    ReversedJokesFromFileLabel.Text = reversedJokes;
                }
            }
            catch (IOException ex)
            {

            }
        }
    }
}