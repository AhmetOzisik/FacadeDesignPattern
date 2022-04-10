using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
   public class BankaHesap
    {
       static double Bakiye;
        
        public double BankaHesapParaDüs(int para)
        {
            Bakiye = Bakiye - para;
            return Bakiye;
        }
        public double BankaHesapYükselt(int para)
        {
            Bakiye = Bakiye + para;
            return Bakiye;
        }
        public double BakiyeGöster()
        {
            return Bakiye;
        }
    }
}
