using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViginereEncryption
{
    public partial class MainForm : Form
    {
        Func<string, string, string> processFunc;

        public MainForm()
        {
            InitializeComponent();
        }


        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.Equals(cipherRadioButton))
                processFunc = ViginereEncyptor.Cipher;
            else if (sender.Equals(decipherRadioButton))
                processFunc = ViginereEncyptor.Decipher;
        }
        private void processButton_Click(object sender, EventArgs e)
        {
            if ((inputTextBox.TextLength == 0) || (keywordTextBox.TextLength == 0))
                return;
            outputTextBox.Text = processFunc(keywordTextBox.Text, inputTextBox.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            keywordTextBox.Clear();
            outputTextBox.Clear();
        }
    }
}
