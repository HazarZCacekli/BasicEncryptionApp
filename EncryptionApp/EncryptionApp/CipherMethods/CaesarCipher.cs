using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionApp
{
    public class CaesarCipher
    {
        
        private int anahtar_sayi;     
        private string sifrelenecek;
        private string? sifrelenen;
        
        public CaesarCipher(int anahtar_sayi, string sifrelenecek)
        {
            this.anahtar_sayi = anahtar_sayi;
            this.sifrelenecek = sifrelenecek;
        }


        private bool isTurkish(char c)
        {
            if (c == 'ç' || c == 'Ç' || c == 'ğ' || c == 'Ğ' || c == 'ı' || c == 'İ' || c == 'ö' || c == 'Ö' || c == 'ş' || c == 'Ş' || c == 'ü' || c == 'Ü')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public string Encryption()
        {

            sifrelenen = "";

            for (int i = 0, s = sifrelenecek.Length; i < s; i++)
            {
                
                if (char.IsLetter(sifrelenecek[i]) && !isTurkish(sifrelenecek[i]))
                {
                   
                    int formul;

                    if (char.IsUpper(sifrelenecek[i]))
                    {
                        formul = ((sifrelenecek[i] - 65) + anahtar_sayi) % 26;
                        sifrelenen += (char)(formul + 65);
                    }
                   
                    else
                    {
                        formul = ((sifrelenecek[i] - 97) + anahtar_sayi) % 26;
                        sifrelenen += (char)(formul + 97);
                    }
                }
                
                else
                {
                    sifrelenen += sifrelenecek[i];
                }
            }

            
            return sifrelenen;
        }

        
        public string Decryption()
        {
            
            sifrelenen = "";

            for (int i = 0, s = sifrelenecek.Length; i < s; i++)
            {
                
                if (char.IsLetter(sifrelenecek[i]) && !isTurkish(sifrelenecek[i]))
                {
                    
                    int formul;

                    
                    if (char.IsUpper(sifrelenecek[i]))
                    {
                        formul = ((sifrelenecek[i] - 65) - anahtar_sayi) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifrelenen += (char)(formul + 65);
                    }
                   
                    else
                    {
                        formul = ((sifrelenecek[i] - 97) - anahtar_sayi) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifrelenen += (char)(formul + 97);
                    }
                }
               
                else
                {
                    sifrelenen += sifrelenecek[i];
                }
            }

            
            return sifrelenen;
        }
    }
}
