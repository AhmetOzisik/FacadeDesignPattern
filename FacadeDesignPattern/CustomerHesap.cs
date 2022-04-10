using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
   public class CustomerHesap
    {
        CustomerManager customerManager = new CustomerManager();
        
       
        int Bakiye=1000;
        
        
        
        public int MüsteriBakiyeDüs(Customer customer,int para)
        {
            Bakiye = Bakiye - para;
            if (Bakiye < 0)
            {
                customerManager.customersbloke.Add(customer);
            }
            return Bakiye;
        }
        public int MüsteriBakiyeEkle(Customer customer, int para)
        {
            Bakiye = Bakiye + para;
            return Bakiye;
        }
    }
}
