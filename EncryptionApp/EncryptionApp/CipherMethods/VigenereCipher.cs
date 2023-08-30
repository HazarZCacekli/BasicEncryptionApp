using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionApp
{
    public class VigenereCipher
    {
        private string keyword;
        private int keyword_length;
        private int keyword_count;
        private string sifrelenecek;
        private string? sifrelenen;

        public VigenereCipher(string keyword, string sifre_yazi)
        {
            this.keyword = keyword;
            this.sifrelenecek = sifre_yazi;
            this.keyword_length = keyword.Length;
        }

        private bool IsTurkish(char c)
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

        public bool IsKeywordInAlphabet()
        {
            bool sonuc = true;

            for (int i = 0, s = keyword_length; i < s; i++)
            {
                if (char.IsLetter(keyword[i]) && !IsTurkish(keyword[i]))
                {
                    continue;
                }
                else
                {
                    sonuc = false;
                    break;
                }
            }

            return sonuc;
        }

        public string Encrypt()
        {
            sifrelenen = "";
            keyword_count = 0;

            for (int i = 0, s = sifrelenecek.Length; i < s; i++)
            {
                if (char.IsLetter(sifrelenecek[i]) && !IsTurkish(sifrelenecek[i]))
                {
                    int formul;

                    if (char.IsUpper(sifrelenecek[i]))
                    {
                        formul = ((sifrelenecek[i] - 65) + (char.ToUpper(keyword[keyword_count % keyword_length]) - 65)) % 26;
                        sifrelenen += (char)(formul + 65);
                        keyword_count++;
                    }
                    else
                    {
                        formul = ((sifrelenecek[i] - 97) + (char.ToLower(keyword[keyword_count % keyword_length]) - 97)) % 26;
                        sifrelenen += (char)(formul + 97);
                        keyword_count++;
                    }
                }
                else
                {
                    sifrelenen += sifrelenecek[i];
                }
            }

            return sifrelenen;
        }

        public string Decrypt()
        {
            sifrelenen = "";
            keyword_count = 0;

            for (int i = 0, s = sifrelenecek.Length; i < s; i++)
            {
                if (char.IsLetter(sifrelenecek[i]) && !IsTurkish(sifrelenecek[i]))
                {
                    int formul;

                    if (char.IsUpper(sifrelenecek[i]))
                    {
                        formul = ((sifrelenecek[i] - 65) - (char.ToUpper(keyword[keyword_count % keyword_length]) - 65)) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifrelenen += (char)(formul + 65);
                        keyword_count++;
                    }
                    else
                    {
                        formul = ((sifrelenecek[i] - 97) - (char.ToLower(keyword[keyword_count % keyword_length]) - 97)) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifrelenen += (char)(formul + 97);
                        keyword_count++;
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
