namespace EncryptionApp
{
    partial class MD5Sifreleme
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
            this.btn_geri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sifrele = new System.Windows.Forms.Button();
            this.btn_desifrele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txtR_sifrelenen = new System.Windows.Forms.RichTextBox();
            this.txtR_metin = new System.Windows.Forms.RichTextBox();
            this.txt_desifrelenen = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.SeaShell;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_geri.Location = new System.Drawing.Point(12, 12);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(123, 43);
            this.btn_geri.TabIndex = 0;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Metin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifrelenmiş Metin";
            // 
            // btn_sifrele
            // 
            this.btn_sifrele.BackColor = System.Drawing.Color.SeaShell;
            this.btn_sifrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifrele.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sifrele.Location = new System.Drawing.Point(13, 224);
            this.btn_sifrele.Name = "btn_sifrele";
            this.btn_sifrele.Size = new System.Drawing.Size(106, 43);
            this.btn_sifrele.TabIndex = 4;
            this.btn_sifrele.Text = "Şifrele";
            this.btn_sifrele.UseVisualStyleBackColor = false;
            this.btn_sifrele.Click += new System.EventHandler(this.btn_sifrele_Click);
            // 
            // btn_desifrele
            // 
            this.btn_desifrele.BackColor = System.Drawing.Color.SeaShell;
            this.btn_desifrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desifrele.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_desifrele.Location = new System.Drawing.Point(125, 224);
            this.btn_desifrele.Name = "btn_desifrele";
            this.btn_desifrele.Size = new System.Drawing.Size(106, 43);
            this.btn_desifrele.TabIndex = 4;
            this.btn_desifrele.Text = "Şifreyi Çöz";
            this.btn_desifrele.UseVisualStyleBackColor = false;
            this.btn_desifrele.Click += new System.EventHandler(this.btn_desifrele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Çözülmüş Metin";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.SeaShell;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(12, 551);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(219, 32);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Temizle";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txtR_sifrelenen
            // 
            this.txtR_sifrelenen.Location = new System.Drawing.Point(12, 306);
            this.txtR_sifrelenen.Name = "txtR_sifrelenen";
            this.txtR_sifrelenen.Size = new System.Drawing.Size(219, 121);
            this.txtR_sifrelenen.TabIndex = 5;
            this.txtR_sifrelenen.Text = "";
            // 
            // txtR_metin
            // 
            this.txtR_metin.Location = new System.Drawing.Point(12, 92);
            this.txtR_metin.Name = "txtR_metin";
            this.txtR_metin.Size = new System.Drawing.Size(219, 115);
            this.txtR_metin.TabIndex = 6;
            this.txtR_metin.Text = "";
            // 
            // txt_desifrelenen
            // 
            this.txt_desifrelenen.Enabled = false;
            this.txt_desifrelenen.Location = new System.Drawing.Point(12, 463);
            this.txt_desifrelenen.Name = "txt_desifrelenen";
            this.txt_desifrelenen.Size = new System.Drawing.Size(219, 82);
            this.txt_desifrelenen.TabIndex = 7;
            this.txt_desifrelenen.Text = "";
            // 
            // MD5Sifreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(243, 595);
            this.Controls.Add(this.txt_desifrelenen);
            this.Controls.Add(this.txtR_metin);
            this.Controls.Add(this.txtR_sifrelenen);
            this.Controls.Add(this.btn_desifrele);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sifrele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MD5Sifreleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD5Sifreleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MD5Sifreleme_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_geri;
        private Button btn_sifrele;
        private Label label2;
        private Label label1;
        private Button btn_desifrele;
        private Label label3;
        private Button btn_clear;
        private RichTextBox txtR_sifrelenen;
        private RichTextBox txtR_metin;
        private RichTextBox txt_desifrelenen;
    }
}