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
    public partial class RSAKeyGeneration : Form
    {
        public RSAKeyGeneration()
        {
            InitializeComponent();
        }
        /*
        //O(nlog(logn))
        private Int32 SieveOfEratosthenes (Int32 right)
        {
            int[] fullRandomArray = new int[right];
            int[] fullSimpleArray = new int[right];

            for (int i = 2; i < right; i++)
            {
                fullRandomArray[i] = i;
            }

            int size;
            int numberSimpleArray = 2;
            for (int p = 2; p < right; p++)
            {
                size = p;
                if (p != 2)
                {
                    fullRandomArray[]
                    if (p == fullSimpleArray[p])
                        sfsf;
                }

                //Sieve
                while (size != right)
                {
                    if (fullRandomArray[size] % p == 0) //4 6 8 // 9 12 15
                    {
                        fullRandomArray[size] = 0;
                    }
                    size = size + p;
                }

                //update simple array
                for (int i = 2; i < right; i++)
                {
                    if (fullRandomArray[i] != 0)
                    {
                        fullSimpleArray[i] = fullRandomArray[i];
                    }
                }
            }
        }
        */

        private void ButtonСalculate_Click(object sender, EventArgs e)
        {
            //input
            Int32 FirstSimpleNumber = Int32.Parse(TextBoxFirstSimpleNumber.Text);
            Int32 SecondSimpleNumber = Int32.Parse(TextBoxSecondSimpleNumber.Text);

            Int32 Module = FirstSimpleNumber * SecondSimpleNumber;

            Int32 EulerFunction = (FirstSimpleNumber - 1) * (SecondSimpleNumber - 1);

            //CalculateOpenExhibitor
            Int32 OpenExhibitor = Int32.Parse(TextBoxOpenExhibitor.Text);

            //CalculateCloseExhibitor
            Int32 CloseExhibitor = (1 + 2 * EulerFunction) / OpenExhibitor;

            //output
            LabelPublicKeyOutput.Text = Convert.ToString(OpenExhibitor + " / " + Module);
            LabelSecretKeyOutput.Text = Convert.ToString(CloseExhibitor + " / " + Module);
        }
    }
}
