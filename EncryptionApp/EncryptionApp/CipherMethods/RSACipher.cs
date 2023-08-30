using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionApp
{
    
    public class RSACipher
    {
        private int x;
        private int y;
        private int n;
        private int totient;
        private int e;
        private int d;
        private string? ortak_anahtar;
        private string? ozel_anahtar;


        public RSACipher(int x,int y,int e)
        {
            this.x= x;
            this.y= y;
            this.e= e;
        }
        
        public string public_keyword()
        {
            n = x * y;
            totient = (x - 1) * (y - 1);

            d = totient % e;

            ortak_anahtar = $"m^{e} (mod {n})";

            return ortak_anahtar;
        }

        public string private_keyword() 
        {
            n = x * y;
            totient = (x - 1) * (y - 1);

            d = totient % e;

            ozel_anahtar = $"c^{d} (mod {totient})";

            return ozel_anahtar;
        }
    }
}
