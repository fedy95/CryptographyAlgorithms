﻿namespace CryptographyAlgorithms
{
    partial class StartForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elGamalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyGenerationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutCryptographyAlgorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algorithmToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algorithmToolStripMenuItem
            // 
            this.algorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elGamalToolStripMenuItem,
            this.rSAToolStripMenuItem});
            this.algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
            this.algorithmToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.algorithmToolStripMenuItem.Text = "Algorithm";
            // 
            // elGamalToolStripMenuItem
            // 
            this.elGamalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeyGenerationToolStripMenuItem,
            this.EncryptionToolStripMenuItem,
            this.DecryptionToolStripMenuItem});
            this.elGamalToolStripMenuItem.Name = "elGamalToolStripMenuItem";
            this.elGamalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.elGamalToolStripMenuItem.Text = "ElGamal";
            this.elGamalToolStripMenuItem.Click += new System.EventHandler(this.ElGamalToolStripMenuItem_Click);
            // 
            // KeyGenerationToolStripMenuItem
            // 
            this.KeyGenerationToolStripMenuItem.Name = "KeyGenerationToolStripMenuItem";
            this.KeyGenerationToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.KeyGenerationToolStripMenuItem.Text = "Key generation";
            this.KeyGenerationToolStripMenuItem.Click += new System.EventHandler(this.EGKeyGenerationToolStripMenuItem_Click);
            // 
            // EncryptionToolStripMenuItem
            // 
            this.EncryptionToolStripMenuItem.Name = "EncryptionToolStripMenuItem";
            this.EncryptionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.EncryptionToolStripMenuItem.Text = "Encryption";
            this.EncryptionToolStripMenuItem.Click += new System.EventHandler(this.EGEncryptionToolStripMenuItem_Click);
            // 
            // DecryptionToolStripMenuItem
            // 
            this.DecryptionToolStripMenuItem.Name = "DecryptionToolStripMenuItem";
            this.DecryptionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.DecryptionToolStripMenuItem.Text = "Decryption";
            this.DecryptionToolStripMenuItem.Click += new System.EventHandler(this.EGDecryptionToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyGenerationToolStripMenuItem1,
            this.encryptionToolStripMenuItem1,
            this.decryptionToolStripMenuItem1});
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.RSAToolStripMenuItem_Click);
            // 
            // keyGenerationToolStripMenuItem1
            // 
            this.keyGenerationToolStripMenuItem1.Name = "keyGenerationToolStripMenuItem1";
            this.keyGenerationToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.keyGenerationToolStripMenuItem1.Text = "Key generation";
            this.keyGenerationToolStripMenuItem1.Click += new System.EventHandler(this.RSAKeyGenerationToolStripMenuItem_Click);
            // 
            // encryptionToolStripMenuItem1
            // 
            this.encryptionToolStripMenuItem1.Name = "encryptionToolStripMenuItem1";
            this.encryptionToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.encryptionToolStripMenuItem1.Text = "Encryption";
            this.encryptionToolStripMenuItem1.Click += new System.EventHandler(this.RSAEncryptionToolStripMenuItem_Click);
            // 
            // decryptionToolStripMenuItem1
            // 
            this.decryptionToolStripMenuItem1.Name = "decryptionToolStripMenuItem1";
            this.decryptionToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.decryptionToolStripMenuItem1.Text = "Decryption";
            this.decryptionToolStripMenuItem1.Click += new System.EventHandler(this.RSADecryptionToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutCryptographyAlgorithmsToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // AboutCryptographyAlgorithmsToolStripMenuItem
            // 
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Name = "AboutCryptographyAlgorithmsToolStripMenuItem";
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Text = "About Cryptography Algorithms";
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Click += new System.EventHandler(this.AboutCryptographyAlgorithmsToolStripMenuItem_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elGamalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeyGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutCryptographyAlgorithmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyGenerationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decryptionToolStripMenuItem1;
    }
}