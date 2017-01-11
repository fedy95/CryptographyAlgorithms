using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace CryptographyAlgorithms
{
    public partial class ElgamalDecryption : Form
    {
        public ElgamalDecryption()
        {
            InitializeComponent();
        }

        private void ButtonDecryption_Click(object sender, EventArgs e)
        {
            //input
            BigInteger FirstPartOfTheCipgertext = BigInteger.Parse(TextBoxFirstPartOfTheCipgertext.Text);
            BigInteger SecondPartOfTheCipgertext = BigInteger.Parse(TextBoxSecondPartOfTheCipgertext.Text);

            Int32 SecretKey = Int32.Parse(TextBoxSecretKey.Text);

            Int32 FirstPartOfThePublicKey = Int32.Parse(TextBoxFirstPartOfThePublicKey.Text);

            //decryption
            BigInteger Message = SecondPartOfTheCipgertext * BigInteger.Pow(FirstPartOfTheCipgertext, FirstPartOfThePublicKey - 1 - SecretKey) % FirstPartOfThePublicKey;

            //output
            LabelMessageOutput.Text = Convert.ToString(Message);
        }

        private void KeyGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElgamalKeyGeneration temp = new ElgamalKeyGeneration();
            temp.Hide();
            temp.Show();
        }

        private void EncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElgamalEncryption temp = new ElgamalEncryption();
            temp.Hide();
            temp.Show();
        }

        private void AboutCryptographyAlgorithmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCryptographyAlgorithms temp = new AboutCryptographyAlgorithms();
            temp.Hide();
            temp.Show();
        }
    }
}
