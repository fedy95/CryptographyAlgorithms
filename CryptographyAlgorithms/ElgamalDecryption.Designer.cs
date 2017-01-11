namespace CryptographyAlgorithms
{
    partial class ElgamalDecryption
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
            this.elgamalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutCryptographyAlgorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelCiphertext = new System.Windows.Forms.Label();
            this.LabelFirstPartOfTheCipgertext = new System.Windows.Forms.Label();
            this.LabelSecondPartOfTheCipgertext = new System.Windows.Forms.Label();
            this.TextBoxFirstPartOfTheCipgertext = new System.Windows.Forms.TextBox();
            this.TextBoxSecondPartOfTheCipgertext = new System.Windows.Forms.TextBox();
            this.LabelSecretKey = new System.Windows.Forms.Label();
            this.TextBoxSecretKey = new System.Windows.Forms.TextBox();
            this.LabelFirstPartOfThePublicKey = new System.Windows.Forms.Label();
            this.TextBoxFirstPartOfThePublicKey = new System.Windows.Forms.TextBox();
            this.ButtonDecryption = new System.Windows.Forms.Button();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.LabelMessageOutput = new System.Windows.Forms.Label();
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
            this.elgamalToolStripMenuItem});
            this.algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
            this.algorithmToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.algorithmToolStripMenuItem.Text = "Algorithm";
            // 
            // elgamalToolStripMenuItem
            // 
            this.elgamalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeyGenerationToolStripMenuItem,
            this.EncryptionToolStripMenuItem,
            this.DecryptionToolStripMenuItem});
            this.elgamalToolStripMenuItem.Name = "elgamalToolStripMenuItem";
            this.elgamalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.elgamalToolStripMenuItem.Text = "Elgamal";
            // 
            // KeyGenerationToolStripMenuItem
            // 
            this.KeyGenerationToolStripMenuItem.Name = "KeyGenerationToolStripMenuItem";
            this.KeyGenerationToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.KeyGenerationToolStripMenuItem.Text = "Key generation";
            this.KeyGenerationToolStripMenuItem.Click += new System.EventHandler(this.KeyGenerationToolStripMenuItem_Click);
            // 
            // EncryptionToolStripMenuItem
            // 
            this.EncryptionToolStripMenuItem.Name = "EncryptionToolStripMenuItem";
            this.EncryptionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.EncryptionToolStripMenuItem.Text = "Encryption";
            this.EncryptionToolStripMenuItem.Click += new System.EventHandler(this.EncryptionToolStripMenuItem_Click);
            // 
            // DecryptionToolStripMenuItem
            // 
            this.DecryptionToolStripMenuItem.Name = "DecryptionToolStripMenuItem";
            this.DecryptionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.DecryptionToolStripMenuItem.Text = "Decryption";
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
            // LabelCiphertext
            // 
            this.LabelCiphertext.AutoSize = true;
            this.LabelCiphertext.Location = new System.Drawing.Point(12, 38);
            this.LabelCiphertext.Name = "LabelCiphertext";
            this.LabelCiphertext.Size = new System.Drawing.Size(53, 13);
            this.LabelCiphertext.TabIndex = 1;
            this.LabelCiphertext.Text = "ciphertext";
            // 
            // LabelFirstPartOfTheCipgertext
            // 
            this.LabelFirstPartOfTheCipgertext.AutoSize = true;
            this.LabelFirstPartOfTheCipgertext.Location = new System.Drawing.Point(47, 66);
            this.LabelFirstPartOfTheCipgertext.Name = "LabelFirstPartOfTheCipgertext";
            this.LabelFirstPartOfTheCipgertext.Size = new System.Drawing.Size(44, 13);
            this.LabelFirstPartOfTheCipgertext.TabIndex = 2;
            this.LabelFirstPartOfTheCipgertext.Text = "first part";
            // 
            // LabelSecondPartOfTheCipgertext
            // 
            this.LabelSecondPartOfTheCipgertext.AutoSize = true;
            this.LabelSecondPartOfTheCipgertext.Location = new System.Drawing.Point(29, 94);
            this.LabelSecondPartOfTheCipgertext.Name = "LabelSecondPartOfTheCipgertext";
            this.LabelSecondPartOfTheCipgertext.Size = new System.Drawing.Size(63, 13);
            this.LabelSecondPartOfTheCipgertext.TabIndex = 3;
            this.LabelSecondPartOfTheCipgertext.Text = "second part";
            // 
            // TextBoxFirstPartOfTheCipgertext
            // 
            this.TextBoxFirstPartOfTheCipgertext.Location = new System.Drawing.Point(100, 63);
            this.TextBoxFirstPartOfTheCipgertext.Name = "TextBoxFirstPartOfTheCipgertext";
            this.TextBoxFirstPartOfTheCipgertext.Size = new System.Drawing.Size(100, 20);
            this.TextBoxFirstPartOfTheCipgertext.TabIndex = 4;
            // 
            // TextBoxSecondPartOfTheCipgertext
            // 
            this.TextBoxSecondPartOfTheCipgertext.Location = new System.Drawing.Point(100, 91);
            this.TextBoxSecondPartOfTheCipgertext.Name = "TextBoxSecondPartOfTheCipgertext";
            this.TextBoxSecondPartOfTheCipgertext.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSecondPartOfTheCipgertext.TabIndex = 5;
            // 
            // LabelSecretKey
            // 
            this.LabelSecretKey.AutoSize = true;
            this.LabelSecretKey.Location = new System.Drawing.Point(12, 131);
            this.LabelSecretKey.Name = "LabelSecretKey";
            this.LabelSecretKey.Size = new System.Drawing.Size(56, 13);
            this.LabelSecretKey.TabIndex = 6;
            this.LabelSecretKey.Text = "secret key";
            // 
            // TextBoxSecretKey
            // 
            this.TextBoxSecretKey.Location = new System.Drawing.Point(15, 147);
            this.TextBoxSecretKey.Name = "TextBoxSecretKey";
            this.TextBoxSecretKey.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSecretKey.TabIndex = 7;
            // 
            // LabelFirstPartOfThePublicKey
            // 
            this.LabelFirstPartOfThePublicKey.AutoSize = true;
            this.LabelFirstPartOfThePublicKey.Location = new System.Drawing.Point(12, 177);
            this.LabelFirstPartOfThePublicKey.Name = "LabelFirstPartOfThePublicKey";
            this.LabelFirstPartOfThePublicKey.Size = new System.Drawing.Size(125, 13);
            this.LabelFirstPartOfThePublicKey.TabIndex = 8;
            this.LabelFirstPartOfThePublicKey.Text = "first part of the public key";
            // 
            // TextBoxFirstPartOfThePublicKey
            // 
            this.TextBoxFirstPartOfThePublicKey.Location = new System.Drawing.Point(15, 193);
            this.TextBoxFirstPartOfThePublicKey.Name = "TextBoxFirstPartOfThePublicKey";
            this.TextBoxFirstPartOfThePublicKey.Size = new System.Drawing.Size(100, 20);
            this.TextBoxFirstPartOfThePublicKey.TabIndex = 9;
            // 
            // ButtonDecryption
            // 
            this.ButtonDecryption.Location = new System.Drawing.Point(13, 235);
            this.ButtonDecryption.Name = "ButtonDecryption";
            this.ButtonDecryption.Size = new System.Drawing.Size(75, 23);
            this.ButtonDecryption.TabIndex = 10;
            this.ButtonDecryption.Text = "Decryption";
            this.ButtonDecryption.UseVisualStyleBackColor = true;
            this.ButtonDecryption.Click += new System.EventHandler(this.ButtonDecryption_Click);
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Location = new System.Drawing.Point(16, 272);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(59, 13);
            this.LabelMessage.TabIndex = 11;
            this.LabelMessage.Text = "MESSAGE";
            // 
            // LabelMessageOutput
            // 
            this.LabelMessageOutput.AutoSize = true;
            this.LabelMessageOutput.Location = new System.Drawing.Point(104, 272);
            this.LabelMessageOutput.Name = "LabelMessageOutput";
            this.LabelMessageOutput.Size = new System.Drawing.Size(0, 13);
            this.LabelMessageOutput.TabIndex = 12;
            // 
            // ElgamalDecryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 325);
            this.Controls.Add(this.LabelMessageOutput);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.ButtonDecryption);
            this.Controls.Add(this.TextBoxFirstPartOfThePublicKey);
            this.Controls.Add(this.LabelFirstPartOfThePublicKey);
            this.Controls.Add(this.TextBoxSecretKey);
            this.Controls.Add(this.LabelSecretKey);
            this.Controls.Add(this.TextBoxSecondPartOfTheCipgertext);
            this.Controls.Add(this.TextBoxFirstPartOfTheCipgertext);
            this.Controls.Add(this.LabelSecondPartOfTheCipgertext);
            this.Controls.Add(this.LabelFirstPartOfTheCipgertext);
            this.Controls.Add(this.LabelCiphertext);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ElgamalDecryption";
            this.Text = "Cryptography Algorithms";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elgamalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeyGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutCryptographyAlgorithmsToolStripMenuItem;
        private System.Windows.Forms.Label LabelCiphertext;
        private System.Windows.Forms.Label LabelFirstPartOfTheCipgertext;
        private System.Windows.Forms.Label LabelSecondPartOfTheCipgertext;
        private System.Windows.Forms.TextBox TextBoxFirstPartOfTheCipgertext;
        private System.Windows.Forms.TextBox TextBoxSecondPartOfTheCipgertext;
        private System.Windows.Forms.Label LabelSecretKey;
        private System.Windows.Forms.TextBox TextBoxSecretKey;
        private System.Windows.Forms.Label LabelFirstPartOfThePublicKey;
        private System.Windows.Forms.TextBox TextBoxFirstPartOfThePublicKey;
        private System.Windows.Forms.Button ButtonDecryption;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Label LabelMessageOutput;
    }
}