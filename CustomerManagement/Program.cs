using System;

namespace CustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Ad = "Ahmet";
            customer1.Soyad = "Gazioğlu";
            customer1.Numara = "5651611553";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Ad = "Fatih";
            customer2.Soyad = "Gazi";
            customer2.Numara = "5481611553";

            CustomerManeger customerManeger = new CustomerManeger();
            customerManeger.Add(customer1);
            customerManeger.Add(customer2);

            customerManeger.List(customer1);
            customerManeger.List(customer2);

          
        }
    }
}
