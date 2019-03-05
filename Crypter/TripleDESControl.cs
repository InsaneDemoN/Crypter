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
    public partial class TripleDESControl : UserControl
    {
        Color brwn = ColorTranslator.FromHtml("#252525");
        public TripleDESControl()
        {
            InitializeComponent();
            
        }
        TripleDESCrypt triple = new TripleDESCrypt();

        private void enc_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
               textBox2.Text = triple.EncryptString(textBox1.Text,textBox3.Text);

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
                string res = triple.DecryptString(textBox4.Text);
                if (res.Equals("bad"))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Bad Key , Enter exact key", "Error", buttons, MessageBoxIcon.Error);
                }
                else if (res.Equals("null"))
                {
                    MessageBox.Show("No input Provided,Please provide an input", "Error");
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

        private void enc_button_Enter(object sender, EventArgs e)
        {
            Button_Enter(Enc_button);
        }

        private void Enc_button_MouseLeave(object sender, EventArgs e)
        {
            Button_Leaved(Enc_button);
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
