using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class Form2 : Form
    {
        public class WordItem
        {
            public string Word { get; set; }
            public string Clue { get; set; }

            public WordItem(string word, string clue)
            {
                Word = word;
                Clue = clue;
            }
        }

        Dictionary<string, Dictionary<string, List<WordItem>>> wordBank =
            new Dictionary<string, Dictionary<string, List<WordItem>>>
        {
            { "Matematik", new Dictionary<string, List<WordItem>> {
                { "Kolay", new List<WordItem> {
                    new WordItem("toplama", "Addition"),
                    new WordItem("çıkarma", "Subtraction"),
                    new WordItem("çarpma", "Multiplication"),
                    new WordItem("bölme", "Division"),
                    new WordItem("karekök", "Square root"),
                    new WordItem("faktöriyel", "Factorial"),
                    new WordItem("asal", "Prime number"),
                }},
                { "Orta", new List<WordItem> {
                    new WordItem("üslü", "Exponential"),
                    new WordItem("logaritma", "Logarithm"),
                    new WordItem("integral", "Integral"),
                    new WordItem("türev", "Derivative"),
                    new WordItem("denklem", "Equation"),
                    new WordItem("mod", "Modulus operator"),
                    new WordItem("matris", "Matrix"),
                }},
                { "Zor", new List<WordItem> {
                    new WordItem("limit", "Limit"),
                    new WordItem("vektör", "Vector"),
                    new WordItem("oran", "Ratio"),
                    new WordItem("açı", "Angle"),
                    new WordItem("çember", "Circle"),
                    new WordItem("paralel", "Parallel"),
                }}
            }},
            { "Tarih", new Dictionary<string, List<WordItem>> {
                { "Kolay", new List<WordItem> {
                    new WordItem("osmanli", "Ottoman Empire"),
                    new WordItem("cumhuriyet", "Republic"),
                    new WordItem("kanuni", "Famous sultan"),
                    new WordItem("padişah", "Ruler title"),
                    new WordItem("kurtulus", "War of independence"),
                    new WordItem("meclis", "Assembly"),
                    new WordItem("inkilap", "Revolution"),
                }},
                { "Orta", new List<WordItem> {
                    new WordItem("fatih", "Conqueror"),
                    new WordItem("kapitülasyon", "Economic privilege"),
                    new WordItem("ihtilal", "Rebellion"),
                    new WordItem("misak", "National pact"),
                    new WordItem("istiklal", "Independence"),
                    new WordItem("yeniçeri", "Elite military"),
                    new WordItem("tarih", "History"),
                }},
                { "Zor", new List<WordItem> {
                    new WordItem("şehzade", "Prince"),
                    new WordItem("sadrazam", "Prime minister"),
                    new WordItem("divan", "Council"),
                    new WordItem("fetih", "Conquest"),
                    new WordItem("tanzimat", "Reform era"),
                    new WordItem("hilafet", "Caliphate"),
                }}
            }},
            { "Coğrafya", new Dictionary<string, List<WordItem>> {
                { "Kolay", new List<WordItem> {
                    new WordItem("kıta", "Continent"),
                    new WordItem("okyanus", "Ocean"),
                    new WordItem("nehir", "River"),
                    new WordItem("göl", "Lake"),
                    new WordItem("delta", "Delta"),
                    new WordItem("vadi", "Valley"),
                    new WordItem("çöl", "Desert"),
                }},
                { "Orta", new List<WordItem> {
                    new WordItem("orman", "Forest"),
                    new WordItem("iklim", "Climate"),
                    new WordItem("yerçekimi", "Gravity"),
                    new WordItem("nüfus", "Population"),
                    new WordItem("harita", "Map"),
                    new WordItem("başkent", "Capital"),
                    new WordItem("ülke", "Country"),
                }},
                { "Zor", new List<WordItem> {
                    new WordItem("dağ", "Mountain"),
                    new WordItem("fay", "Fault"),
                    new WordItem("deprem", "Earthquake"),
                    new WordItem("volkan", "Volcano"),
                    new WordItem("yerşekli", "Landform"),
                    new WordItem("yükseklik", "Altitude"),
                }}
            }},
            { "Genel Kültür", new Dictionary<string, List<WordItem>> {
                { "Kolay", new List<WordItem> {
                    new WordItem("sanat", "Art"),
                    new WordItem("müzik", "Music"),
                    new WordItem("edebiyat", "Literature"),
                    new WordItem("tiyatro", "Theater"),
                    new WordItem("film", "Movie"),
                    new WordItem("spor", "Sport"),
                    new WordItem("bilim", "Science"),
                }},
                { "Orta", new List<WordItem> {
                    new WordItem("teknoloji", "Technology"),
                    new WordItem("internet", "Internet"),
                    new WordItem("oyun", "Game"),
                    new WordItem("felsefe", "Philosophy"),
                    new WordItem("mitoloji", "Mythology"),
                    new WordItem("festival", "Festival"),
                    new WordItem("müze", "Museum"),
                }},
                { "Zor", new List<WordItem> {
                    new WordItem("kütüphane", "Library"),
                    new WordItem("resim", "Painting"),
                    new WordItem("heykel", "Sculpture"),
                    new WordItem("gazete", "Newspaper"),
                    new WordItem("radyo", "Radio"),
                    new WordItem("sinema", "Cinema"),
                }}
            }}
        };

        private string selectedCategory;
        private int timeLeft;
        private Timer countdownTimer = new Timer();

        string selectedWord;
        string displayWord;
        List<char> incorrectLetters = new List<char>();
        int score = 100;
        int wrongGuesses = 0;

        public Form2(string category)
        {
            InitializeComponent();
            selectedCategory = category;

            lblGameInfo.Text = $"Kategori: {selectedCategory} - Zorluk: {GameSettings.Difficulty} - Süre: {GameSettings.TimeLimit} min";

            timeLeft = GameSettings.TimeLimit;
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();

            string difficulty = GameSettings.Difficulty;

            if (!wordBank.ContainsKey(selectedCategory) || !wordBank[selectedCategory].ContainsKey(difficulty))
            {
                MessageBox.Show("No word found for selected category and difficulty.");
                this.Close();
                return;
            }

            List<WordItem> list = wordBank[selectedCategory][difficulty];
            Random rnd = new Random();
            WordItem selected = list[rnd.Next(list.Count)];

            selectedWord = selected.Word.ToLower();
            displayWord = new string('_', selectedWord.Length);
            lblClue.Text = selected.Clue;
            lblWordProgress.Text = string.Join(" ", displayWord.ToCharArray());

            lblWrongGuesses.Text = "Wrong Letters: ";
            lblScore.Text = "Score: " + score;

            UpdateHangmanImage(0);
        }

        public Form2()
        {
            InitializeComponent();

            selectedWord = "fallback";
            displayWord = new string('_', selectedWord.Length);
            lblClue.Text = "This is a fallback word";
            lblWordProgress.Text = string.Join(" ", displayWord.ToCharArray());
            lblWrongGuesses.Text = "Wrong Letters: ";
            lblScore.Text = "Score: " + score;

            timeLeft = timeLeft = GameSettings.TimeLimit;
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();

            lblGameInfo.Text = $"Kategori: {selectedCategory} - Zorluk: {GameSettings.Difficulty} - Süre: {GameSettings.TimeLimit} sec";

            UpdateHangmanImage(0);
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = $"Kalan Süre: {timeLeft} sec";

            if (timeLeft <= 0)
            {
                countdownTimer.Stop();
                MessageBox.Show("Süre doldu! Kaybettiniz.");
                this.BackColor = Color.Red;
                btnGuess.Enabled = false;
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (txtGuess.Text.Length == 0) return;

            char guess = char.ToLower(txtGuess.Text[0]);
            txtGuess.Clear();

            if (selectedWord.Contains(guess))
            {
                char[] temp = displayWord.ToCharArray();
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == guess)
                    {
                        temp[i] = guess;
                    }
                }
                displayWord = new string(temp);
                lblWordProgress.Text = string.Join(" ", displayWord.ToCharArray());
            }
            else if (!incorrectLetters.Contains(guess))
            {
                incorrectLetters.Add(guess);
                wrongGuesses++;
                score -= 10;
                lblWrongGuesses.Text = "Wrong Letters: " + string.Join(", ", incorrectLetters);
                lblScore.Text = "Score: " + score;

                string theme = GameSettings.ImageTheme;

                switch (theme)
                {
                    case "Adam As":
                        switch (wrongGuesses)
                        {
                            case 1: picHangman.Image = Properties.Resources.man_01; break;
                            case 2: picHangman.Image = Properties.Resources.man_02; break;
                            case 3: picHangman.Image = Properties.Resources.man_03; break;
                            case 4: picHangman.Image = Properties.Resources.man_04; break;
                            case 5: picHangman.Image = Properties.Resources.man_05; break;
                            case 6: picHangman.Image = Properties.Resources.man_06; break;
                            case 7: picHangman.Image = Properties.Resources.man_07; break;
                            case 8: picHangman.Image = Properties.Resources.man_08; break;
                            case 9: picHangman.Image = Properties.Resources.man_09; break;
                            case 10: picHangman.Image = Properties.Resources.man_10; break;
                        }
                        break;

                    case "Çöp Adam":
                        switch (wrongGuesses)
                        {
                            case 1: picHangman.Image = Properties.Resources.palon_01; break;
                            case 2: picHangman.Image = Properties.Resources.palon_02; break;
                            case 3: picHangman.Image = Properties.Resources.palon_03; break;
                            case 4: picHangman.Image = Properties.Resources.palon_04; break;
                            case 5: picHangman.Image = Properties.Resources.palon_05; break;
                            case 6: picHangman.Image = Properties.Resources.palon_06; break;
                            case 7: picHangman.Image = Properties.Resources.palon_07; break;
                            case 8: picHangman.Image = Properties.Resources.palon_08; break;
                            case 9: picHangman.Image = Properties.Resources.palon_09; break;
                            case 10: picHangman.Image = Properties.Resources.palon_10; break;
                        }
                        break;

                    case "Çiçek":
                        switch (wrongGuesses)
                        {
                            case 1: picHangman.Image = Properties.Resources.flour_01; break;
                            case 2: picHangman.Image = Properties.Resources.flour_02; break;
                            case 3: picHangman.Image = Properties.Resources.flour_03; break;
                            case 4: picHangman.Image = Properties.Resources.flour_04; break;
                            case 5: picHangman.Image = Properties.Resources.flour_05; break;
                            case 6: picHangman.Image = Properties.Resources.flour_06; break;
                            case 7: picHangman.Image = Properties.Resources.flour_07; break;
                            case 8: picHangman.Image = Properties.Resources.flour_08; break;
                            case 9: picHangman.Image = Properties.Resources.flour_09; break;
                            case 10: picHangman.Image = Properties.Resources.flour_10; break;
                        }
                        break;
                }
                }

                if (!displayWord.Contains('_'))
            {
                countdownTimer.Stop();
                MessageBox.Show("You Win!");
                this.BackColor = Color.Green;
                btnGuess.Enabled = false;
            }

            if (wrongGuesses == 6)
            {
                countdownTimer.Stop();
                MessageBox.Show($"You Lose! The word was: {selectedWord}");
                this.BackColor = Color.Red;
                btnGuess.Enabled = false;
            }
        }

        private void UpdateHangmanImage(int stage)
        {
            try
            {
                string theme = GameSettings.ImageTheme.ToLower().Replace(" ", "");
                string resourceName = theme + stage;
                picHangman.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
            }
            catch
            {
                picHangman.Image = Properties.Resources.man_01;
            }
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to end the game?", "End Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picHangman_Click(object sender, EventArgs e) { }
        private void lblWordProgress_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblWrongGuesses_Click(object sender, EventArgs e) { }
        private void lblScore_Click(object sender, EventArgs e) { }
        private void lblClue_Click(object sender, EventArgs e) { }
        private void lblTimer_Click(object sender, EventArgs e) { }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
