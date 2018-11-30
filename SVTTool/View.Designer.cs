﻿namespace SVTTool
{
    partial class uiSVTForm
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
            this.uiReloadButton = new System.Windows.Forms.Button();
            this.uiClearButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uiFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uiAboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uiLocalLabel = new System.Windows.Forms.Label();
            this.uiKSISLabel = new System.Windows.Forms.Label();
            this.uiLocalTextBox = new System.Windows.Forms.TextBox();
            this.uiKSISTextBox = new System.Windows.Forms.TextBox();
            this.uiDisplayTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiReloadButton
            // 
            this.uiReloadButton.Location = new System.Drawing.Point(580, 12);
            this.uiReloadButton.Name = "uiReloadButton";
            this.uiReloadButton.Size = new System.Drawing.Size(75, 23);
            this.uiReloadButton.TabIndex = 0;
            this.uiReloadButton.Text = "Reload";
            this.uiReloadButton.UseVisualStyleBackColor = true;
            // 
            // uiClearButton
            // 
            this.uiClearButton.Location = new System.Drawing.Point(667, 12);
            this.uiClearButton.Name = "uiClearButton";
            this.uiClearButton.Size = new System.Drawing.Size(75, 23);
            this.uiClearButton.TabIndex = 1;
            this.uiClearButton.Text = "Clear";
            this.uiClearButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiFileMenu,
            this.uiAboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uiFileMenu
            // 
            this.uiFileMenu.Name = "uiFileMenu";
            this.uiFileMenu.Size = new System.Drawing.Size(37, 20);
            this.uiFileMenu.Text = "File";
            // 
            // uiAboutMenu
            // 
            this.uiAboutMenu.Name = "uiAboutMenu";
            this.uiAboutMenu.Size = new System.Drawing.Size(52, 20);
            this.uiAboutMenu.Text = "About";
            // 
            // uiLocalLabel
            // 
            this.uiLocalLabel.AutoSize = true;
            this.uiLocalLabel.Location = new System.Drawing.Point(22, 44);
            this.uiLocalLabel.Name = "uiLocalLabel";
            this.uiLocalLabel.Size = new System.Drawing.Size(33, 13);
            this.uiLocalLabel.TabIndex = 3;
            this.uiLocalLabel.Text = "Local";
            // 
            // uiKSISLabel
            // 
            this.uiKSISLabel.AutoSize = true;
            this.uiKSISLabel.Location = new System.Drawing.Point(488, 44);
            this.uiKSISLabel.Name = "uiKSISLabel";
            this.uiKSISLabel.Size = new System.Drawing.Size(31, 13);
            this.uiKSISLabel.TabIndex = 4;
            this.uiKSISLabel.Text = "KSIS";
            // 
            // uiLocalTextBox
            // 
            this.uiLocalTextBox.Location = new System.Drawing.Point(63, 41);
            this.uiLocalTextBox.Name = "uiLocalTextBox";
            this.uiLocalTextBox.Size = new System.Drawing.Size(217, 20);
            this.uiLocalTextBox.TabIndex = 5;
            // 
            // uiKSISTextBox
            // 
            this.uiKSISTextBox.Location = new System.Drawing.Point(525, 41);
            this.uiKSISTextBox.Name = "uiKSISTextBox";
            this.uiKSISTextBox.Size = new System.Drawing.Size(217, 20);
            this.uiKSISTextBox.TabIndex = 6;
            // 
            // uiDisplayTextBox
            // 
            this.uiDisplayTextBox.Location = new System.Drawing.Point(0, 67);
            this.uiDisplayTextBox.Multiline = true;
            this.uiDisplayTextBox.Name = "uiDisplayTextBox";
            this.uiDisplayTextBox.Size = new System.Drawing.Size(762, 377);
            this.uiDisplayTextBox.TabIndex = 7;
            // 
            // uiSVTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 444);
            this.Controls.Add(this.uiDisplayTextBox);
            this.Controls.Add(this.uiKSISTextBox);
            this.Controls.Add(this.uiLocalTextBox);
            this.Controls.Add(this.uiKSISLabel);
            this.Controls.Add(this.uiLocalLabel);
            this.Controls.Add(this.uiClearButton);
            this.Controls.Add(this.uiReloadButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "uiSVTForm";
            this.Text = "Schedule Verification Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiReloadButton;
        private System.Windows.Forms.Button uiClearButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uiFileMenu;
        private System.Windows.Forms.ToolStripMenuItem uiAboutMenu;
        private System.Windows.Forms.Label uiLocalLabel;
        private System.Windows.Forms.Label uiKSISLabel;
        private System.Windows.Forms.TextBox uiLocalTextBox;
        private System.Windows.Forms.TextBox uiKSISTextBox;
        private System.Windows.Forms.TextBox uiDisplayTextBox;
    }
}
