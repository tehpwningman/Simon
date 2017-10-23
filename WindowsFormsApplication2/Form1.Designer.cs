namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.Red = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.PlayerTurnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(51, 49);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(186, 126);
            this.Red.TabIndex = 0;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(299, 54);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(179, 120);
            this.Blue.TabIndex = 1;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(54, 213);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(182, 122);
            this.Green.TabIndex = 2;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(292, 217);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(186, 114);
            this.Yellow.TabIndex = 3;
            this.Yellow.Text = "Yellow";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(42, 20);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(38, 13);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score:";
            // 
            // PlayerTurnLabel
            // 
            this.PlayerTurnLabel.AutoSize = true;
            this.PlayerTurnLabel.Location = new System.Drawing.Point(326, 23);
            this.PlayerTurnLabel.Name = "PlayerTurnLabel";
            this.PlayerTurnLabel.Size = new System.Drawing.Size(0, 13);
            this.PlayerTurnLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 373);
            this.Controls.Add(this.PlayerTurnLabel);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label PlayerTurnLabel;
    }
}

