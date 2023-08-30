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
    public partial class SezarSifreleme : Form
    {
     
        public SezarSifreleme()
        {
            InitializeComponent();
            
        }
        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa= new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void SezarSifreleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_sifreleSezar_Click(object sender, EventArgs e)
        {
            if (txt_sifreSayi.Text != "" && txtR_Sifrelenecek.Text != "")
            {
               
                try
                {
                    CaesarCipher sezar = new CaesarCipher(int.Parse(txt_sifreSayi.Text), txtR_Sifrelenecek.Text);

                    txtR_Sifrelenen.Text = sezar.Encryption();
                }
                catch
                {
                    MessageBox.Show("Lütfen Anahtar Bölümüne 0 ile 255 arasında bir sayı girin.");

                }
            }

            else
            {
                MessageBox.Show("Lütfen gerekli yerleri boş bırakmayın.");
            }
        }

        private void btn_clearEnc_Click(object sender, EventArgs e)
        {
            txtR_Sifrelenecek.Clear();
            txtR_Sifrelenen.Clear();
            txt_sifreSayi.Clear();

        }

        private void btn_desifreleSezar_Click(object sender, EventArgs e)
        {
            if (txt_desifreSayi.Text != "" && txtR_Desifrelenecek.Text != "")
            {
               
                try
                {
                    CaesarCipher sezar2 = new CaesarCipher(int.Parse(txt_desifreSayi.Text), txtR_Desifrelenecek.Text);
   
                    txtR_Desifrelenen.Text = sezar2.Decryption();
                }

                catch
                {
                    MessageBox.Show("Lütfen Anahtar Bölümüne 0 ile 255 arasında bir sayı girin.");
                }
            }
 
            else
            {
                MessageBox.Show("Lütfen gerekli yerleri boş bırakmayın.");
            }
        }
    
        private void btn_clearDec_Click(object sender, EventArgs e)
        {
            txtR_Desifrelenen.Clear();
            txt_desifreSayi.Clear();
            txtR_Desifrelenecek.Clear();
        }
    }
}
