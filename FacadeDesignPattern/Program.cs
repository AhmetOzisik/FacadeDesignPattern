using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
   public class Program
    {
        static void Main(string[] args)
        { 
            Customer customer = new Customer{ Name = "Ahmet", TC = "12345678912", HesapNo = 123 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customer);
            CustomerHesap customerHesap = new CustomerHesap();
            customerHesap.MüsteriBakiyeEkle(customer, 100);
            BankaHesap bankaHesap = new BankaHesap();
            bankaHesap.BankaHesapYükselt(1000);
            Kredi kredi = new Kredi();
            Console.WriteLine(kredi.KrediCek(customer,200000));
            Console.ReadLine();
            
            
        }
    }
}
