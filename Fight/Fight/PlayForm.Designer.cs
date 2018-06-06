namespace Fight
{
    partial class PlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PlHeadBut = new System.Windows.Forms.Button();
            this.PlBodyBut = new System.Windows.Forms.Button();
            this.PlLegsBut = new System.Windows.Forms.Button();
            this.playerProgressBar = new System.Windows.Forms.ProgressBar();
            this.ComputerProgressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComLegsBut = new System.Windows.Forms.Button();
            this.ComBodyBut = new System.Windows.Forms.Button();
            this.ComHeadBut = new System.Windows.Forms.Button();
            this.roundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(600, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 706);
            this.listBox1.TabIndex = 0;
            // 
            // PlHeadBut
            // 
            this.PlHeadBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PlHeadBut.Enabled = false;
            this.PlHeadBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlHeadBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlHeadBut.Location = new System.Drawing.Point(71, 246);
            this.PlHeadBut.Name = "PlHeadBut";
            this.PlHeadBut.Size = new System.Drawing.Size(187, 65);
            this.PlHeadBut.TabIndex = 4;
            this.PlHeadBut.Text = "Голова";
            this.PlHeadBut.UseVisualStyleBackColor = false;
            this.PlHeadBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlBodyBut
            // 
            this.PlBodyBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PlBodyBut.Enabled = false;
            this.PlBodyBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlBodyBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlBodyBut.Location = new System.Drawing.Point(71, 375);
            this.PlBodyBut.Name = "PlBodyBut";
            this.PlBodyBut.Size = new System.Drawing.Size(187, 65);
            this.PlBodyBut.TabIndex = 5;
            this.PlBodyBut.Text = "Корпус";
            this.PlBodyBut.UseVisualStyleBackColor = false;
            this.PlBodyBut.Click += new System.EventHandler(this.PlBodyBut_Click);
            // 
            // PlLegsBut
            // 
            this.PlLegsBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PlLegsBut.Enabled = false;
            this.PlLegsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlLegsBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlLegsBut.Location = new System.Drawing.Point(71, 512);
            this.PlLegsBut.Name = "PlLegsBut";
            this.PlLegsBut.Size = new System.Drawing.Size(187, 65);
            this.PlLegsBut.TabIndex = 6;
            this.PlLegsBut.Text = "Ноги";
            this.PlLegsBut.UseVisualStyleBackColor = false;
            this.PlLegsBut.Click += new System.EventHandler(this.PlLegsBut_Click);
            // 
            // playerProgressBar
            // 
            this.playerProgressBar.Location = new System.Drawing.Point(380, 177);
            this.playerProgressBar.Name = "playerProgressBar";
            this.playerProgressBar.Size = new System.Drawing.Size(196, 23);
            this.playerProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerProgressBar.TabIndex = 7;
            this.playerProgressBar.Value = 100;
            // 
            // ComputerProgressBar
            // 
            this.ComputerProgressBar.Location = new System.Drawing.Point(1052, 177);
            this.ComputerProgressBar.Name = "ComputerProgressBar";
            this.ComputerProgressBar.Size = new System.Drawing.Size(196, 23);
            this.ComputerProgressBar.Step = 1;
            this.ComputerProgressBar.TabIndex = 8;
            this.ComputerProgressBar.Value = 100;
            this.ComputerProgressBar.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1094, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Computer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(423, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = " ";
            // 
            // ComLegsBut
            // 
            this.ComLegsBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ComLegsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComLegsBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComLegsBut.Location = new System.Drawing.Point(1349, 499);
            this.ComLegsBut.Name = "ComLegsBut";
            this.ComLegsBut.Size = new System.Drawing.Size(187, 65);
            this.ComLegsBut.TabIndex = 16;
            this.ComLegsBut.Text = "Ноги";
            this.ComLegsBut.UseVisualStyleBackColor = false;
            this.ComLegsBut.Click += new System.EventHandler(this.ComLegsBut_Click);
            // 
            // ComBodyBut
            // 
            this.ComBodyBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ComBodyBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComBodyBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBodyBut.Location = new System.Drawing.Point(1349, 375);
            this.ComBodyBut.Name = "ComBodyBut";
            this.ComBodyBut.Size = new System.Drawing.Size(187, 65);
            this.ComBodyBut.TabIndex = 15;
            this.ComBodyBut.Text = "Корпус";
            this.ComBodyBut.UseVisualStyleBackColor = false;
            this.ComBodyBut.Click += new System.EventHandler(this.ComBodyBut_Click);
            // 
            // ComHeadBut
            // 
            this.ComHeadBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ComHeadBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComHeadBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComHeadBut.Location = new System.Drawing.Point(1349, 231);
            this.ComHeadBut.Name = "ComHeadBut";
            this.ComHeadBut.Size = new System.Drawing.Size(187, 65);
            this.ComHeadBut.TabIndex = 14;
            this.ComHeadBut.Text = "Голова";
            this.ComHeadBut.UseVisualStyleBackColor = false;
            this.ComHeadBut.Click += new System.EventHandler(this.ComHeadBut_Click);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel.Font = new System.Drawing.Font("Old English Text MT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundLabel.Location = new System.Drawing.Point(705, 32);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(196, 57);
            this.roundLabel.TabIndex = 17;
            this.roundLabel.Text = "Round 1";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1612, 842);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.ComLegsBut);
            this.Controls.Add(this.ComBodyBut);
            this.Controls.Add(this.ComHeadBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComputerProgressBar);
            this.Controls.Add(this.playerProgressBar);
            this.Controls.Add(this.PlLegsBut);
            this.Controls.Add(this.PlBodyBut);
            this.Controls.Add(this.PlHeadBut);
            this.Controls.Add(this.listBox1);
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayForm_FormClosed);
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button PlHeadBut;
        private System.Windows.Forms.Button PlBodyBut;
        private System.Windows.Forms.Button PlLegsBut;
        private System.Windows.Forms.ProgressBar playerProgressBar;
        private System.Windows.Forms.ProgressBar ComputerProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ComLegsBut;
        private System.Windows.Forms.Button ComBodyBut;
        private System.Windows.Forms.Button ComHeadBut;
        private System.Windows.Forms.Label roundLabel;
    }
}