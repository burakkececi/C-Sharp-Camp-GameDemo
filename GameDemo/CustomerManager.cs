using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    public class CustomerManager
    {
        private List<Customer> CustomerList { get; }

        public CustomerManager()
        {
            CustomerList = new List<Customer>();
        }

        public bool Register(Customer customer)
        {
            MernisServiceAdapter mernisService = new MernisServiceAdapter();
            if(customer == null)
            {
                return false;
            }
            else
            {
                if (mernisService.TCKimlikDogrula(customer.NationalId, customer.Name, customer.Surname, customer.DateOfBirth))
                {
                    if (!CustomerList.Contains(customer))
                    {
                        CustomerList.Add(customer);
                        Console.WriteLine("Kayit Basarili: " + customer.Name);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Musteri Zaten Kayitli!");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("TC'niz uyusmamaktadir!");
                    return false;
                }
               
                
            }
            
        }
        public void Delete(Customer customer)
        {
            if (customer == null)
            {
                return;
            }
            else
            {
                CustomerList.Remove(customer);
                Console.WriteLine("Silme Basarili: " + customer.Name);
            }
            
        }

        public Customer Update(string NationalId)
        {
            foreach (Customer customer in CustomerList)
            {
                if (customer.NationalId.Equals(NationalId))
                {
                    return customer;
                }
               
            }
            return null;
        }
    }
}
