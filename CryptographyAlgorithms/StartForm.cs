using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyAlgorithms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        //Elgamal
        private void EGKeyGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            ElgamalKeyGeneration temp = new ElgamalKeyGeneration();
            temp.Hide();
            temp.Show();
        }

        private void EGEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            ElgamalEncryption temp = new ElgamalEncryption();
            temp.Hide();
            temp.Show();
        }

        private void EGDecryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            ElgamalDecryption temp = new ElgamalDecryption();
            temp.Hide();
            temp.Show();
        }

        private void ElGamalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            ElgamalKeyGeneration tempKG = new ElgamalKeyGeneration();
            ElgamalEncryption tempE = new ElgamalEncryption();
            ElgamalDecryption tempD = new ElgamalDecryption();
            tempKG.Hide();
            tempE.Hide();
            tempD.Hide();
            tempKG.Show();
            tempE.Show();
            tempD.Show();
        }

        //RSA
        private void RSAKeyGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            RSAKeyGeneration temp = new RSAKeyGeneration();
            temp.Hide();
            temp.Show();
        }

        private void RSAEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            RSAEncryption temp = new RSAEncryption();
            temp.Hide();
            temp.Show();
        }

        private void RSADecryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            RSADecryption temp = new RSADecryption();
            temp.Hide();
            temp.Show();
        }

        private void RSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            RSAKeyGeneration tempKG = new RSAKeyGeneration();
            RSAEncryption tempE = new RSAEncryption();
            RSADecryption tempD = new RSADecryption();
            tempKG.Hide();
            tempE.Hide();
            tempD.Hide();
            tempKG.Show();
            tempE.Show();
            tempD.Show();
        }

        //Other
        private void AboutCryptographyAlgorithmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCryptographyAlgorithms temp = new AboutCryptographyAlgorithms();
            temp.Hide();
            temp.Show();
        }
    }
}
