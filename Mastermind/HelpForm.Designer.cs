namespace Mastermind
{
    partial class HelpForm
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(67, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(340, 27);
            this.titleBox.TabIndex = 0;
            // 
            // contentBox
            // 
            this.contentBox.FormattingEnabled = true;
            this.contentBox.ItemHeight = 20;
            this.contentBox.Location = new System.Drawing.Point(67, 45);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(340, 424);
            this.contentBox.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(67, 475);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 40);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(305, 475);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(102, 40);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 546);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.titleBox);
            this.Name = "HelpForm";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox titleBox;
        private ListBox contentBox;
        private Button backButton;
        private Button nextButton;
    }
}