namespace Mastermind
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hintButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(394, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "REFRESH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(524, 284);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(94, 52);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // hintButton
            // 
            this.hintButton.Location = new System.Drawing.Point(524, 342);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(94, 29);
            this.hintButton.TabIndex = 4;
            this.hintButton.Text = "HINT";
            this.hintButton.UseVisualStyleBackColor = true;
            this.hintButton.Click += new System.EventHandler(this.hintButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(538, 497);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(94, 29);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "HELP";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 553);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.hintButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button newGameButton;
        private TextBox textBox1;
        private Button hintButton;
        private Button helpButton;
    }
}