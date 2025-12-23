using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class kediclass : pet, IHayvanEtkilesimi
    {
        public kediclass (string ad) : base(ad, "kedi")
        {
            this.mutluluk = 80;
            this.enerji = 60; //kediler tembeldir

        }
        public  void Besle()
        {
            this.aclik += 20;
            this.mutluluk += 2;
        }

        public  void Oynat()
        {
            this.mutluluk += 15;
            this.enerji -= 10;
        }



    }
}
