﻿namespace ComputerScience40S.computerscience40s.main
{
    partial class ComputerScience40S
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
            this.outputList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // outputList
            // 
            this.outputList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputList.FormattingEnabled = true;
            this.outputList.ItemHeight = 19;
            this.outputList.Location = new System.Drawing.Point(12, 12);
            this.outputList.Name = "outputList";
            this.outputList.Size = new System.Drawing.Size(1131, 745);
            this.outputList.TabIndex = 1;
            // 
            // ComputerScience40S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 776);
            this.Controls.Add(this.outputList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ComputerScience40S";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Science 40S";
            this.Load += new System.EventHandler(this.ComputerScience40S_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputList;
    }
}