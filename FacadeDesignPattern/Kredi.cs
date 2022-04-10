using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
   public class Kredi
    {
        
        BankaHesap bankaHesap = new BankaHesap();
        CustomerManager customerManager = new CustomerManager();
        public bool KrediCek(Customer customer,int para)
        {
            foreach (var item in customerManager.customersbloke)
            {
                if (item.TC == customer.TC)
                {
                    return false;
                }
            }
            if (bankaHesap.BakiyeGöster() <= 0.0 || bankaHesap.BakiyeGöster() < para)
            {
                return false;
            }
            bankaHesap.BankaHesapParaDüs(para);
            return true;
        }
    }
}
