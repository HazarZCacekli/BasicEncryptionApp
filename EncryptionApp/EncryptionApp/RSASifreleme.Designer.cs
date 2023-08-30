namespace EncryptionApp
{
    partial class RSASifreleme
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
            this.btn_Geri = new System.Windows.Forms.Button();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.txt_second = new System.Windows.Forms.TextBox();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.txt_public = new System.Windows.Forms.TextBox();
            this.txt_private = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rndE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_generateKeys = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.White;
            this.btn_Geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.Location = new System.Drawing.Point(12, 12);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(121, 43);
            this.btn_Geri.TabIndex = 1;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // txt_first
            // 
            this.txt_first.Location = new System.Drawing.Point(12, 133);
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(130, 23);
            this.txt_first.TabIndex = 2;
            // 
            // txt_second
            // 
            this.txt_second.Location = new System.Drawing.Point(178, 133);
            this.txt_second.Name = "txt_second";
            this.txt_second.Size = new System.Drawing.Size(130, 23);
            this.txt_second.TabIndex = 2;
            // 
            // txt_e
            // 
            this.txt_e.Location = new System.Drawing.Point(13, 209);
            this.txt_e.Name = "txt_e";
            this.txt_e.Size = new System.Drawing.Size(129, 23);
            this.txt_e.TabIndex = 2;
            // 
            // txt_public
            // 
            this.txt_public.Enabled = false;
            this.txt_public.Location = new System.Drawing.Point(12, 330);
            this.txt_public.Name = "txt_public";
            this.txt_public.Size = new System.Drawing.Size(296, 23);
            this.txt_public.TabIndex = 3;
            // 
            // txt_private
            // 
            this.txt_private.Enabled = false;
            this.txt_private.Location = new System.Drawing.Point(12, 406);
            this.txt_private.Name = "txt_private";
            this.txt_private.Size = new System.Drawing.Size(296, 23);
            this.txt_private.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "İlk Asal Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(187, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "İkinci Asal Sayı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "\"e\" Değeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifreleyecek Fonksiyon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifreyi Çözecek Fonksiyon";
            // 
            // btn_rndE
            // 
            this.btn_rndE.BackColor = System.Drawing.Color.White;
            this.btn_rndE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rndE.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_rndE.Location = new System.Drawing.Point(168, 199);
            this.btn_rndE.Name = "btn_rndE";
            this.btn_rndE.Size = new System.Drawing.Size(140, 33);
            this.btn_rndE.TabIndex = 5;
            this.btn_rndE.Text = "Oluştur";
            this.btn_rndE.UseVisualStyleBackColor = false;
            this.btn_rndE.Click += new System.EventHandler(this.btn_rndE_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(168, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bir \"e\" Değeri Oluştur";
            // 
            // btn_generateKeys
            // 
            this.btn_generateKeys.BackColor = System.Drawing.Color.White;
            this.btn_generateKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generateKeys.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generateKeys.Location = new System.Drawing.Point(12, 255);
            this.btn_generateKeys.Name = "btn_generateKeys";
            this.btn_generateKeys.Size = new System.Drawing.Size(296, 33);
            this.btn_generateKeys.TabIndex = 5;
            this.btn_generateKeys.Text = "Anahtarları Oluştur";
            this.btn_generateKeys.UseVisualStyleBackColor = false;
            this.btn_generateKeys.Click += new System.EventHandler(this.btn_generateKeys_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(12, 453);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(296, 33);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Temizle";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // RSASifreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(320, 498);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_generateKeys);
            this.Controls.Add(this.btn_rndE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_private);
            this.Controls.Add(this.txt_public);
            this.Controls.Add(this.txt_second);
            this.Controls.Add(this.txt_e);
            this.Controls.Add(this.txt_first);
            this.Controls.Add(this.btn_Geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RSASifreleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSASifreleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RSASifreleme_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Geri;
        private TextBox txt_first;
        private TextBox txt_second;
        private TextBox txt_e;
        private TextBox txt_public;
        private TextBox txt_private;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_rndE;
        private Label label6;
        private Button btn_generateKeys;
        private Button btn_clear;
    }
}