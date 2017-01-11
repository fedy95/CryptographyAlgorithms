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
    public partial class ElgamalEncryption : Form
    {
        public ElgamalEncryption()
        {
            InitializeComponent();
        }

        private void ButtonEncryption_Click(object sender, EventArgs e)
        {
            //input
            BigInteger Message = BigInteger.Parse(TextBoxMessage.Text);

            Int32 FirstPartOfThePublicKey = Int32.Parse(TextBoxFirstPartOfThePublicKey.Text);
            Int32 SecondPartOfThePublicKey = Int32.Parse(TextBoxSecondPartOfThePublicKey.Text);
            BigInteger ThirdPartOfThePublicKey = BigInteger.Parse(TextBoxThirdPartOfThePublicKey.Text);

            //generation of the session key
            Int32 SessionKey;

            if (CheckBoxSessionKey.Checked == true)
            {
                TextBoxSessionKey.Text = "";
                Random tempRandom = new Random();
                
                SessionKey = (42 + tempRandom.Next()) % (Math.Abs(Convert.ToInt32(FirstPartOfThePublicKey-SecondPartOfThePublicKey))) + 6;
            }
            else
            {
                SessionKey = int.Parse(TextBoxSessionKey.Text);
            }
                       

            //encryption
            BigInteger FirstPartOfTheCipgertext = BigInteger.Pow(SecondPartOfThePublicKey, SessionKey) % FirstPartOfThePublicKey;
            BigInteger SecondPartOfTheCipgertext = (BigInteger.Pow(ThirdPartOfThePublicKey, SessionKey) * Message) % FirstPartOfThePublicKey;

            //output
            LabelCiphertextOutput.Text = Convert.ToString(FirstPartOfTheCipgertext + " / " + SecondPartOfTheCipgertext);
        }

        private void KeyGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElgamalKeyGeneration temp = new ElgamalKeyGeneration();
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
