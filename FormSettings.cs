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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            cmbDifficulty.Items.AddRange(new string[] { "Kolay", "Orta", "Zor" });
            cmbImageTheme.Items.AddRange(new string[] { "Adam As", "Çöp Adam", "Çiçek" });

            cmbDifficulty.SelectedIndex = 0;
            cmbImageTheme.SelectedIndex = 0;
            numTimeLimit.Minimum = 10;
            numTimeLimit.Maximum = 180;
            numTimeLimit.Value = 30;

        }

        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbImageTheme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numTimeLimit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            GameSettings.TimeLimit = (int)numTimeLimit.Value;
            GameSettings.Difficulty = cmbDifficulty.SelectedItem.ToString();
            GameSettings.ImageTheme = cmbImageTheme.SelectedItem.ToString();

            // Optionally display a confirmation message
            MessageBox.Show("Ayarlar kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Close settings form

        }
    }
    public static class GameSettings
    {
        public static int TimeLimit = 30;
        public static string Difficulty = "Kolay";
        public static string ImageTheme = "Adam As";
    }
}
