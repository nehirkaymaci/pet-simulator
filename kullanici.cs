namespace classes
{
    public class kullanici
    {
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string rol { get; set; }

        public kullanici(string kullaniciAdi, string sifre, string rol)
        {
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.rol = rol;
        }
        public kullanici()
        {
        }
    }

    

}
