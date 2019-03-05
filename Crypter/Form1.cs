using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SideSelection.Height = tripledes.Height;
            TripleDESControl.BringToFront();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void sha256_Click(object sender, EventArgs e)
        {
            SideSelection.Height = sha256.Height;
            SideSelection.Top = sha256.Top;
            shA256Control1.BringToFront();
        }

        private void Tripledes_Click(object sender, EventArgs e)
        {
            SideSelection.Height = tripledes.Height;
            SideSelection.Top = tripledes.Top;
            TripleDESControl.BringToFront();
        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
