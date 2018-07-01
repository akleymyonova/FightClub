namespace Fight
{
    partial class PlayerForm
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
            this.roundLabel = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.playerProgressBar = new System.Windows.Forms.ProgressBar();
            this.HitBut = new System.Windows.Forms.Button();
            this.BlockButton = new System.Windows.Forms.Button();
            this.HitComboBox = new System.Windows.Forms.ComboBox();
            this.BlockComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel.Font = new System.Drawing.Font("Old English Text MT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundLabel.Location = new System.Drawing.Point(147, 9);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(196, 57);
            this.roundLabel.TabIndex = 19;
            this.roundLabel.Text = "Round 1";
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerNameLabel.Location = new System.Drawing.Point(180, 76);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(16, 21);
            this.PlayerNameLabel.TabIndex = 21;
            this.PlayerNameLabel.Text = " ";
            // 
            // playerProgressBar
            // 
            this.playerProgressBar.Location = new System.Drawing.Point(137, 127);
            this.playerProgressBar.Name = "playerProgressBar";
            this.playerProgressBar.Size = new System.Drawing.Size(196, 23);
            this.playerProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerProgressBar.TabIndex = 20;
            this.playerProgressBar.Value = 100;
            // 
            // HitBut
            // 
            this.HitBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.HitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HitBut.Location = new System.Drawing.Point(12, 295);
            this.HitBut.Name = "HitBut";
            this.HitBut.Size = new System.Drawing.Size(187, 46);
            this.HitBut.TabIndex = 23;
            this.HitBut.Text = "Ударить";
            this.HitBut.UseVisualStyleBackColor = false;
            this.HitBut.Click += new System.EventHandler(this.HitBut_Click);
            // 
            // BlockButton
            // 
            this.BlockButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockButton.Location = new System.Drawing.Point(257, 295);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(187, 46);
            this.BlockButton.TabIndex = 24;
            this.BlockButton.Text = "Защитить";
            this.BlockButton.UseVisualStyleBackColor = false;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // HitComboBox
            // 
            this.HitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HitComboBox.FormattingEnabled = true;
            this.HitComboBox.Items.AddRange(new object[] {
            "Голова",
            "Корпус",
            "Ноги"});
            this.HitComboBox.Location = new System.Drawing.Point(12, 209);
            this.HitComboBox.Name = "HitComboBox";
            this.HitComboBox.Size = new System.Drawing.Size(187, 24);
            this.HitComboBox.TabIndex = 25;
            // 
            // BlockComboBox
            // 
            this.BlockComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.BlockComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BlockComboBox.FormattingEnabled = true;
            this.BlockComboBox.Items.AddRange(new object[] {
            "Голова",
            "Корпус",
            "Ноги"});
            this.BlockComboBox.Location = new System.Drawing.Point(257, 209);
            this.BlockComboBox.Name = "BlockComboBox";
            this.BlockComboBox.Size = new System.Drawing.Size(187, 24);
            this.BlockComboBox.TabIndex = 26;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 400);
            this.Controls.Add(this.BlockComboBox);
            this.Controls.Add(this.HitComboBox);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.HitBut);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.playerProgressBar);
            this.Controls.Add(this.roundLabel);
            this.Name = "PlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerForm_FormClosed);
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.ProgressBar playerProgressBar;
        private System.Windows.Forms.Button HitBut;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.ComboBox HitComboBox;
        private System.Windows.Forms.ComboBox BlockComboBox;
    }
}