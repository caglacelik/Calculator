using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class windowEncryption : Form
    {
        Encryption _encryption;

        public windowEncryption(Encryption encryption)
        {
            InitializeComponent();
            _encryption = encryption;
        }

        // Make form movable
        Point lastPoint;
        private void windowApplicationSelection_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void windowApplicationSelection_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnChangeAlphabet_Click(object sender, EventArgs e)
        {
            _encryption.ChangeAlphabet(txtAlphabet.Text.Trim());
            txtAlphabet.Text = string.Empty;
        }

        private void txtAlphabet_TextChanged(object sender, EventArgs e)
        {
            btnChangeAlphabet.Enabled = true;

            if (string.IsNullOrWhiteSpace(txtAlphabet.Text))
            {
                btnChangeAlphabet.Enabled = false;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text) && !string.IsNullOrEmpty(txtKey.Text))
            {
                if (radioCeaserCipher.Checked)
                {
                    CalculateCeaserCipher(radioDecrypt.Checked);
                }
                else
                {
                    CalculateVigenereCipher(radioDecrypt.Checked);
                }
            }
        }

        private void CalculateCeaserCipher(bool decrypt)
        {
            int rotValue;
            bool isParsable = Int32.TryParse(txtKey.Text.Trim(), out rotValue);

            if (isParsable)
            {
                if (decrypt)
                {
                    lblResult.Text = _encryption.CeaserCipher(txtInput.Text.Trim(), -rotValue);
                    label1.Text = "Decrypted Text:";
                }
                else
                {
                    lblResult.Text = _encryption.CeaserCipher(txtInput.Text.Trim(), rotValue);
                    label1.Text = "Encrypted Text:";
                }
            }
            else
            {
                label1.Text = "Please enter valid key for Ceaser Cipher";
                lblResult.Text = string.Empty;
            }
        }

        private void CalculateVigenereCipher(bool decrypt)
        {
            if (_encryption.AlphabetContains(txtKey.Text.Trim()))
            {
                if (decrypt)
                {
                    lblResult.Text = _encryption.VigenereDecipher(txtInput.Text.Trim(), txtKey.Text.Trim());
                    label1.Text = "Decrypted Text:";
                }
                else
                {
                    lblResult.Text = _encryption.VigenereCipher(txtInput.Text.Trim(), txtKey.Text.Trim());
                    label1.Text = "Encrypted Text:";
                }
            }
            else
            {
                label1.Text = "Please enter valid key for Vigenere Cipher";
                lblResult.Text = string.Empty;
            }
        }
    }
}
