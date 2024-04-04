namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            if (radioButton1.Checked)
            {
                textBox1.Text.ToLower();
                foreach (char c in textBox1.Text)
                {
                    textBox2.Text += alphabet[c] + "/";
                }
            }
            else
            {
                foreach (char c in textBox1.Text)
                {
                    textBox2.Text +=// (c == ' ') ?
                 ((char)(c + numericUpDown1.Value)); //: ' ';
                }
            }

        }

        Dictionary<char, string> alphabet = new Dictionary<char, string>() {

 {'a', ".-/"},
            {'b', "-.../"},
            {'c', "-.-./"},
            {'d', "-../"},
            {'e', "./"},
            {'f', "..-./"},
            {'g', "--./"},
            {'h', "..../"},
            {'i', "../"},
            {'j', ".---/"},
            {'k', "-.-/"},
            {'l', ".-../"},
            {'m', "--/"},
            {'n', "-./"},
            {'o', "---/"},
            {'p', ".--./"},
            {'q', "--.-/"},
            {'r', ".-./"},
            {'s', ".../"},
            {'t', "-/"},
            {'u', "..-/"},
            {'v', "...-/"},
            {'w', ".--/"},
            {'x', "-..-/"},
            {'y', "-.--/"},
            {'z', "--../"},
            {'0', "-----/"},
            {'1', ".----/"},
            {'2', "..---/"},
            {'3', "...--/"},
            {'4', "....-/"},
            {'5', "...../"},
            {'6', "-..../"},
            {'7', "--.../"},
            {'8', "---../"},
            {'9', "----./"},
            {' ', "/"},
            {'.', "//"},
            {'\n', "///"}

        };
        Dictionary<string, char> alphabetM = new Dictionary<string, char>() {

            {".-/", 'a'},
            {"-.../", 'b'},
            {"-.-./", 'c'},
            {"-../", 'd'},
            {"./", 'e'},
            {"..-./", 'f'},
            {"--./", 'g'},
            {"..../", 'h'},
            {"../", 'i'},
            {".---/", 'j'},
            {"-.-/", 'k'},
            {".-../", 'l'},
            {"--/", 'm'},
            {"-./", 'n'},
            {"---/", 'o'},
            {".--./", 'p'},
            {"--.-/", 'q'},
            {".-./", 'r'},
            {".../", 's'},
            {"-/", 't'},
            {"..-/", 'u'},
            {"...-/", 'v'},
            {".--/", 'w'},
            {"-..-/", 'x'},
            {"-.--/", 'y'},
            {"--../", 'z'},
            {"-----/", '0'},
            {".----/", '1'},
            {"..---/", '2'},
            {"...--/", '3'},
            {"....-/", '4'},
            {"...../", '5'},
            {"-..../", '6'},
            {"--.../", '7'},
            {"---../", '8'},
            {"----./", '9'},
            {"/", ' '},
            {"//", '.'},
            {"///", '\n'}

        };

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            if (radioButton1.Checked)
            {
                textBox1.Text.ToLower();
                foreach (string c in textBox1.Text.Split('/'))
                {

                    textBox2.Text += alphabetM[c + "/"];
                }
            }
            else
            {
                foreach (char c in textBox1.Text)
                {
                    textBox2.Text += (c == 'a'|| c == 'A') ? (char)('z' - numericUpDown1.Value) : (c == 'z' || c == 'Z') ? (char)('a' - numericUpDown1.Value) : (c != ' ') ? ((char)(c - numericUpDown1.Value)) : ' ';

                }
            }
        }
    }
}