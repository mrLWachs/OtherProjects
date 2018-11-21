namespace ComputerScience40S
{
    partial class MainForm
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
            this.cs20SButton = new System.Windows.Forms.Button();
            this.cs30SButton = new System.Windows.Forms.Button();
            this.cs40SButton = new System.Windows.Forms.Button();
            this.cs42SIBButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cs20SButton
            // 
            this.cs20SButton.Location = new System.Drawing.Point(12, 18);
            this.cs20SButton.Name = "cs20SButton";
            this.cs20SButton.Size = new System.Drawing.Size(266, 50);
            this.cs20SButton.TabIndex = 0;
            this.cs20SButton.Text = "Computer Science 20S";
            this.cs20SButton.UseVisualStyleBackColor = true;
            this.cs20SButton.Click += new System.EventHandler(this.cs20SButton_Click);
            // 
            // cs30SButton
            // 
            this.cs30SButton.Location = new System.Drawing.Point(12, 74);
            this.cs30SButton.Name = "cs30SButton";
            this.cs30SButton.Size = new System.Drawing.Size(266, 50);
            this.cs30SButton.TabIndex = 1;
            this.cs30SButton.Text = "Computer Science 30S";
            this.cs30SButton.UseVisualStyleBackColor = true;
            this.cs30SButton.Click += new System.EventHandler(this.cs30SButton_Click);
            // 
            // cs40SButton
            // 
            this.cs40SButton.Location = new System.Drawing.Point(12, 130);
            this.cs40SButton.Name = "cs40SButton";
            this.cs40SButton.Size = new System.Drawing.Size(266, 50);
            this.cs40SButton.TabIndex = 2;
            this.cs40SButton.Text = "Computer Science 40S";
            this.cs40SButton.UseVisualStyleBackColor = true;
            this.cs40SButton.Click += new System.EventHandler(this.cs40SButton_Click);
            // 
            // cs42SIBButton
            // 
            this.cs42SIBButton.Location = new System.Drawing.Point(12, 186);
            this.cs42SIBButton.Name = "cs42SIBButton";
            this.cs42SIBButton.Size = new System.Drawing.Size(266, 50);
            this.cs42SIBButton.TabIndex = 3;
            this.cs42SIBButton.Text = "Computer Science 42SIB";
            this.cs42SIBButton.UseVisualStyleBackColor = true;
            this.cs42SIBButton.Click += new System.EventHandler(this.cs42SIBButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 248);
            this.Controls.Add(this.cs42SIBButton);
            this.Controls.Add(this.cs40SButton);
            this.Controls.Add(this.cs30SButton);
            this.Controls.Add(this.cs20SButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr. Wachs\' Computer Science Classes (in C#)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cs20SButton;
        private System.Windows.Forms.Button cs30SButton;
        private System.Windows.Forms.Button cs40SButton;
        private System.Windows.Forms.Button cs42SIBButton;
    }
}

