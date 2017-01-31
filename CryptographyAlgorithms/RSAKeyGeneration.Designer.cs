namespace CryptographyAlgorithms
{
    partial class RSAKeyGeneration
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
            this.LabelNameForm = new System.Windows.Forms.Label();
            this.ButtonСalculate = new System.Windows.Forms.Button();
            this.LabelSecretKeyOutput = new System.Windows.Forms.Label();
            this.LabelPublicKeyOutput = new System.Windows.Forms.Label();
            this.LabelSecretKey = new System.Windows.Forms.Label();
            this.labePublicKey = new System.Windows.Forms.Label();
            this.LabelFirstSimpleNumber = new System.Windows.Forms.Label();
            this.TextBoxFirstSimpleNumber = new System.Windows.Forms.TextBox();
            this.LabelSecondSimpleNumber = new System.Windows.Forms.Label();
            this.TextBoxSecondSimpleNumber = new System.Windows.Forms.TextBox();
            this.CheckBoxOpenExhibitor = new System.Windows.Forms.CheckBox();
            this.LabelOpenExhibitor = new System.Windows.Forms.Label();
            this.TextBoxOpenExhibitor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelNameForm
            // 
            this.LabelNameForm.AutoSize = true;
            this.LabelNameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameForm.Location = new System.Drawing.Point(67, 4);
            this.LabelNameForm.Name = "LabelNameForm";
            this.LabelNameForm.Size = new System.Drawing.Size(156, 18);
            this.LabelNameForm.TabIndex = 26;
            this.LabelNameForm.Text = "RSA key generation";
            // 
            // ButtonСalculate
            // 
            this.ButtonСalculate.Location = new System.Drawing.Point(14, 203);
            this.ButtonСalculate.Name = "ButtonСalculate";
            this.ButtonСalculate.Size = new System.Drawing.Size(75, 23);
            this.ButtonСalculate.TabIndex = 25;
            this.ButtonСalculate.Text = "Сalculate";
            this.ButtonСalculate.UseVisualStyleBackColor = true;
            this.ButtonСalculate.Click += new System.EventHandler(this.ButtonСalculate_Click);
            // 
            // LabelSecretKeyOutput
            // 
            this.LabelSecretKeyOutput.AutoSize = true;
            this.LabelSecretKeyOutput.Location = new System.Drawing.Point(106, 262);
            this.LabelSecretKeyOutput.Name = "LabelSecretKeyOutput";
            this.LabelSecretKeyOutput.Size = new System.Drawing.Size(0, 13);
            this.LabelSecretKeyOutput.TabIndex = 24;
            // 
            // LabelPublicKeyOutput
            // 
            this.LabelPublicKeyOutput.AutoSize = true;
            this.LabelPublicKeyOutput.Location = new System.Drawing.Point(106, 240);
            this.LabelPublicKeyOutput.Name = "LabelPublicKeyOutput";
            this.LabelPublicKeyOutput.Size = new System.Drawing.Size(0, 13);
            this.LabelPublicKeyOutput.TabIndex = 23;
            // 
            // LabelSecretKey
            // 
            this.LabelSecretKey.AutoSize = true;
            this.LabelSecretKey.Location = new System.Drawing.Point(13, 262);
            this.LabelSecretKey.Name = "LabelSecretKey";
            this.LabelSecretKey.Size = new System.Drawing.Size(74, 13);
            this.LabelSecretKey.TabIndex = 22;
            this.LabelSecretKey.Text = "SECRET KEY";
            // 
            // labePublicKey
            // 
            this.labePublicKey.AutoSize = true;
            this.labePublicKey.Location = new System.Drawing.Point(18, 240);
            this.labePublicKey.Name = "labePublicKey";
            this.labePublicKey.Size = new System.Drawing.Size(69, 13);
            this.labePublicKey.TabIndex = 21;
            this.labePublicKey.Text = "PUBLIC KEY";
            // 
            // LabelFirstSimpleNumber
            // 
            this.LabelFirstSimpleNumber.AutoSize = true;
            this.LabelFirstSimpleNumber.Location = new System.Drawing.Point(11, 33);
            this.LabelFirstSimpleNumber.Name = "LabelFirstSimpleNumber";
            this.LabelFirstSimpleNumber.Size = new System.Drawing.Size(93, 13);
            this.LabelFirstSimpleNumber.TabIndex = 16;
            this.LabelFirstSimpleNumber.Text = "first simple number";
            // 
            // TextBoxFirstSimpleNumber
            // 
            this.TextBoxFirstSimpleNumber.Location = new System.Drawing.Point(14, 49);
            this.TextBoxFirstSimpleNumber.Name = "TextBoxFirstSimpleNumber";
            this.TextBoxFirstSimpleNumber.Size = new System.Drawing.Size(100, 20);
            this.TextBoxFirstSimpleNumber.TabIndex = 15;
            // 
            // LabelSecondSimpleNumber
            // 
            this.LabelSecondSimpleNumber.AutoSize = true;
            this.LabelSecondSimpleNumber.Location = new System.Drawing.Point(11, 78);
            this.LabelSecondSimpleNumber.Name = "LabelSecondSimpleNumber";
            this.LabelSecondSimpleNumber.Size = new System.Drawing.Size(112, 13);
            this.LabelSecondSimpleNumber.TabIndex = 28;
            this.LabelSecondSimpleNumber.Text = "second simple number";
            // 
            // TextBoxSecondSimpleNumber
            // 
            this.TextBoxSecondSimpleNumber.Location = new System.Drawing.Point(14, 94);
            this.TextBoxSecondSimpleNumber.Name = "TextBoxSecondSimpleNumber";
            this.TextBoxSecondSimpleNumber.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSecondSimpleNumber.TabIndex = 27;
            // 
            // CheckBoxOpenExhibitor
            // 
            this.CheckBoxOpenExhibitor.AutoSize = true;
            this.CheckBoxOpenExhibitor.Location = new System.Drawing.Point(14, 166);
            this.CheckBoxOpenExhibitor.Name = "CheckBoxOpenExhibitor";
            this.CheckBoxOpenExhibitor.Size = new System.Drawing.Size(158, 17);
            this.CheckBoxOpenExhibitor.TabIndex = 31;
            this.CheckBoxOpenExhibitor.Text = "random open exhibitor (NW)";
            this.CheckBoxOpenExhibitor.UseVisualStyleBackColor = true;
            // 
            // LabelOpenExhibitor
            // 
            this.LabelOpenExhibitor.AutoSize = true;
            this.LabelOpenExhibitor.Location = new System.Drawing.Point(11, 124);
            this.LabelOpenExhibitor.Name = "LabelOpenExhibitor";
            this.LabelOpenExhibitor.Size = new System.Drawing.Size(73, 13);
            this.LabelOpenExhibitor.TabIndex = 30;
            this.LabelOpenExhibitor.Text = "open exhibitor";
            // 
            // TextBoxOpenExhibitor
            // 
            this.TextBoxOpenExhibitor.Location = new System.Drawing.Point(14, 140);
            this.TextBoxOpenExhibitor.Name = "TextBoxOpenExhibitor";
            this.TextBoxOpenExhibitor.Size = new System.Drawing.Size(100, 20);
            this.TextBoxOpenExhibitor.TabIndex = 29;
            // 
            // RSAKeyGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 446);
            this.Controls.Add(this.CheckBoxOpenExhibitor);
            this.Controls.Add(this.LabelOpenExhibitor);
            this.Controls.Add(this.TextBoxOpenExhibitor);
            this.Controls.Add(this.LabelSecondSimpleNumber);
            this.Controls.Add(this.TextBoxSecondSimpleNumber);
            this.Controls.Add(this.LabelNameForm);
            this.Controls.Add(this.ButtonСalculate);
            this.Controls.Add(this.LabelSecretKeyOutput);
            this.Controls.Add(this.LabelPublicKeyOutput);
            this.Controls.Add(this.LabelSecretKey);
            this.Controls.Add(this.labePublicKey);
            this.Controls.Add(this.LabelFirstSimpleNumber);
            this.Controls.Add(this.TextBoxFirstSimpleNumber);
            this.Name = "RSAKeyGeneration";
            this.Text = "RSAKeyGeneration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNameForm;
        private System.Windows.Forms.Button ButtonСalculate;
        private System.Windows.Forms.Label LabelSecretKeyOutput;
        private System.Windows.Forms.Label LabelPublicKeyOutput;
        private System.Windows.Forms.Label LabelSecretKey;
        private System.Windows.Forms.Label labePublicKey;
        private System.Windows.Forms.Label LabelFirstSimpleNumber;
        private System.Windows.Forms.TextBox TextBoxFirstSimpleNumber;
        private System.Windows.Forms.Label LabelSecondSimpleNumber;
        private System.Windows.Forms.TextBox TextBoxSecondSimpleNumber;
        private System.Windows.Forms.CheckBox CheckBoxOpenExhibitor;
        private System.Windows.Forms.Label LabelOpenExhibitor;
        private System.Windows.Forms.TextBox TextBoxOpenExhibitor;
    }
}