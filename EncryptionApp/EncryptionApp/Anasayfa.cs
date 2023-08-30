namespace EncryptionApp
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btn_Sezar_Click(object sender, EventArgs e)
        {
            SezarSifreleme sezarSifreleme= new SezarSifreleme();
            this.Hide();
            sezarSifreleme.Show();
        }

        private void btn_Rsa_Click(object sender, EventArgs e)
        {
            RSASifreleme rsaSifreleme = new RSASifreleme();
            this.Hide();
            rsaSifreleme.Show();
        }

        private void btn_Vigenere_Click(object sender, EventArgs e)
        {
            VigenereSifreleme vigenereSifreleme = new VigenereSifreleme();
            this.Hide();
            vigenereSifreleme.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_md5_Click(object sender, EventArgs e)
        {
            MD5Sifreleme md5Sifreleme = new MD5Sifreleme();
            this.Hide();
            md5Sifreleme.Show();
        }
    }
}