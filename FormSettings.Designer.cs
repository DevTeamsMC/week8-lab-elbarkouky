namespace HangmanGame
{
    partial class FormSettings
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
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.cmbImageTheme = new System.Windows.Forms.ComboBox();
            this.numTimeLimit = new System.Windows.Forms.NumericUpDown();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new System.Drawing.Point(34, 57);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(121, 24);
            this.cmbDifficulty.TabIndex = 0;
            this.cmbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDifficulty_SelectedIndexChanged);
            // 
            // cmbImageTheme
            // 
            this.cmbImageTheme.FormattingEnabled = true;
            this.cmbImageTheme.Location = new System.Drawing.Point(228, 57);
            this.cmbImageTheme.Name = "cmbImageTheme";
            this.cmbImageTheme.Size = new System.Drawing.Size(121, 24);
            this.cmbImageTheme.TabIndex = 1;
            this.cmbImageTheme.SelectedIndexChanged += new System.EventHandler(this.cmbImageTheme_SelectedIndexChanged);
            // 
            // numTimeLimit
            // 
            this.numTimeLimit.Location = new System.Drawing.Point(483, 59);
            this.numTimeLimit.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numTimeLimit.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTimeLimit.Name = "numTimeLimit";
            this.numTimeLimit.Size = new System.Drawing.Size(120, 22);
            this.numTimeLimit.TabIndex = 2;
            this.numTimeLimit.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTimeLimit.ValueChanged += new System.EventHandler(this.numTimeLimit_ValueChanged);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(156, 194);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(319, 23);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "settings and close";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 516);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.numTimeLimit);
            this.Controls.Add(this.cmbImageTheme);
            this.Controls.Add(this.cmbDifficulty);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTimeLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.ComboBox cmbImageTheme;
        private System.Windows.Forms.NumericUpDown numTimeLimit;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}