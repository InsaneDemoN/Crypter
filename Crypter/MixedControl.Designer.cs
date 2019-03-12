namespace Crypter
{
    partial class MixedControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncryptDESbutton = new System.Windows.Forms.Button();
            this.EncPlaintextBox = new System.Windows.Forms.TextBox();
            this.EncCiphertextBox = new System.Windows.Forms.TextBox();
            this.EncDESKeytextBox = new System.Windows.Forms.TextBox();
            this.enc_cipher = new System.Windows.Forms.Label();
            this.enc_text = new System.Windows.Forms.Label();
            this.enc_key = new System.Windows.Forms.Label();
            this.EncSHAKeytextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptSHAbutton = new System.Windows.Forms.Button();
            this.EncFinalCiphertextBox = new System.Windows.Forms.TextBox();
            this.DecryptPlaintextBox = new System.Windows.Forms.TextBox();
            this.Decrypt3DESbutton = new System.Windows.Forms.Button();
            this.DecDES_key_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DecryptSHAbutton = new System.Windows.Forms.Button();
            this.DecCiphertextBox = new System.Windows.Forms.TextBox();
            this.DecCipher2textBox = new System.Windows.Forms.TextBox();
            this.DecSHA_key_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EncryptDESbutton
            // 
            this.EncryptDESbutton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.EncryptDESbutton.FlatAppearance.BorderSize = 2;
            this.EncryptDESbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptDESbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptDESbutton.ForeColor = System.Drawing.Color.LightGray;
            this.EncryptDESbutton.Location = new System.Drawing.Point(319, 54);
            this.EncryptDESbutton.Name = "EncryptDESbutton";
            this.EncryptDESbutton.Size = new System.Drawing.Size(132, 38);
            this.EncryptDESbutton.TabIndex = 37;
            this.EncryptDESbutton.Text = "Encrypt";
            this.EncryptDESbutton.UseVisualStyleBackColor = true;
            this.EncryptDESbutton.Click += new System.EventHandler(this.EncryptDESbutton_Click);
            this.EncryptDESbutton.MouseEnter += new System.EventHandler(this.EncryptDESbutton_MouseEnter);
            this.EncryptDESbutton.MouseLeave += new System.EventHandler(this.EncryptDESbutton_MouseLeave);
            // 
            // EncPlaintextBox
            // 
            this.EncPlaintextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.EncPlaintextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EncPlaintextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncPlaintextBox.ForeColor = System.Drawing.Color.White;
            this.EncPlaintextBox.Location = new System.Drawing.Point(99, 19);
            this.EncPlaintextBox.Margin = new System.Windows.Forms.Padding(0);
            this.EncPlaintextBox.Name = "EncPlaintextBox";
            this.EncPlaintextBox.Size = new System.Drawing.Size(302, 23);
            this.EncPlaintextBox.TabIndex = 34;
            // 
            // EncCiphertextBox
            // 
            this.EncCiphertextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.EncCiphertextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EncCiphertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncCiphertextBox.ForeColor = System.Drawing.Color.White;
            this.EncCiphertextBox.Location = new System.Drawing.Point(99, 108);
            this.EncCiphertextBox.Margin = new System.Windows.Forms.Padding(0);
            this.EncCiphertextBox.Name = "EncCiphertextBox";
            this.EncCiphertextBox.Size = new System.Drawing.Size(290, 23);
            this.EncCiphertextBox.TabIndex = 33;
            // 
            // EncDESKeytextBox
            // 
            this.EncDESKeytextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.EncDESKeytextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EncDESKeytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncDESKeytextBox.ForeColor = System.Drawing.Color.White;
            this.EncDESKeytextBox.Location = new System.Drawing.Point(511, 19);
            this.EncDESKeytextBox.Margin = new System.Windows.Forms.Padding(0);
            this.EncDESKeytextBox.Name = "EncDESKeytextBox";
            this.EncDESKeytextBox.Size = new System.Drawing.Size(213, 23);
            this.EncDESKeytextBox.TabIndex = 32;
            // 
            // enc_cipher
            // 
            this.enc_cipher.AutoSize = true;
            this.enc_cipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enc_cipher.ForeColor = System.Drawing.Color.LightGray;
            this.enc_cipher.Location = new System.Drawing.Point(16, 106);
            this.enc_cipher.Name = "enc_cipher";
            this.enc_cipher.Size = new System.Drawing.Size(70, 25);
            this.enc_cipher.TabIndex = 30;
            this.enc_cipher.Text = "Cipher";
            // 
            // enc_text
            // 
            this.enc_text.AutoSize = true;
            this.enc_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enc_text.ForeColor = System.Drawing.Color.LightGray;
            this.enc_text.Location = new System.Drawing.Point(16, 17);
            this.enc_text.Name = "enc_text";
            this.enc_text.Size = new System.Drawing.Size(51, 25);
            this.enc_text.TabIndex = 28;
            this.enc_text.Text = "Text";
            // 
            // enc_key
            // 
            this.enc_key.AutoSize = true;
            this.enc_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enc_key.ForeColor = System.Drawing.Color.LightGray;
            this.enc_key.Location = new System.Drawing.Point(404, 17);
            this.enc_key.Name = "enc_key";
            this.enc_key.Size = new System.Drawing.Size(104, 25);
            this.enc_key.TabIndex = 27;
            this.enc_key.Text = "3DES Key";
            // 
            // EncSHAKeytextBox
            // 
            this.EncSHAKeytextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.EncSHAKeytextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EncSHAKeytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncSHAKeytextBox.ForeColor = System.Drawing.Color.White;
            this.EncSHAKeytextBox.Location = new System.Drawing.Point(511, 106);
            this.EncSHAKeytextBox.Margin = new System.Windows.Forms.Padding(0);
            this.EncSHAKeytextBox.Name = "EncSHAKeytextBox";
            this.EncSHAKeytextBox.Size = new System.Drawing.Size(213, 23);
            this.EncSHAKeytextBox.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(404, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "SHA Key";
            // 
            // EncryptSHAbutton
            // 
            this.EncryptSHAbutton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.EncryptSHAbutton.FlatAppearance.BorderSize = 2;
            this.EncryptSHAbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptSHAbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptSHAbutton.ForeColor = System.Drawing.Color.LightGray;
            this.EncryptSHAbutton.Location = new System.Drawing.Point(319, 145);
            this.EncryptSHAbutton.Name = "EncryptSHAbutton";
            this.EncryptSHAbutton.Size = new System.Drawing.Size(132, 38);
            this.EncryptSHAbutton.TabIndex = 42;
            this.EncryptSHAbutton.Text = "Encrypt";
            this.EncryptSHAbutton.UseVisualStyleBackColor = true;
            this.EncryptSHAbutton.Click += new System.EventHandler(this.EncryptSHAbutton_Click);
            this.EncryptSHAbutton.MouseEnter += new System.EventHandler(this.EncryptSHAbutton_MouseEnter);
            this.EncryptSHAbutton.MouseLeave += new System.EventHandler(this.EncryptSHAbutton_MouseLeave);
            // 
            // EncFinalCiphertextBox
            // 
            this.EncFinalCiphertextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.EncFinalCiphertextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EncFinalCiphertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncFinalCiphertextBox.ForeColor = System.Drawing.Color.White;
            this.EncFinalCiphertextBox.Location = new System.Drawing.Point(99, 195);
            this.EncFinalCiphertextBox.Margin = new System.Windows.Forms.Padding(0);
            this.EncFinalCiphertextBox.Multiline = true;
            this.EncFinalCiphertextBox.Name = "EncFinalCiphertextBox";
            this.EncFinalCiphertextBox.Size = new System.Drawing.Size(625, 80);
            this.EncFinalCiphertextBox.TabIndex = 43;
            // 
            // DecryptPlaintextBox
            // 
            this.DecryptPlaintextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DecryptPlaintextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecryptPlaintextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptPlaintextBox.ForeColor = System.Drawing.Color.White;
            this.DecryptPlaintextBox.Location = new System.Drawing.Point(89, 492);
            this.DecryptPlaintextBox.Margin = new System.Windows.Forms.Padding(0);
            this.DecryptPlaintextBox.Multiline = true;
            this.DecryptPlaintextBox.Name = "DecryptPlaintextBox";
            this.DecryptPlaintextBox.Size = new System.Drawing.Size(625, 78);
            this.DecryptPlaintextBox.TabIndex = 54;
            // 
            // Decrypt3DESbutton
            // 
            this.Decrypt3DESbutton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Decrypt3DESbutton.FlatAppearance.BorderSize = 2;
            this.Decrypt3DESbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrypt3DESbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt3DESbutton.ForeColor = System.Drawing.Color.LightGray;
            this.Decrypt3DESbutton.Location = new System.Drawing.Point(319, 442);
            this.Decrypt3DESbutton.Name = "Decrypt3DESbutton";
            this.Decrypt3DESbutton.Size = new System.Drawing.Size(132, 38);
            this.Decrypt3DESbutton.TabIndex = 53;
            this.Decrypt3DESbutton.Text = "Decrypt";
            this.Decrypt3DESbutton.UseVisualStyleBackColor = true;
            this.Decrypt3DESbutton.Click += new System.EventHandler(this.Decrypt3DESbutton_Click);
            this.Decrypt3DESbutton.MouseEnter += new System.EventHandler(this.Decrypt3DESbutton_MouseEnter);
            this.Decrypt3DESbutton.MouseLeave += new System.EventHandler(this.Decrypt3DESbutton_MouseLeave);
            // 
            // DecDES_key_textBox
            // 
            this.DecDES_key_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DecDES_key_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecDES_key_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecDES_key_textBox.ForeColor = System.Drawing.Color.White;
            this.DecDES_key_textBox.Location = new System.Drawing.Point(501, 403);
            this.DecDES_key_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.DecDES_key_textBox.Name = "DecDES_key_textBox";
            this.DecDES_key_textBox.Size = new System.Drawing.Size(213, 23);
            this.DecDES_key_textBox.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(394, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "SHA Key";
            // 
            // DecryptSHAbutton
            // 
            this.DecryptSHAbutton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.DecryptSHAbutton.FlatAppearance.BorderSize = 2;
            this.DecryptSHAbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptSHAbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptSHAbutton.ForeColor = System.Drawing.Color.LightGray;
            this.DecryptSHAbutton.Location = new System.Drawing.Point(319, 353);
            this.DecryptSHAbutton.Name = "DecryptSHAbutton";
            this.DecryptSHAbutton.Size = new System.Drawing.Size(132, 38);
            this.DecryptSHAbutton.TabIndex = 50;
            this.DecryptSHAbutton.Text = "Decrypt";
            this.DecryptSHAbutton.UseVisualStyleBackColor = true;
            this.DecryptSHAbutton.Click += new System.EventHandler(this.DecryptSHAbutton_Click);
            this.DecryptSHAbutton.MouseEnter += new System.EventHandler(this.DecryptSHAbutton_MouseEnter);
            this.DecryptSHAbutton.MouseLeave += new System.EventHandler(this.DecryptSHAbutton_MouseLeave);
            // 
            // DecCiphertextBox
            // 
            this.DecCiphertextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DecCiphertextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecCiphertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecCiphertextBox.ForeColor = System.Drawing.Color.White;
            this.DecCiphertextBox.Location = new System.Drawing.Point(89, 316);
            this.DecCiphertextBox.Margin = new System.Windows.Forms.Padding(0);
            this.DecCiphertextBox.Name = "DecCiphertextBox";
            this.DecCiphertextBox.Size = new System.Drawing.Size(302, 23);
            this.DecCiphertextBox.TabIndex = 49;
            // 
            // DecCipher2textBox
            // 
            this.DecCipher2textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DecCipher2textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecCipher2textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecCipher2textBox.ForeColor = System.Drawing.Color.White;
            this.DecCipher2textBox.Location = new System.Drawing.Point(89, 405);
            this.DecCipher2textBox.Margin = new System.Windows.Forms.Padding(0);
            this.DecCipher2textBox.Name = "DecCipher2textBox";
            this.DecCipher2textBox.Size = new System.Drawing.Size(290, 23);
            this.DecCipher2textBox.TabIndex = 48;
            // 
            // DecSHA_key_textBox
            // 
            this.DecSHA_key_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DecSHA_key_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecSHA_key_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecSHA_key_textBox.ForeColor = System.Drawing.Color.White;
            this.DecSHA_key_textBox.Location = new System.Drawing.Point(501, 316);
            this.DecSHA_key_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.DecSHA_key_textBox.Name = "DecSHA_key_textBox";
            this.DecSHA_key_textBox.Size = new System.Drawing.Size(213, 23);
            this.DecSHA_key_textBox.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(3, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Cipher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(3, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Cipher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(382, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "3DES Key";
            // 
            // MixedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.DecryptPlaintextBox);
            this.Controls.Add(this.Decrypt3DESbutton);
            this.Controls.Add(this.DecDES_key_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DecryptSHAbutton);
            this.Controls.Add(this.DecCiphertextBox);
            this.Controls.Add(this.DecCipher2textBox);
            this.Controls.Add(this.DecSHA_key_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EncFinalCiphertextBox);
            this.Controls.Add(this.EncryptSHAbutton);
            this.Controls.Add(this.EncSHAKeytextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncryptDESbutton);
            this.Controls.Add(this.EncPlaintextBox);
            this.Controls.Add(this.EncCiphertextBox);
            this.Controls.Add(this.EncDESKeytextBox);
            this.Controls.Add(this.enc_cipher);
            this.Controls.Add(this.enc_text);
            this.Controls.Add(this.enc_key);
            this.Name = "MixedControl";
            this.Size = new System.Drawing.Size(744, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EncryptDESbutton;
        private System.Windows.Forms.TextBox EncPlaintextBox;
        private System.Windows.Forms.TextBox EncCiphertextBox;
        private System.Windows.Forms.TextBox EncDESKeytextBox;
        private System.Windows.Forms.Label enc_cipher;
        private System.Windows.Forms.Label enc_text;
        private System.Windows.Forms.Label enc_key;
        private System.Windows.Forms.TextBox EncSHAKeytextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EncryptSHAbutton;
        private System.Windows.Forms.TextBox EncFinalCiphertextBox;
        private System.Windows.Forms.TextBox DecryptPlaintextBox;
        private System.Windows.Forms.Button Decrypt3DESbutton;
        private System.Windows.Forms.TextBox DecDES_key_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DecryptSHAbutton;
        private System.Windows.Forms.TextBox DecCiphertextBox;
        private System.Windows.Forms.TextBox DecCipher2textBox;
        private System.Windows.Forms.TextBox DecSHA_key_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
