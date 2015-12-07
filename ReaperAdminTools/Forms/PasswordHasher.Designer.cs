﻿namespace ReaperAdminTools
{
    partial class PasswordHasher
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
            this.label2 = new System.Windows.Forms.Label();
            this.stringToHash = new System.Windows.Forms.TextBox();
            this.hashedString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "String to Hash:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hashed String:";
            // 
            // stringToHash
            // 
            this.stringToHash.Location = new System.Drawing.Point(95, 12);
            this.stringToHash.Name = "stringToHash";
            this.stringToHash.Size = new System.Drawing.Size(264, 20);
            this.stringToHash.TabIndex = 2;
            this.stringToHash.TextChanged += new System.EventHandler(this.stringToHash_TextChanged);
            // 
            // hashedString
            // 
            this.hashedString.Location = new System.Drawing.Point(95, 38);
            this.hashedString.Name = "hashedString";
            this.hashedString.Size = new System.Drawing.Size(264, 20);
            this.hashedString.TabIndex = 2;
            // 
            // PasswordHasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 76);
            this.Controls.Add(this.hashedString);
            this.Controls.Add(this.stringToHash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PasswordHasher";
            this.Text = "PasswordHasher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stringToHash;
        private System.Windows.Forms.TextBox hashedString;
    }
}