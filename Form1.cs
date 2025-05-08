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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picHangman.Image = Properties.Resources.cover2;

            // picHangman.Image = Image.FromFile("images/cover2.png");

        }

        private void picHangman_Click(object sender, EventArgs e)
        {
           // picHangman.Image = Image.FromFile("images/cover2.png");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            
                Form2 gameForm = new Form2(); // Create a new instance of the game form
                gameForm.Show();              // Show the game form
                this.Hide();                  // Hide the start screen
            
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedCategory.Text = "Seçilen Kategori: " + cmbCategory.SelectedItem.ToString();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings();
            settings.ShowDialog();

        }

        private void lblSelectedCategory_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.AddRange(new string[] {
        "Tarih", "Coğrafya", "Matematik", "Genel Kültür", "Karma"
    });
            cmbCategory.SelectedIndex = 0; // Default selection
        }
    }
}
