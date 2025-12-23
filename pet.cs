using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public abstract class pet
    {
        private int Aclik;
        private int Enerji;
        private int Mutluluk;

        public string ad { get; set; }
        public int yasgun { get; set; } = 1;
        public string tur { get; set; }
        public bool uyuyor { get; set; } = false;

        public void UyuBitir() { uyuyor = true; }
        public void UyuBaslat() { uyuyor = false; }


        public string ruhhali { get; set; }

        public int aclik
        {
            get { return Aclik; }
            set
            {
                if (value < 0)
                    Aclik = 0;
                else if (value > 100)
                    Aclik = 100;
                else
                    Aclik = value;
            }
        }
        public int enerji
        {
            get { return Enerji; }
            set
            {
                if (value < 0)
                    Enerji = 0;
                else if (value > 100)
                    Enerji = 100;
                else
                    Enerji = value;
            }
        }
        public int mutluluk
        {
            get { return Mutluluk; }
            set
            {
                if (value < 0)
                    Mutluluk = 0;
                else if (value > 100)
                    Mutluluk = 100;
                else
                    Mutluluk = value;
            }
        }
        public pet (string Ad, string Tur)
        {
            ad = Ad;
            tur = Tur;

            aclik = 50;
            enerji = 50;
            mutluluk = 50;
            ruhhali = "Normal";
        }


        public string DurumKontrol()
        {
            if (aclik<= 10 || enerji <= 10)
            {
                ruhhali = "KRİTİK";
            }
            else if (aclik > 10 && aclik <= 30 || enerji > 10 && enerji <= 30)
            {
                ruhhali = "KÖTÜ";
            }
            else if (aclik > 30 && aclik <= 70 || enerji > 30 && enerji <= 70)
            {
                ruhhali = "NORMAL";
            }
            else
            {
                ruhhali = "MUTLU";
            }
            return ruhhali;
        }

        public virtual void DurumuAzalt()
        {
            if (!uyuyor)
            {
                aclik -= 5;
                enerji -= 5;
                
            }
            else if (uyuyor)
            {
                enerji += 10;
                if (enerji >= 100) { UyuBitir(); }

            }
            DurumKontrol();
        }
        public void YasArttir() { yasgun++;}

    }
}
