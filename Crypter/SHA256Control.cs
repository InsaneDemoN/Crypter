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
    public partial class SHA256Control : UserControl
    {
        Color brwn = ColorTranslator.FromHtml("#252525");

        public SHA256Control()
        {
            InitializeComponent();
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

        private void enc_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                string key = textBox1.Text;
                string text = textBox3.Text;
                textBox2.Text = SHA256Crypt.Encrypt(text, key);
            }
            else
            {
                MessageBox.Show("No input or input is just whitespaces", "Warning!");
            }
            
        }

        private void dec_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                string key = textBox4.Text;
                string cipher = textBox2.Text;
                string res = SHA256Crypt.Decrypt(cipher, key);
                if (res.Equals("CryptographicException"))
                {
                    MessageBox.Show("Bad input or input is just whitespaces", "Warning!");

                }
                else
                {
                    textBox6.Text = res;
                }
            }
            else
            {
                MessageBox.Show("No input or input is just whitespaces", "Warning!");
            }

        }

        private void ClrButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();

        }

        private void enc_button_MouseEnter(object sender, EventArgs e)
        {
            Button_Enter(enc_button);
        }

        private void enc_button_MouseLeave(object sender, EventArgs e)
        {
            Button_Leaved(enc_button);
        }


        private void dec_button_MouseEnter(object sender, EventArgs e)
        {
            Button_Enter(dec_button);
        }

        private void dec_button_MouseLeave(object sender, EventArgs e)
        {
            Button_Leaved(dec_button);
        }

        private void ClrButton_MouseEnter(object sender, EventArgs e)
        {
            Button_Enter(ClrButton);
        }

        private void ClrButton_MouseLeave(object sender, EventArgs e)
        {
            Button_Leaved(ClrButton);
        }
    }
}
