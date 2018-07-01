namespace Fight
{
    partial class ComputerForm
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
            this.ComputerProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel.Font = new System.Drawing.Font("Old English Text MT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundLabel.Location = new System.Drawing.Point(129, 24);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(196, 57);
            this.roundLabel.TabIndex = 18;
            this.roundLabel.Text = "Round 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(109, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 57);
            this.label1.TabIndex = 19;
            this.label1.Text = "Computer";
            // 
            // ComputerProgressBar
            // 
            this.ComputerProgressBar.Location = new System.Drawing.Point(119, 182);
            this.ComputerProgressBar.Name = "ComputerProgressBar";
            this.ComputerProgressBar.Size = new System.Drawing.Size(196, 23);
            this.ComputerProgressBar.Step = 1;
            this.ComputerProgressBar.TabIndex = 20;
            this.ComputerProgressBar.Value = 100;
            // 
            // ComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 237);
            this.Controls.Add(this.ComputerProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundLabel);
            this.Name = "ComputerForm";
            this.Text = "ComputerForm";
            this.Load += new System.EventHandler(this.ComputerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ComputerProgressBar;
    }
}