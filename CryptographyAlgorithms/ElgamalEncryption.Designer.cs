namespace CryptographyAlgorithms
{
    partial class ElgamalEncryption
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
            this.LabelMessage = new System.Windows.Forms.Label();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.LabelPublicKey = new System.Windows.Forms.Label();
            this.LabelFirstPartOfThePublicKey = new System.Windows.Forms.Label();
            this.LabelSecondPartOfThePublicKey = new System.Windows.Forms.Label();
            this.LabelThirdPartOfThePublicKey = new System.Windows.Forms.Label();
            this.TextBoxFirstPartOfThePublicKey = new System.Windows.Forms.TextBox();
            this.TextBoxSecondPartOfThePublicKey = new System.Windows.Forms.TextBox();
            this.TextBoxThirdPartOfThePublicKey = new System.Windows.Forms.TextBox();
            this.LabelCiphertext = new System.Windows.Forms.Label();
            this.ButtonEncryption = new System.Windows.Forms.Button();
            this.LabelCiphertextOutput = new System.Windows.Forms.Label();
            this.TextBoxSessionKey = new System.Windows.Forms.TextBox();
            this.LabelSessionKey = new System.Windows.Forms.Label();
            this.CheckBoxSessionKey = new System.Windows.Forms.CheckBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
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
            // 
            // DecryptionToolStripMenuItem
            // 
            this.DecryptionToolStripMenuItem.Name = "DecryptionToolStripMenuItem";
            this.DecryptionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.DecryptionToolStripMenuItem.Text = "Decryption";
            this.DecryptionToolStripMenuItem.Click += new System.EventHandler(this.DecryptionToolStripMenuItem_Click);
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
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Location = new System.Drawing.Point(12, 38);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(226, 13);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.Text = "message (any number Є [1; simple number - 1])";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(15, 55);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMessage.TabIndex = 2;
            // 
            // LabelPublicKey
            // 
            this.LabelPublicKey.AutoSize = true;
            this.LabelPublicKey.Location = new System.Drawing.Point(12, 84);
            this.LabelPublicKey.Name = "LabelPublicKey";
            this.LabelPublicKey.Size = new System.Drawing.Size(55, 13);
            this.LabelPublicKey.TabIndex = 3;
            this.LabelPublicKey.Text = "public key";
            // 
            // LabelFirstPartOfThePublicKey
            // 
            this.LabelFirstPartOfThePublicKey.AutoSize = true;
            this.LabelFirstPartOfThePublicKey.Location = new System.Drawing.Point(53, 104);
            this.LabelFirstPartOfThePublicKey.Name = "LabelFirstPartOfThePublicKey";
            this.LabelFirstPartOfThePublicKey.Size = new System.Drawing.Size(44, 13);
            this.LabelFirstPartOfThePublicKey.TabIndex = 4;
            this.LabelFirstPartOfThePublicKey.Text = "first part";
            // 
            // LabelSecondPartOfThePublicKey
            // 
            this.LabelSecondPartOfThePublicKey.AutoSize = true;
            this.LabelSecondPartOfThePublicKey.Location = new System.Drawing.Point(34, 133);
            this.LabelSecondPartOfThePublicKey.Name = "LabelSecondPartOfThePublicKey";
            this.LabelSecondPartOfThePublicKey.Size = new System.Drawing.Size(63, 13);
            this.LabelSecondPartOfThePublicKey.TabIndex = 5;
            this.LabelSecondPartOfThePublicKey.Text = "second part";
            // 
            // LabelThirdPartOfThePublicKey
            // 
            this.LabelThirdPartOfThePublicKey.AutoSize = true;
            this.LabelThirdPartOfThePublicKey.Location = new System.Drawing.Point(49, 162);
            this.LabelThirdPartOfThePublicKey.Name = "LabelThirdPartOfThePublicKey";
            this.LabelThirdPartOfThePublicKey.Size = new System.Drawing.Size(48, 13);
            this.LabelThirdPartOfThePublicKey.TabIndex = 6;
            this.LabelThirdPartOfThePublicKey.Text = "third part";
            // 
            // TextBoxFirstPartOfThePublicKey
            // 
            this.TextBoxFirstPartOfThePublicKey.Location = new System.Drawing.Point(104, 101);
            this.TextBoxFirstPartOfThePublicKey.Name = "TextBoxFirstPartOfThePublicKey";
            this.TextBoxFirstPartOfThePublicKey.Size = new System.Drawing.Size(100, 20);
            this.TextBoxFirstPartOfThePublicKey.TabIndex = 7;
            // 
            // TextBoxSecondPartOfThePublicKey
            // 
            this.TextBoxSecondPartOfThePublicKey.Location = new System.Drawing.Point(104, 130);
            this.TextBoxSecondPartOfThePublicKey.Name = "TextBoxSecondPartOfThePublicKey";
            this.TextBoxSecondPartOfThePublicKey.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSecondPartOfThePublicKey.TabIndex = 8;
            // 
            // TextBoxThirdPartOfThePublicKey
            // 
            this.TextBoxThirdPartOfThePublicKey.Location = new System.Drawing.Point(104, 159);
            this.TextBoxThirdPartOfThePublicKey.Name = "TextBoxThirdPartOfThePublicKey";
            this.TextBoxThirdPartOfThePublicKey.Size = new System.Drawing.Size(100, 20);
            this.TextBoxThirdPartOfThePublicKey.TabIndex = 9;
            // 
            // LabelCiphertext
            // 
            this.LabelCiphertext.AutoSize = true;
            this.LabelCiphertext.Location = new System.Drawing.Point(10, 313);
            this.LabelCiphertext.Name = "LabelCiphertext";
            this.LabelCiphertext.Size = new System.Drawing.Size(75, 13);
            this.LabelCiphertext.TabIndex = 10;
            this.LabelCiphertext.Text = "CIPHERTEXT";
            // 
            // ButtonEncryption
            // 
            this.ButtonEncryption.Location = new System.Drawing.Point(13, 276);
            this.ButtonEncryption.Name = "ButtonEncryption";
            this.ButtonEncryption.Size = new System.Drawing.Size(75, 23);
            this.ButtonEncryption.TabIndex = 11;
            this.ButtonEncryption.Text = "Encryption";
            this.ButtonEncryption.UseVisualStyleBackColor = true;
            this.ButtonEncryption.Click += new System.EventHandler(this.ButtonEncryption_Click);
            // 
            // LabelCiphertextOutput
            // 
            this.LabelCiphertextOutput.AutoSize = true;
            this.LabelCiphertextOutput.Location = new System.Drawing.Point(98, 313);
            this.LabelCiphertextOutput.Name = "LabelCiphertextOutput";
            this.LabelCiphertextOutput.Size = new System.Drawing.Size(0, 13);
            this.LabelCiphertextOutput.TabIndex = 12;
            // 
            // TextBoxSessionKey
            // 
            this.TextBoxSessionKey.Location = new System.Drawing.Point(15, 208);
            this.TextBoxSessionKey.Name = "TextBoxSessionKey";
            this.TextBoxSessionKey.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSessionKey.TabIndex = 13;
            // 
            // LabelSessionKey
            // 
            this.LabelSessionKey.AutoSize = true;
            this.LabelSessionKey.Location = new System.Drawing.Point(12, 192);
            this.LabelSessionKey.Name = "LabelSessionKey";
            this.LabelSessionKey.Size = new System.Drawing.Size(62, 13);
            this.LabelSessionKey.TabIndex = 14;
            this.LabelSessionKey.Text = "session key";
            // 
            // CheckBoxSessionKey
            // 
            this.CheckBoxSessionKey.AutoSize = true;
            this.CheckBoxSessionKey.Location = new System.Drawing.Point(15, 234);
            this.CheckBoxSessionKey.Name = "CheckBoxSessionKey";
            this.CheckBoxSessionKey.Size = new System.Drawing.Size(119, 17);
            this.CheckBoxSessionKey.TabIndex = 15;
            this.CheckBoxSessionKey.Text = "random session key";
            this.CheckBoxSessionKey.UseVisualStyleBackColor = true;
            // 
            // ElgamalEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 336);
            this.Controls.Add(this.CheckBoxSessionKey);
            this.Controls.Add(this.LabelSessionKey);
            this.Controls.Add(this.TextBoxSessionKey);
            this.Controls.Add(this.LabelCiphertextOutput);
            this.Controls.Add(this.ButtonEncryption);
            this.Controls.Add(this.LabelCiphertext);
            this.Controls.Add(this.TextBoxThirdPartOfThePublicKey);
            this.Controls.Add(this.TextBoxSecondPartOfThePublicKey);
            this.Controls.Add(this.TextBoxFirstPartOfThePublicKey);
            this.Controls.Add(this.LabelThirdPartOfThePublicKey);
            this.Controls.Add(this.LabelSecondPartOfThePublicKey);
            this.Controls.Add(this.LabelFirstPartOfThePublicKey);
            this.Controls.Add(this.LabelPublicKey);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ElgamalEncryption";
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
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.Label LabelPublicKey;
        private System.Windows.Forms.Label LabelFirstPartOfThePublicKey;
        private System.Windows.Forms.Label LabelSecondPartOfThePublicKey;
        private System.Windows.Forms.Label LabelThirdPartOfThePublicKey;
        private System.Windows.Forms.TextBox TextBoxFirstPartOfThePublicKey;
        private System.Windows.Forms.TextBox TextBoxSecondPartOfThePublicKey;
        private System.Windows.Forms.TextBox TextBoxThirdPartOfThePublicKey;
        private System.Windows.Forms.Label LabelCiphertext;
        private System.Windows.Forms.Button ButtonEncryption;
        private System.Windows.Forms.Label LabelCiphertextOutput;
        private System.Windows.Forms.TextBox TextBoxSessionKey;
        private System.Windows.Forms.Label LabelSessionKey;
        private System.Windows.Forms.CheckBox CheckBoxSessionKey;
    }
}