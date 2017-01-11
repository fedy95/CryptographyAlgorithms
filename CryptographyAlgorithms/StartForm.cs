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

        private void KeyGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ElgamalKeyGeneration temp = new ElgamalKeyGeneration();
            temp.Hide();
            temp.Show();
        }

        private void EncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ElgamalEncryption temp = new ElgamalEncryption();
            temp.Hide();
            temp.Show();
        }

        private void DecryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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
