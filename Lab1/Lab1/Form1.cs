using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1
{
    public partial class Form1 : Form
    {

        List<char> chars = new List<char>();
        List<char> defaultCrypt = new List<char>();
        private string alphabet = "_abcdefghijklmnopqrstuvwxyz";
        private string defaultCryptChars = "PYNWLZTXRVUOSMQFJDHBK_ICGAE";
        public string cryptUsed;

        public Form1()
        {
            InitializeComponent();
            initCharsListAndDefaultCrypt();
            cryptPathUsedText.Text = cryptUsed;
        }

        private void initCharsListAndDefaultCrypt()
        {
            foreach (char c in alphabet)
            {
                chars.Add(c);
            }
            foreach (char c in defaultCryptChars)
            {
                defaultCrypt.Add(c);
            }
            cryptUsed = defaultCryptChars;
        }

        private void defaultEncryptBtn_Click(object sender, EventArgs e)
        {
            cryptUsed = defaultCryptChars;
            cryptPathUsedText.Text = cryptUsed;
            MessageBox.Show("Default encrypt option selected !", "Info");
        }

        private void RandomEncryptBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Random encrypt option selected !", "Info");
        }

        private void inputEncryptBtn_Click(object sender, EventArgs e)
        {
            if (customCryptText.Text.Length != 27)
            {
                MessageBox.Show("You need to have 27 characters including '_' !", "Error");
            }
            else
            {
                string newText = customCryptText.Text;
                if (checkIfIsOnlyUppCase(newText) && checkIfThereAreDuplicates(newText))
                {
                    int pos = 0;
                    foreach (char c in newText)
                    {
                        defaultCrypt[pos] = c;
                        pos++;
                    }
                    cryptUsed = customCryptText.Text;
                    cryptPathUsedText.Text = cryptUsed;
                    MessageBox.Show("You are now using your entered encrypt path !", "Info");
                } else MessageBox.Show("Only unique upp case characters are accepted !", "Error");
            }
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string input = inputText.Text;
            string output = "";
            int index = -1;
            if (checkIfIsOnlyLowCase(input))
            {
                foreach (char c in input)
                {
                    if (chars.Contains(c))
                    {
                        index = chars.IndexOf(c);
                        output += defaultCrypt[index];
                    }
                    else
                    {
                        MessageBox.Show("An invalid character detected !", "Error");
                        return;
                    }
                }
                encryptedText.Text = output;
            }
            else MessageBox.Show("Only low case characters are accepted !", "Error");
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            string input = encryptedText.Text;
            string output = "";
            inputText.Text = "";
            int index = -1;
            if (checkIfIsOnlyUppCase(input))
            {
                foreach (char c in input)
                {
                    if (defaultCrypt.Contains(c))
                    {
                        index = defaultCrypt.IndexOf(c);
                        output += chars[index];
                    }
                    else
                    {
                        MessageBox.Show("An invalid character detected !", "Error");
                        return;
                    }
                }
                inputText.Text = output;
            }
            else MessageBox.Show("Only upp case characters are accepted !", "Error");
        }

        private bool checkIfIsOnlyLowCase(string text)
        {
            foreach (char c in text)
                if (c != '_')
                    if (char.IsUpper(c))
                        return false;
            return true;
        }

        private bool checkIfThereAreDuplicates(string text)
        {
            foreach (char c in text)
                if (text.Count(i => i == c) > 1)
                    return false;
            return true;
        }

        private bool checkIfIsOnlyUppCase(string text)
        {
            foreach (char c in text)
                if (c != '_')
                    if (char.IsLower(c))
                        return false;
            return true;
        }
    }
}
