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
    public partial class RSASifreleme : Form
    {
  
        public RSASifreleme()
        {
            InitializeComponent();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void RSASifreleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_first.Clear();
            txt_e.Clear();
            txt_second.Clear();
            txt_public.Clear();
            txt_private.Clear();
        }
        private void btn_rndE_Click(object sender, EventArgs e)
        {
            if (txt_first.Text!=""&& txt_second.Text!="")
            {
                try
                {
                    bool asal_check_e = false;
                    while (asal_check_e == false)
                    {
                        int totient = (int.Parse(txt_first.Text) - 1) * (int.Parse(txt_second.Text) - 1);
                        
                        Random rnd = new Random();

                        int randomint = rnd.Next(2, totient);

                        for (int i = totient; i >= 1; i--)
                        {
                            
                            if (i == 1)
                            {
                                txt_e.Text = randomint.ToString();
                                asal_check_e = true;
                                break;

                            }

                            if (totient % i == 0 && randomint % i == 0)
                            {
                                
                                break;
                            }

                        }
                          
                    }
                    
                }
                catch 
                {
                    MessageBox.Show("Lütfen İlk Asal Sayı ve İkinci Asal Sayı bölümlerine geçerli olabilecek sayı değerleri giriniz.");
                }
            }
            else 
            {
                MessageBox.Show("Lütfen İlk Asal Sayı ve İkinci Asal Sayı değerlerini boş bırakmayınız.");
            };

        }

        private void btn_generateKeys_Click(object sender, EventArgs e)
        {
            if (txt_first.Text != "" && txt_second.Text != "" && txt_e.Text != "")
            {
                
                    try
                    {  
                        int sayac1 = 0;
                        int sayac2 = 0;
                        int sayi1 = int.Parse(txt_first.Text);
                        int sayi2 = int.Parse(txt_second.Text);
                        int asal_count1 = 2;
                        int asal_count2 = 2;
                        while (asal_count1 < sayi1)
                        {
                            if (sayi1 % asal_count1 == 0)
                            {
                                sayac1++;
                                asal_count1++;
                            }
                            else
                            {
                                asal_count1++;
                            }
                        }
                        while (asal_count2 < sayi2)
                        {
                            if (sayi2 % asal_count2 == 0)
                            {
                                sayac2++;
                                asal_count2++;
                            }
                            else
                            {
                                asal_count2++;
                            }
                        }

                        if (sayac1==0 && sayac2 ==0)
                        {
                        RSACipher rsaCipher = new RSACipher(int.Parse(txt_first.Text), int.Parse(txt_second.Text), int.Parse(txt_e.Text));

                        txt_public.Text = rsaCipher.public_keyword();
                        txt_private.Text = rsaCipher.private_keyword();
                        }
                        else
                        {
                            MessageBox.Show("Girdiğiniz Sayılar Asal Değildir. Lütfen Gerekli Olan Kısımlara Asal Sayı Giriniz");
                        }
 
                    }
                    catch
                    {
                        MessageBox.Show("Lütfen Bu İşlemi Gerçekleştirmekte Gerekli Olan Asal Sayı Değerleri Ve \"e\" Değerlerini Belirtilen Koşullar Çerçevesinde Giriniz!");
                    }
                
            }
            else 
            {
                MessageBox.Show("Lütfen Bu İşlemi Gerçekleştirmekte Gerekli Olan Asal Sayı Değerleri Ve \"e\" Değerlerini Boş Bırakmayınız!!");
            }
        }
 
    }
}
