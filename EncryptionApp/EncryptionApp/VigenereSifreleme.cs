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
    public partial class VigenereSifreleme : Form
    {
        public VigenereSifreleme()
        {
            InitializeComponent();
        }
        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void VigenereSifreleme_Load(object sender, EventArgs e)
        {

        }

        private void VigenereSifreleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txtR_keyword.Clear();
            txtR_sifrelenecek.Clear();
            txtR_sifrelenen.Clear();
        }

        private void btn_sifrele_Click(object sender, EventArgs e)
        {
            if (txtR_keyword.Text != "" && txtR_sifrelenecek.Text != "")
            {
                VigenereCipher vigenere = new VigenereCipher(txtR_keyword.Text, txtR_sifrelenecek.Text);

                if (vigenere.IsKeywordInAlphabet())
                {
                    txtR_sifrelenen.Text = vigenere.Encrypt();
                }
                else
                {
                    MessageBox.Show("Lütfen anahtar kelimeye İngilizce karakter dışında birşey girmeyiniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen kutuları boş bırakmayınız.");
            }
        }

        private void btn_d_clear_Click(object sender, EventArgs e)
        {
            txtR_desifrelenecek.Clear();
            txtR_desifrelenen.Clear();
            txtR_d_keyword.Clear();
        }

        private void btn_desifrele_Click(object sender, EventArgs e)
        {
            if (txtR_desifrelenecek.Text != "" && txtR_d_keyword.Text != "")
            {
                VigenereCipher vigenere = new VigenereCipher(txtR_d_keyword.Text, txtR_desifrelenecek.Text);

                if (vigenere.IsKeywordInAlphabet())
                {
                    txtR_desifrelenen.Text = vigenere.Decrypt();
                }
                else
                {
                    MessageBox.Show("Lütfen anahtar kelimeye İngilizce karakter dışında birşey girmeyiniz.");
                }
            }

            else
            {
                MessageBox.Show("Lütfen kutuları boş bırakmayınız.");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
