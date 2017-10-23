namespace WindowsFormsApplication2
{
    partial class Form3
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
            this.PlayerCounter = new System.Windows.Forms.NumericUpDown();
            this.PlayerNumberLabel = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerCounter
            // 
            this.PlayerCounter.Location = new System.Drawing.Point(191, 83);
            this.PlayerCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PlayerCounter.Name = "PlayerCounter";
            this.PlayerCounter.Size = new System.Drawing.Size(121, 20);
            this.PlayerCounter.TabIndex = 0;
            this.PlayerCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PlayerNumberLabel
            // 
            this.PlayerNumberLabel.AutoSize = true;
            this.PlayerNumberLabel.Location = new System.Drawing.Point(28, 83);
            this.PlayerNumberLabel.Name = "PlayerNumberLabel";
            this.PlayerNumberLabel.Size = new System.Drawing.Size(139, 13);
            this.PlayerNumberLabel.TabIndex = 1;
            this.PlayerNumberLabel.Text = "Enter the number of players:";
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(151, 170);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(199, 99);
            this.StartGameButton.TabIndex = 2;
            this.StartGameButton.Text = "GO!";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 295);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.PlayerNumberLabel);
            this.Controls.Add(this.PlayerCounter);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PlayerCounter;
        private System.Windows.Forms.Label PlayerNumberLabel;
        private System.Windows.Forms.Button StartGameButton;
    }
}