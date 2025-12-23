using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class köpekclass : pet , IHayvanEtkilesimi
    {
        public köpekclass(string ad): base( ad, "köpek")
        {
            this.mutluluk = 100; // genelde de mutludurlar :))
            this.enerji = 80; //köpekler aktiftir
        }

        public  void Besle()
        {
            this.aclik += 30;
            this.mutluluk += 15;
        }
        public void Oynat()
        {
            this.mutluluk += 24;
            this.enerji -= 20;
            this.aclik -= 10;
        }
    }
    
}

