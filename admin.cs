using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class admin
    {
        
        public string ad { get; set; } 
        public string tur { get; set; } 
        public string sahip { get; set; } 

        
        public static List<admin> petKayit = new List<admin>();
       
        public admin() { }

        public admin(string Ad, string Tur, string SahipAdi)
        {
            this.ad = Ad;
            this.tur = Tur;
            this.sahip = SahipAdi;
        }

        public static void PetEkle(string petAdi, string petTuru, string sahipAdi)
        {
            admin yeniPet = new admin(petAdi, petTuru, sahipAdi);
            petKayit.Add(yeniPet);
        }


    }
}
