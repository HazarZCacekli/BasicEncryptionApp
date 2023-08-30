using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionApp
{
    public partial class MD5Sifreleme : Form
    {
        
        public MD5Sifreleme()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void btn_sifrele_Click(object sender, EventArgs e)
        {
            txtR_sifrelenen.Text = "";
            MD5Cipher md5Cipher = new MD5Cipher();
            string text = txtR_metin.Text;
            txtR_sifrelenen.Text = md5Cipher.Encrypt(text,"abc");

        }

        private void btn_desifrele_Click(object sender, EventArgs e)
        {
            txt_desifrelenen.Text ="";
            MD5Cipher md5Cipher2 = new MD5Cipher();
            string text = txtR_metin.Text;
            txt_desifrelenen.Text = md5Cipher2.Decrypt(text, "abc");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_desifrelenen.Clear();
            txtR_metin.Clear();
            txtR_sifrelenen.Clear();
        }

        private void MD5Sifreleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
