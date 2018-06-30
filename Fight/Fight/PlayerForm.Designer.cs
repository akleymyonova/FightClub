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
            this.label1 = new System.Windows.Forms.Label();
            this.playerProgressBar = new System.Windows.Forms.ProgressBar();
            this.PlLegsBut = new System.Windows.Forms.Button();
            this.PlBodyBut = new System.Windows.Forms.Button();
            this.PlHeadBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel.Font = new System.Drawing.Font("Old English Text MT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundLabel.Location = new System.Drawing.Point(122, 9);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(196, 57);
            this.roundLabel.TabIndex = 19;
            this.roundLabel.Text = "Round 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(155, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = " ";
            // 
            // playerProgressBar
            // 
            this.playerProgressBar.Location = new System.Drawing.Point(112, 127);
            this.playerProgressBar.Name = "playerProgressBar";
            this.playerProgressBar.Size = new System.Drawing.Size(196, 23);
            this.playerProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerProgressBar.TabIndex = 20;
            this.playerProgressBar.Value = 100;
            // 
            // PlLegsBut
            // 
            this.PlLegsBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PlLegsBut.Enabled = false;
            this.PlLegsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlLegsBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlLegsBut.Location = new System.Drawing.Point(121, 364);
            this.PlLegsBut.Name = "PlLegsBut";
            this.PlLegsBut.Size = new System.Drawing.Size(187, 65);
            this.PlLegsBut.TabIndex = 24;
            this.PlLegsBut.Text = "Ноги";
            this.PlLegsBut.UseVisualStyleBackColor = false;
            // 
            // PlBodyBut
            // 
            this.PlBodyBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PlBodyBut.Enabled = false;
            this.PlBodyBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlBodyBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlBodyBut.Location = new System.Drawing.Point(121, 265);
            this.PlBodyBut.Name = "PlBodyBut";
            this.PlBodyBut.Size = new System.Drawing.Size(187, 65);
            this.PlBodyBut.TabIndex = 23;
            this.PlBodyBut.Text = "Корпус";
            this.PlBodyBut.UseVisualStyleBackColor = false;
            // 
            // PlHeadBut
            // 
            this.PlHeadBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PlHeadBut.Enabled = false;
            this.PlHeadBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlHeadBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlHeadBut.Location = new System.Drawing.Point(121, 170);
            this.PlHeadBut.Name = "PlHeadBut";
            this.PlHeadBut.Size = new System.Drawing.Size(187, 65);
            this.PlHeadBut.TabIndex = 22;
            this.PlHeadBut.Text = "Голова";
            this.PlHeadBut.UseVisualStyleBackColor = false;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 453);
            this.Controls.Add(this.PlLegsBut);
            this.Controls.Add(this.PlBodyBut);
            this.Controls.Add(this.PlHeadBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerProgressBar);
            this.Controls.Add(this.roundLabel);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar playerProgressBar;
        private System.Windows.Forms.Button PlLegsBut;
        private System.Windows.Forms.Button PlBodyBut;
        private System.Windows.Forms.Button PlHeadBut;
    }
}