namespace EncryptionApp
{
    partial class VigenereSifreleme
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
            this.btn_sifrele = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtR_sifrelenen = new System.Windows.Forms.RichTextBox();
            this.txtR_keyword = new System.Windows.Forms.RichTextBox();
            this.txtR_sifrelenecek = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtR_desifrelenen = new System.Windows.Forms.RichTextBox();
            this.txtR_d_keyword = new System.Windows.Forms.RichTextBox();
            this.txtR_desifrelenecek = new System.Windows.Forms.RichTextBox();
            this.btn_desifrele = new System.Windows.Forms.Button();
            this.btn_d_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.White;
            this.btn_Geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Geri.Location = new System.Drawing.Point(12, 12);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(121, 43);
            this.btn_Geri.TabIndex = 1;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_sifrele
            // 
            this.btn_sifrele.BackColor = System.Drawing.Color.White;
            this.btn_sifrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifrele.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sifrele.Location = new System.Drawing.Point(18, 238);
            this.btn_sifrele.Name = "btn_sifrele";
            this.btn_sifrele.Size = new System.Drawing.Size(131, 44);
            this.btn_sifrele.TabIndex = 2;
            this.btn_sifrele.Text = "Şifrele";
            this.btn_sifrele.UseVisualStyleBackColor = false;
            this.btn_sifrele.Click += new System.EventHandler(this.btn_sifrele_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.White;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_temizle.Location = new System.Drawing.Point(18, 361);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(131, 44);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(178)))), ((int)(((byte)(150)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtR_sifrelenen);
            this.groupBox1.Controls.Add(this.txtR_keyword);
            this.groupBox1.Controls.Add(this.txtR_sifrelenecek);
            this.groupBox1.Controls.Add(this.btn_sifrele);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(158, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 427);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anahtar Kelime :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şifrelenecek Yazı :";
            // 
            // txtR_sifrelenen
            // 
            this.txtR_sifrelenen.Enabled = false;
            this.txtR_sifrelenen.Location = new System.Drawing.Point(155, 304);
            this.txtR_sifrelenen.Name = "txtR_sifrelenen";
            this.txtR_sifrelenen.Size = new System.Drawing.Size(264, 101);
            this.txtR_sifrelenen.TabIndex = 3;
            this.txtR_sifrelenen.Text = "";
            // 
            // txtR_keyword
            // 
            this.txtR_keyword.Location = new System.Drawing.Point(155, 181);
            this.txtR_keyword.Name = "txtR_keyword";
            this.txtR_keyword.Size = new System.Drawing.Size(264, 101);
            this.txtR_keyword.TabIndex = 3;
            this.txtR_keyword.Text = "";
            // 
            // txtR_sifrelenecek
            // 
            this.txtR_sifrelenecek.Location = new System.Drawing.Point(155, 58);
            this.txtR_sifrelenecek.Name = "txtR_sifrelenecek";
            this.txtR_sifrelenecek.Size = new System.Drawing.Size(264, 101);
            this.txtR_sifrelenecek.TabIndex = 3;
            this.txtR_sifrelenecek.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(178)))), ((int)(((byte)(150)))));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtR_desifrelenen);
            this.groupBox2.Controls.Add(this.txtR_d_keyword);
            this.groupBox2.Controls.Add(this.txtR_desifrelenecek);
            this.groupBox2.Controls.Add(this.btn_desifrele);
            this.groupBox2.Controls.Add(this.btn_d_clear);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(612, -10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 427);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Anahtar Kelime :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Deşifrelenecek Yazı :";
            // 
            // txtR_desifrelenen
            // 
            this.txtR_desifrelenen.Enabled = false;
            this.txtR_desifrelenen.Location = new System.Drawing.Point(155, 304);
            this.txtR_desifrelenen.Name = "txtR_desifrelenen";
            this.txtR_desifrelenen.Size = new System.Drawing.Size(264, 101);
            this.txtR_desifrelenen.TabIndex = 3;
            this.txtR_desifrelenen.Text = "";
            // 
            // txtR_d_keyword
            // 
            this.txtR_d_keyword.Location = new System.Drawing.Point(155, 181);
            this.txtR_d_keyword.Name = "txtR_d_keyword";
            this.txtR_d_keyword.Size = new System.Drawing.Size(264, 101);
            this.txtR_d_keyword.TabIndex = 3;
            this.txtR_d_keyword.Text = "";
            // 
            // txtR_desifrelenecek
            // 
            this.txtR_desifrelenecek.Location = new System.Drawing.Point(155, 58);
            this.txtR_desifrelenecek.Name = "txtR_desifrelenecek";
            this.txtR_desifrelenecek.Size = new System.Drawing.Size(264, 101);
            this.txtR_desifrelenecek.TabIndex = 3;
            this.txtR_desifrelenecek.Text = "";
            // 
            // btn_desifrele
            // 
            this.btn_desifrele.BackColor = System.Drawing.Color.White;
            this.btn_desifrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desifrele.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_desifrele.Location = new System.Drawing.Point(18, 238);
            this.btn_desifrele.Name = "btn_desifrele";
            this.btn_desifrele.Size = new System.Drawing.Size(131, 44);
            this.btn_desifrele.TabIndex = 2;
            this.btn_desifrele.Text = "Deşifrele";
            this.btn_desifrele.UseVisualStyleBackColor = false;
            this.btn_desifrele.Click += new System.EventHandler(this.btn_desifrele_Click);
            // 
            // btn_d_clear
            // 
            this.btn_d_clear.BackColor = System.Drawing.Color.White;
            this.btn_d_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_d_clear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_d_clear.Location = new System.Drawing.Point(17, 361);
            this.btn_d_clear.Name = "btn_d_clear";
            this.btn_d_clear.Size = new System.Drawing.Size(131, 44);
            this.btn_d_clear.TabIndex = 2;
            this.btn_d_clear.Text = "Temizle";
            this.btn_d_clear.UseVisualStyleBackColor = false;
            this.btn_d_clear.Click += new System.EventHandler(this.btn_d_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(155, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifreleme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(155, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Deşifreleme";
            // 
            // VigenereSifreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(178)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1057, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VigenereSifreleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VigenereSifreleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VigenereSifreleme_FormClosing);
            this.Load += new System.EventHandler(this.VigenereSifreleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Geri;
        private Button btn_sifrele;
        private Button btn_temizle;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private RichTextBox txtR_sifrelenen;
        private RichTextBox txtR_keyword;
        private RichTextBox txtR_sifrelenecek;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private RichTextBox txtR_desifrelenen;
        private RichTextBox txtR_d_keyword;
        private RichTextBox txtR_desifrelenecek;
        private Button btn_desifrele;
        private Button btn_d_clear;
        private Label label5;
        private Label label6;
    }
}