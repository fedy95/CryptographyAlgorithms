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
    public partial class ElgamalKeyGeneration : Form
    {
        public ElgamalKeyGeneration()
        {
            InitializeComponent();
        }

        private void ButtonСalculate_Click(object sender, EventArgs e)
        {
            //input
            Int32 FirstPartOfThePublicKey = Int32.Parse(TextBoxSimpleNumber.Text);

            Int32 SecondPartOfThePublicKey = Int32.Parse(TextBoxPrimitiveRootOfTheSimpleNumber.Text);

            Int32 SecretKey = Int32.Parse(TextBoxAnySimpleNumber.Text);
            
            BigInteger ThirdPartOfThePublicKey = BigInteger.Pow(SecondPartOfThePublicKey, SecretKey) % FirstPartOfThePublicKey;

            //output
            LabelPublicKeyOutput.Text = Convert.ToString(FirstPartOfThePublicKey + " / " + SecondPartOfThePublicKey + " / " + ThirdPartOfThePublicKey);
            LabelSecretKeyOutput.Text = Convert.ToString(SecretKey);
        }

        private void EncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElgamalEncryption temp = new ElgamalEncryption();
            temp.Hide();
            temp.Show();
        }
        private void DecryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElgamalDecryption temp = new ElgamalDecryption();
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
