namespace Crypter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize_button = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebutton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sha256 = new System.Windows.Forms.Button();
            this.SideSelection = new System.Windows.Forms.Panel();
            this.tripledes = new System.Windows.Forms.Button();
            this.Mixedbutton = new System.Windows.Forms.Button();
            this.mixedControl1 = new Crypter.MixedControl();
            this.shA256Control1 = new Crypter.SHA256Control();
            this.TripleDESControl = new Crypter.TripleDESControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.Minimize_button);
            this.panel1.Controls.Add(this.head);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closebutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 46);
            this.panel1.TabIndex = 0;
            // 
            // Minimize_button
            // 
            this.Minimize_button.Image = global::Crypter.Properties.Resources.icons8_subtract_32;
            this.Minimize_button.Location = new System.Drawing.Point(999, 4);
            this.Minimize_button.Name = "Minimize_button";
            this.Minimize_button.Size = new System.Drawing.Size(48, 42);
            this.Minimize_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Minimize_button.TabIndex = 5;
            this.Minimize_button.TabStop = false;
            this.Minimize_button.Click += new System.EventHandler(this.Minimize_button_Click);
            // 
            // head
            // 
            this.head.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.ForeColor = System.Drawing.Color.LightGray;
            this.head.Location = new System.Drawing.Point(51, 9);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(73, 24);
            this.head.TabIndex = 4;
            this.head.Text = "Crypter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Crypter.Properties.Resources.icons8_encrypt_480;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // closebutton
            // 
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebutton.Image = global::Crypter.Properties.Resources.icons8_delete_32__1_;
            this.closebutton.Location = new System.Drawing.Point(1053, 3);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(48, 43);
            this.closebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closebutton.TabIndex = 2;
            this.closebutton.TabStop = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Mixedbutton);
            this.panel2.Controls.Add(this.sha256);
            this.panel2.Controls.Add(this.SideSelection);
            this.panel2.Controls.Add(this.tripledes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 606);
            this.panel2.TabIndex = 1;
            // 
            // sha256
            // 
            this.sha256.FlatAppearance.BorderSize = 0;
            this.sha256.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sha256.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha256.ForeColor = System.Drawing.Color.Silver;
            this.sha256.Image = ((System.Drawing.Image)(resources.GetObject("sha256.Image")));
            this.sha256.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sha256.Location = new System.Drawing.Point(25, 104);
            this.sha256.Name = "sha256";
            this.sha256.Size = new System.Drawing.Size(327, 90);
            this.sha256.TabIndex = 3;
            this.sha256.Text = "SHA 256";
            this.sha256.UseVisualStyleBackColor = true;
            this.sha256.Click += new System.EventHandler(this.sha256_Click);
            // 
            // SideSelection
            // 
            this.SideSelection.BackColor = System.Drawing.Color.DodgerBlue;
            this.SideSelection.Location = new System.Drawing.Point(0, 0);
            this.SideSelection.Name = "SideSelection";
            this.SideSelection.Size = new System.Drawing.Size(19, 90);
            this.SideSelection.TabIndex = 2;
            // 
            // tripledes
            // 
            this.tripledes.FlatAppearance.BorderSize = 0;
            this.tripledes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tripledes.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripledes.ForeColor = System.Drawing.Color.Silver;
            this.tripledes.Image = global::Crypter.Properties.Resources.icons8_access_filled_50;
            this.tripledes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tripledes.Location = new System.Drawing.Point(25, 0);
            this.tripledes.Name = "tripledes";
            this.tripledes.Size = new System.Drawing.Size(327, 90);
            this.tripledes.TabIndex = 0;
            this.tripledes.Text = "Triple DES";
            this.tripledes.UseVisualStyleBackColor = true;
            this.tripledes.Click += new System.EventHandler(this.Tripledes_Click);
            // 
            // Mixedbutton
            // 
            this.Mixedbutton.FlatAppearance.BorderSize = 0;
            this.Mixedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mixedbutton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mixedbutton.ForeColor = System.Drawing.Color.Silver;
            this.Mixedbutton.Image = ((System.Drawing.Image)(resources.GetObject("Mixedbutton.Image")));
            this.Mixedbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mixedbutton.Location = new System.Drawing.Point(25, 200);
            this.Mixedbutton.Name = "Mixedbutton";
            this.Mixedbutton.Size = new System.Drawing.Size(327, 90);
            this.Mixedbutton.TabIndex = 4;
            this.Mixedbutton.Text = "3DES + SHA";
            this.Mixedbutton.UseVisualStyleBackColor = true;
            this.Mixedbutton.Click += new System.EventHandler(this.Mixedbutton_Click);
            // 
            // mixedControl1
            // 
            this.mixedControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mixedControl1.Location = new System.Drawing.Point(360, 46);
            this.mixedControl1.Name = "mixedControl1";
            this.mixedControl1.Size = new System.Drawing.Size(744, 600);
            this.mixedControl1.TabIndex = 4;
            // 
            // shA256Control1
            // 
            this.shA256Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.shA256Control1.Location = new System.Drawing.Point(360, 46);
            this.shA256Control1.Name = "shA256Control1";
            this.shA256Control1.Size = new System.Drawing.Size(744, 600);
            this.shA256Control1.TabIndex = 3;
            // 
            // TripleDESControl
            // 
            this.TripleDESControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TripleDESControl.Location = new System.Drawing.Point(360, 46);
            this.TripleDESControl.Name = "TripleDESControl";
            this.TripleDESControl.Size = new System.Drawing.Size(744, 600);
            this.TripleDESControl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1104, 652);
            this.Controls.Add(this.mixedControl1);
            this.Controls.Add(this.shA256Control1);
            this.Controls.Add(this.TripleDESControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tripledes;
        private System.Windows.Forms.Button sha256;
        private System.Windows.Forms.Panel SideSelection;
        private System.Windows.Forms.PictureBox closebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.PictureBox Minimize_button;
        private TripleDESControl TripleDESControl;
        private SHA256Control shA256Control1;
        private System.Windows.Forms.Button Mixedbutton;
        private MixedControl mixedControl1;
    }
}

