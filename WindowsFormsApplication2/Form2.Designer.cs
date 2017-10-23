namespace WindowsFormsApplication2
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
            this.Welcome_Label = new System.Windows.Forms.Label();
            this.New_Game_Button = new System.Windows.Forms.Button();
            this.High_Scores_Button = new System.Windows.Forms.Button();
            this.View_History_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome_Label
            // 
            this.Welcome_Label.AutoSize = true;
            this.Welcome_Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Welcome_Label.Location = new System.Drawing.Point(294, 78);
            this.Welcome_Label.Name = "Welcome_Label";
            this.Welcome_Label.Size = new System.Drawing.Size(99, 13);
            this.Welcome_Label.TabIndex = 0;
            this.Welcome_Label.Text = "Welcome to Simon!";
            // 
            // New_Game_Button
            // 
            this.New_Game_Button.Location = new System.Drawing.Point(14, 242);
            this.New_Game_Button.Name = "New_Game_Button";
            this.New_Game_Button.Size = new System.Drawing.Size(217, 86);
            this.New_Game_Button.TabIndex = 1;
            this.New_Game_Button.Text = "Start a New Game";
            this.New_Game_Button.UseVisualStyleBackColor = true;
            this.New_Game_Button.Click += new System.EventHandler(this.New_Game_Button_Click);
            // 
            // High_Scores_Button
            // 
            this.High_Scores_Button.Location = new System.Drawing.Point(237, 242);
            this.High_Scores_Button.Name = "High_Scores_Button";
            this.High_Scores_Button.Size = new System.Drawing.Size(217, 86);
            this.High_Scores_Button.TabIndex = 2;
            this.High_Scores_Button.Text = "View High Scores";
            this.High_Scores_Button.UseVisualStyleBackColor = true;
            this.High_Scores_Button.Click += new System.EventHandler(this.High_Scores_Button_Click);
            // 
            // View_History_Button
            // 
            this.View_History_Button.Location = new System.Drawing.Point(460, 242);
            this.View_History_Button.Name = "View_History_Button";
            this.View_History_Button.Size = new System.Drawing.Size(217, 86);
            this.View_History_Button.TabIndex = 3;
            this.View_History_Button.Text = "View Game History";
            this.View_History_Button.UseVisualStyleBackColor = true;
            this.View_History_Button.Click += new System.EventHandler(this.View_History_Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 419);
            this.Controls.Add(this.View_History_Button);
            this.Controls.Add(this.High_Scores_Button);
            this.Controls.Add(this.New_Game_Button);
            this.Controls.Add(this.Welcome_Label);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form2";
            this.Text = "Welcome To Simon!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.Button New_Game_Button;
        private System.Windows.Forms.Button High_Scores_Button;
        private System.Windows.Forms.Button View_History_Button;
    }
}