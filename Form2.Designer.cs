namespace HangmanGame
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.picHangman = new System.Windows.Forms.PictureBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblWordProgress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWrongGuesses = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblClue = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHangman
            // 
            this.picHangman.Location = new System.Drawing.Point(454, 30);
            this.picHangman.Name = "picHangman";
            this.picHangman.Size = new System.Drawing.Size(704, 503);
            this.picHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHangman.TabIndex = 0;
            this.picHangman.TabStop = false;
            this.picHangman.Click += new System.EventHandler(this.picHangman_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(44, 305);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(62, 22);
            this.txtGuess.TabIndex = 1;
            // 
            // lblWordProgress
            // 
            this.lblWordProgress.AutoSize = true;
            this.lblWordProgress.Location = new System.Drawing.Point(70, 31);
            this.lblWordProgress.Name = "lblWordProgress";
            this.lblWordProgress.Size = new System.Drawing.Size(268, 17);
            this.lblWordProgress.TabIndex = 2;
            this.lblWordProgress.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            this.lblWordProgress.Click += new System.EventHandler(this.lblWordProgress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clue111:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWrongGuesses
            // 
            this.lblWrongGuesses.AutoSize = true;
            this.lblWrongGuesses.Location = new System.Drawing.Point(20, 148);
            this.lblWrongGuesses.Name = "lblWrongGuesses";
            this.lblWrongGuesses.Size = new System.Drawing.Size(102, 17);
            this.lblWrongGuesses.TabIndex = 4;
            this.lblWrongGuesses.Text = "Wrong Letters:";
            this.lblWrongGuesses.Click += new System.EventHandler(this.lblWrongGuesses_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(41, 272);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(84, 17);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Points: 70 P";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblClue
            // 
            this.lblClue.AutoSize = true;
            this.lblClue.Location = new System.Drawing.Point(41, 225);
            this.lblClue.Name = "lblClue";
            this.lblClue.Size = new System.Drawing.Size(40, 17);
            this.lblClue.TabIndex = 6;
            this.lblClue.Text = "Clue:";
            this.lblClue.Click += new System.EventHandler(this.lblClue_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(139, 291);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(96, 50);
            this.btnGuess.TabIndex = 7;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.Location = new System.Drawing.Point(244, 157);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(120, 23);
            this.btnEndGame.TabIndex = 8;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlayAgain);
            this.groupBox1.Controls.Add(this.lblTimer);
            this.groupBox1.Controls.Add(this.lblGameInfo);
            this.groupBox1.Controls.Add(this.txtGuess);
            this.groupBox1.Controls.Add(this.btnEndGame);
            this.groupBox1.Controls.Add(this.btnGuess);
            this.groupBox1.Controls.Add(this.lblClue);
            this.groupBox1.Controls.Add(this.lblWordProgress);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblWrongGuesses);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 503);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(20, 413);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(46, 17);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "label2";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.Location = new System.Drawing.Point(20, 373);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(46, 17);
            this.lblGameInfo.TabIndex = 9;
            this.lblGameInfo.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(244, 237);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(120, 42);
            this.btnPlayAgain.TabIndex = 11;
            this.btnPlayAgain.Text = "play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picHangman);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHangman;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblWordProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWrongGuesses;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblClue;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}