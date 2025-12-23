using classes;

namespace evcil_hayvan_sahiplenme
{
    public partial class sahiplenme : Form
    {
        private string _aktifKullaniciAdi;
        public sahiplenme()
        {
        }

        public sahiplenme(string kullaniciadi)
        {
            InitializeComponent();
            _aktifKullaniciAdi = kullaniciadi;
        }

        private void sahiplenme_Load(object sender, EventArgs e)
        {
            string petAdi = isimbox.Text;
        }
        

        private void IslemiTamamla(string tur)
        {
            

            if (isimbox.Text == null)
            {
                MessageBox.Show("Lütfen hayvanınıza bir isim verin!");
               
            }


            string petAdi = isimbox.Text;
            admin.PetEkle(petAdi, tur, _aktifKullaniciAdi);
        }
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string gonderilecekAd = isimbox.Text; 
           
            IslemiTamamla("Kedi");
            kediform kediForm = new kediform(gonderilecekAd);
           
            kediForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gonderilecekAd = isimbox.Text; 
            IslemiTamamla("Köpek");

            Form2 kopekForm = new Form2(gonderilecekAd);

            kopekForm.Show();
            this.Hide();
        }
    }
}
