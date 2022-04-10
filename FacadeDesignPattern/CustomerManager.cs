using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
   public class CustomerManager
    {
        int adet = 0;
        public List<Customer> customers = new List<Customer>();
        public void CustomerAdd(Customer customer)
        {
            foreach (var item in customers)
            {
                if (item.TC == customer.TC)
                {
                    adet++;
                }
            }
            if (adet == 0)
            {
                customers.Add(customer);

            }
            adet = 0;

        }
        public void CustomerDelete(Customer customer)
        {
            foreach (var item in customers)
            {
                if (item.TC == customer.TC)
                {
                    customers.Remove(customer);
                }
            }
        }
        public List<Customer> customersbloke = new List<Customer>();
        public void BlokeEkle(Customer customer)
        {
            customersbloke.Add(customer);
        }
        public bool BlokeSorgu(Customer customer)
        {
            foreach (var item in customersbloke)
            {
                if (item.TC == customer.TC)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
