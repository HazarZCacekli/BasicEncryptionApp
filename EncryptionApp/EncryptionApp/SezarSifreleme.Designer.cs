namespace EncryptionApp
{
    partial class SezarSifreleme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clearEnc = new System.Windows.Forms.Button();
            this.btn_sifreleSezar = new System.Windows.Forms.Button();
            this.txt_sifreSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtR_Sifrelenen = new System.Windows.Forms.RichTextBox();
            this.txtR_Sifrelenecek = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clearDec = new System.Windows.Forms.Button();
            this.btn_desifreleSezar = new System.Windows.Forms.Button();
            this.txt_desifreSayi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtR_Desifrelenen = new System.Windows.Forms.RichTextBox();
            this.txtR_Desifrelenecek = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.Location = new System.Drawing.Point(12, 12);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(121, 43);
            this.btn_Geri.TabIndex = 5;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btn_clearEnc);
            this.groupBox1.Controls.Add(this.btn_sifreleSezar);
            this.groupBox1.Controls.Add(this.txt_sifreSayi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtR_Sifrelenen);
            this.groupBox1.Controls.Add(this.txtR_Sifrelenecek);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(162, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifreleme";
            // 
            // btn_clearEnc
            // 
            this.btn_clearEnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_clearEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearEnc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clearEnc.Location = new System.Drawing.Point(469, 175);
            this.btn_clearEnc.Name = "btn_clearEnc";
            this.btn_clearEnc.Size = new System.Drawing.Size(114, 49);
            this.btn_clearEnc.TabIndex = 7;
            this.btn_clearEnc.Text = "Temizle";
            this.btn_clearEnc.UseVisualStyleBackColor = false;
            this.btn_clearEnc.Click += new System.EventHandler(this.btn_clearEnc_Click);
            // 
            // btn_sifreleSezar
            // 
            this.btn_sifreleSezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_sifreleSezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifreleSezar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sifreleSezar.Location = new System.Drawing.Point(146, 175);
            this.btn_sifreleSezar.Name = "btn_sifreleSezar";
            this.btn_sifreleSezar.Size = new System.Drawing.Size(114, 49);
            this.btn_sifreleSezar.TabIndex = 6;
            this.btn_sifreleSezar.Text = "Şifrele";
            this.btn_sifreleSezar.UseVisualStyleBackColor = false;
            this.btn_sifreleSezar.Click += new System.EventHandler(this.btn_sifreleSezar_Click);
            // 
            // txt_sifreSayi
            // 
            this.txt_sifreSayi.Location = new System.Drawing.Point(6, 201);
            this.txt_sifreSayi.Name = "txt_sifreSayi";
            this.txt_sifreSayi.Size = new System.Drawing.Size(115, 29);
            this.txt_sifreSayi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(329, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifrelenmiş Metin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sayı Tipinde Anahtar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şifrelenecek Metin";
            // 
            // txtR_Sifrelenen
            // 
            this.txtR_Sifrelenen.Enabled = false;
            this.txtR_Sifrelenen.Location = new System.Drawing.Point(329, 59);
            this.txtR_Sifrelenen.Name = "txtR_Sifrelenen";
            this.txtR_Sifrelenen.Size = new System.Drawing.Size(254, 92);
            this.txtR_Sifrelenen.TabIndex = 3;
            this.txtR_Sifrelenen.Text = "";
            // 
            // txtR_Sifrelenecek
            // 
            this.txtR_Sifrelenecek.Location = new System.Drawing.Point(6, 59);
            this.txtR_Sifrelenecek.Name = "txtR_Sifrelenecek";
            this.txtR_Sifrelenecek.Size = new System.Drawing.Size(254, 92);
            this.txtR_Sifrelenecek.TabIndex = 3;
            this.txtR_Sifrelenecek.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.btn_clearDec);
            this.groupBox2.Controls.Add(this.btn_desifreleSezar);
            this.groupBox2.Controls.Add(this.txt_desifreSayi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtR_Desifrelenen);
            this.groupBox2.Controls.Add(this.txtR_Desifrelenecek);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(162, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 256);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deşifreleme";
            // 
            // btn_clearDec
            // 
            this.btn_clearDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_clearDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearDec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clearDec.Location = new System.Drawing.Point(469, 175);
            this.btn_clearDec.Name = "btn_clearDec";
            this.btn_clearDec.Size = new System.Drawing.Size(114, 49);
            this.btn_clearDec.TabIndex = 9;
            this.btn_clearDec.Text = "Temizle";
            this.btn_clearDec.UseVisualStyleBackColor = false;
            this.btn_clearDec.Click += new System.EventHandler(this.btn_clearDec_Click);
            // 
            // btn_desifreleSezar
            // 
            this.btn_desifreleSezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_desifreleSezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desifreleSezar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_desifreleSezar.Location = new System.Drawing.Point(146, 175);
            this.btn_desifreleSezar.Name = "btn_desifreleSezar";
            this.btn_desifreleSezar.Size = new System.Drawing.Size(114, 49);
            this.btn_desifreleSezar.TabIndex = 8;
            this.btn_desifreleSezar.Text = "Deşifrele";
            this.btn_desifreleSezar.UseVisualStyleBackColor = false;
            this.btn_desifreleSezar.Click += new System.EventHandler(this.btn_desifreleSezar_Click);
            // 
            // txt_desifreSayi
            // 
            this.txt_desifreSayi.Location = new System.Drawing.Point(6, 201);
            this.txt_desifreSayi.Name = "txt_desifreSayi";
            this.txt_desifreSayi.Size = new System.Drawing.Size(115, 29);
            this.txt_desifreSayi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(329, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Deşifrelenmiş Metin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sayı Tipinde Anahtar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Deşifrelenecek Metin";
            // 
            // txtR_Desifrelenen
            // 
            this.txtR_Desifrelenen.Enabled = false;
            this.txtR_Desifrelenen.Location = new System.Drawing.Point(329, 59);
            this.txtR_Desifrelenen.Name = "txtR_Desifrelenen";
            this.txtR_Desifrelenen.Size = new System.Drawing.Size(254, 92);
            this.txtR_Desifrelenen.TabIndex = 5;
            this.txtR_Desifrelenen.Text = "";
            // 
            // txtR_Desifrelenecek
            // 
            this.txtR_Desifrelenecek.Location = new System.Drawing.Point(6, 59);
            this.txtR_Desifrelenecek.Name = "txtR_Desifrelenecek";
            this.txtR_Desifrelenecek.Size = new System.Drawing.Size(254, 92);
            this.txtR_Desifrelenecek.TabIndex = 3;
            this.txtR_Desifrelenecek.Text = "";
            // 
            // SezarSifreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(758, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SezarSifreleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SezarSifreleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SezarSifreleme_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Geri;
        private GroupBox groupBox1;
        private Button btn_clearEnc;
        private Button btn_sifreleSezar;
        private TextBox txt_sifreSayi;
        private Label label2;
        private Label label3;
        private Label label1;
        private RichTextBox txtR_Sifrelenen;
        private RichTextBox txtR_Sifrelenecek;
        private GroupBox groupBox2;
        private Button btn_clearDec;
        private Button btn_desifreleSezar;
        private TextBox txt_desifreSayi;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox txtR_Desifrelenen;
        private RichTextBox txtR_Desifrelenecek;
    }
}