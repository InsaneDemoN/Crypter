using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypter.Resources;

namespace Crypter
{
    public partial class MixedControl : UserControl
    {
        TripleDESCrypt triple = new TripleDESCrypt();
        Color brwn = ColorTranslator.FromHtml("#252525");
        public MixedControl()
        {
            InitializeComponent();

        }

        private void EncryptDESbutton_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(EncPlaintextBox.Text) || string.IsNullOrWhiteSpace(EncDESKeytextBox.Text)))
            {
                EncCiphertextBox.Text = triple.EncryptString(EncDESKeytextBox.Text, EncPlaintextBox.Text);
            }
            else
            {
                MessageBox.Show("No input or input is just whitespaces", "Warning!");
            }
            
        }

        private void EncryptSHAbutton_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(EncCiphertextBox.Text) || string.IsNullOrWhiteSpace(EncSHAKeytextBox.Text))){
                EncFinalCiphertextBox.Text = DecCiphertextBox.Text =SHA256Crypt.Encrypt(EncCiphertextBox.Text, EncSHAKeytextBox.Text);
            }
            else
            {
                MessageBox.Show("No input or input is just whitespaces", "Warning!");
            }
        }

        private void DecryptSHAbutton_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(DecCiphertextBox.Text) || string.IsNullOrWhiteSpace(DecSHA_key_textBox.Text)))
            {
                string plain = SHA256Crypt.Decrypt(DecCiphertextBox.Text, DecSHA_key_textBox.Text);
                if (plain.Equals("CryptographicException"))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Bad Key , Enter exact key", "Error", buttons, MessageBoxIcon.Error);
                }
                else
                    DecCipher2textBox.Text = plain;
            }
            else
            {
                MessageBox.Show("No input or input is just whitespaces", "Warning!");
            }
        }

        private void Decrypt3DESbutton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(DecCipher2textBox.Text) || string.IsNullOrWhiteSpace(DecDES_key_textBox.Text)))
            {
                string res = triple.DecryptString(DecDES_key_textBox.Text, DecCipher2textBox.Text);
                if (res.Equals("bad"))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Bad Key , Enter exact key", "Error", buttons, MessageBoxIcon.Error);
                }
                else if (res.Equals("null"))
                {
                    MessageBox.Show("No input Provided,Please provide an input", "Error");
                }
                else if (res.Equals("badcipher"))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Bad Cipher", "Error", buttons, MessageBoxIcon.Error);
                }
                else
                {
                    DecryptPlaintextBox.Text = res;
                }
            }
               
            else
            {
                MessageBox.Show("No input or input is just whitespaces", "Warning!");
            }
        }
        private void Button_Enter(Button button)
        {
            button.ForeColor = brwn;
            button.BackColor = Color.LightGray;
        }

        private void Button_Leaved(Button button)
        {
            button.ForeColor = Color.LightGray;
            button.BackColor = brwn;
        }

        private void EncryptDESbutton_MouseEnter(object sender, EventArgs e)
        {
            Button_Enter(EncryptDESbutton);
        }

        private void EncryptDESbutton_MouseLeave(object sender, EventArgs e)
        {
            Button_Leaved(EncryptDESbutton);
        }

        private void DecryptSHAbutton_MouseEnter(object sender, EventArgs e)
        {
            Button_Enter(DecryptSHAbutton);
        }

        private void DecryptSHAbutton_MouseLeave(object sender, EventArgs e)
        {
            Button_Leaved(DecryptSHAbutton);
        }

        private void Decrypt3DESbutton_MouseEnter(object sender, EventArgs e)
        {
            Button_Enter(Decrypt3DESbutton);
        }

        private void Decrypt3DESbutton_MouseLeave(object sender, EventArgs e)
        {
            Button_Leaved(Decrypt3DESbutton);
        }

        private void EncryptSHAbutton_MouseEnter(object sender, EventArgs e)
        {
            Button_Enter(EncryptSHAbutton);
        }

        private void EncryptSHAbutton_MouseLeave(object sender, EventArgs e)
        {
            Button_Leaved(EncryptSHAbutton);
        }
    }
}
