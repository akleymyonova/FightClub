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
            this.label1 = new System.Windows.Forms.Label();
            this.ComputerProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(124, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 57);
            this.label1.TabIndex = 19;
            this.label1.Text = "Computer";
            // 
            // ComputerProgressBar
            // 
            this.ComputerProgressBar.Location = new System.Drawing.Point(134, 92);
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
            this.ClientSize = new System.Drawing.Size(452, 150);
            this.Controls.Add(this.ComputerProgressBar);
            this.Controls.Add(this.label1);
            this.Name = "ComputerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ComputerForm";
            this.Activated += new System.EventHandler(this.ComputerForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComputerForm_FormClosed);
            this.Load += new System.EventHandler(this.ComputerForm_Load);
            this.EnabledChanged += new System.EventHandler(this.ComputerForm_EnabledChanged);
            this.Enter += new System.EventHandler(this.ComputerForm_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ComputerProgressBar;
    }
}