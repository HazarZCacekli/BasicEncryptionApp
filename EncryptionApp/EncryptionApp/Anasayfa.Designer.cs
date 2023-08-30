namespace EncryptionApp
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Sezar = new System.Windows.Forms.Button();
            this.btn_Rsa = new System.Windows.Forms.Button();
            this.btn_Vigenere = new System.Windows.Forms.Button();
            this.btn_md5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Sezar
            // 
            this.btn_Sezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btn_Sezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sezar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sezar.Location = new System.Drawing.Point(73, 41);
            this.btn_Sezar.Name = "btn_Sezar";
            this.btn_Sezar.Size = new System.Drawing.Size(196, 68);
            this.btn_Sezar.TabIndex = 0;
            this.btn_Sezar.Text = "Sezar Şifreleme";
            this.btn_Sezar.UseVisualStyleBackColor = false;
            this.btn_Sezar.Click += new System.EventHandler(this.btn_Sezar_Click);
            // 
            // btn_Rsa
            // 
            this.btn_Rsa.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Rsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rsa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Rsa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Rsa.Location = new System.Drawing.Point(307, 41);
            this.btn_Rsa.Name = "btn_Rsa";
            this.btn_Rsa.Size = new System.Drawing.Size(196, 68);
            this.btn_Rsa.TabIndex = 0;
            this.btn_Rsa.Text = "RSA Şifrelemede Anahtarları Bulma";
            this.btn_Rsa.UseVisualStyleBackColor = false;
            this.btn_Rsa.Click += new System.EventHandler(this.btn_Rsa_Click);
            // 
            // btn_Vigenere
            // 
            this.btn_Vigenere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(178)))), ((int)(((byte)(150)))));
            this.btn_Vigenere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vigenere.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Vigenere.Location = new System.Drawing.Point(73, 161);
            this.btn_Vigenere.Name = "btn_Vigenere";
            this.btn_Vigenere.Size = new System.Drawing.Size(196, 68);
            this.btn_Vigenere.TabIndex = 0;
            this.btn_Vigenere.Text = "Vigenere Şifreleme";
            this.btn_Vigenere.UseVisualStyleBackColor = false;
            this.btn_Vigenere.Click += new System.EventHandler(this.btn_Vigenere_Click);
            // 
            // btn_md5
            // 
            this.btn_md5.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_md5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_md5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_md5.Location = new System.Drawing.Point(307, 161);
            this.btn_md5.Name = "btn_md5";
            this.btn_md5.Size = new System.Drawing.Size(196, 68);
            this.btn_md5.TabIndex = 0;
            this.btn_md5.Text = "MD5 Şifreleme";
            this.btn_md5.UseVisualStyleBackColor = false;
            this.btn_md5.Click += new System.EventHandler(this.btn_md5_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(578, 281);
            this.Controls.Add(this.btn_Rsa);
            this.Controls.Add(this.btn_md5);
            this.Controls.Add(this.btn_Vigenere);
            this.Controls.Add(this.btn_Sezar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anasayfa_FormClosing);
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Sezar;
        private Button btn_Rsa;
        private Button btn_Vigenere;
        private Button btn_md5;
    }
}