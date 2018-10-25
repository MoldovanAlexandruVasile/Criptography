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

        List<char> alphabetList = new List<char>();
        List<char> defaultEncryptList = new List<char>();
        private string alphabet = "_abcdefghijklmnopqrstuvwxyz";
        private string defaultEncryptChars = "PYNWLZTXRVUOSMQFJDHBK_ICGAE";
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
                alphabetList.Add(c);
            }
            foreach (char c in defaultEncryptChars)
            {
                defaultEncryptList.Add(c);
            }
            cryptUsed = defaultEncryptChars;
        }

        private void defaultEncryptBtn_Click(object sender, EventArgs e)
        {
            cryptUsed = defaultEncryptChars;
            cryptPathUsedText.Text = cryptUsed;
            int pos = 0;
            foreach (char c in defaultEncryptChars)
            {
                defaultEncryptList[pos] = c;
                pos++;
            }
            MessageBox.Show("Default encrypt option selected !", "Info");
        }

        private void RandomEncryptBtn_Click(object sender, EventArgs e)
        {
            string newCharList = "";
            Random random = new Random();
            List<char> newEncryptList = new List<char>();
            for (int i = 0; i < 27; i++)
                newEncryptList.Add('0');
            foreach (char c in alphabet)
            {
                int pos = random.Next(27);
                while (newEncryptList[pos] != '0')
                    pos = random.Next(27);
                if (c != '_')
                    newEncryptList[pos] = char.ToUpper(c);
                else
                    newEncryptList[pos] = c;
               
            }
            defaultEncryptList = newEncryptList;
            for (int i = 0; i < 27; i++)
                newCharList += newEncryptList[i];
            cryptPathUsedText.Text = newCharList;
            MessageBox.Show("Random encrypt option selected !", "Info");
        }

        private void inputEncryptBtn_Click(object sender, EventArgs e)
        {
            if (customCryptText.Text.Length != 27)
            {
                MessageBox.Show("You need to have 26 unique alphabet characters plus one '_' !", "Error");
            }
            else
            {
                string newText = customCryptText.Text;
                if (isOnlyUppCase(newText) && !thereAreDuplicates(newText) && validCharacters(newText))
                {
                    int pos = 0;
                    foreach (char c in newText)
                    {
                        defaultEncryptList[pos] = c;
                        pos++;
                    }
                    cryptUsed = customCryptText.Text;
                    cryptPathUsedText.Text = cryptUsed;
                    MessageBox.Show("You are now using your entered encrypt path !", "Info");
                } else MessageBox.Show("Lowcase, duplicate or invalid character detected !", "Error");
            }
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string input = inputText.Text;
            string output = "";
            int index = -1;
            if (isOnlyLowCase(input))
            {
                foreach (char c in input)
                {
                    if (alphabetList.Contains(c))
                    {
                        index = alphabetList.IndexOf(c);
                        output += defaultEncryptList[index];
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
            if (isOnlyUppCase(input))
            {
                foreach (char c in input)
                {
                    if (defaultEncryptList.Contains(c))
                    {
                        index = defaultEncryptList.IndexOf(c);
                        output += alphabetList[index];
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

        private bool isOnlyLowCase(string text)
        {
            foreach (char c in text)
                if (c != '_')
                    if (char.IsUpper(c))
                        return false;
            return true;
        }

        private bool thereAreDuplicates(string text)
        {
            foreach (char c in text)
                if (text.Count(i => i == c) > 1)
                    return true;
            return false;
        }

        private bool isOnlyUppCase(string text)
        {
            foreach (char c in text)
                if (c != '_')
                    if (char.IsLower(c))
                        return false;
            return true;
        }

        private bool validCharacters(string text)
        {
            foreach (char c in text)
                if (!alphabet.Contains(char.ToLower(c)))
                    return false;
            return true;
        }
    }
}
