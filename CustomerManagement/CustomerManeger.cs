using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement
{
    class CustomerManeger
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi: "+customer.Id+","+customer.Ad+","+customer.Soyad+","+customer.Numara);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi " + customer.Id + "," + customer.Ad + "," + customer.Soyad + "," + customer.Numara);
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Müşteri Listelendi: " + customer.Id + "," + customer.Ad + "," + customer.Soyad + "," + customer.Numara);
        }
    }
}
