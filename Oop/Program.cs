using System;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            IndivualCustomer indivual = new IndivualCustomer();
            indivual.Id = 1;
            indivual.Name = "Ahmet Furkan";
            indivual.LastName = "Gazioğlu";
            indivual.TcNumber = "1911496841";
            indivual.CustomerNumber = "15153";

            CorporateCustomer corporate = new CorporateCustomer();
            corporate.Id = 1;
            corporate.CustomerNumber = "1562";
            corporate.CompanyName = "AFG";
            corporate.TaxesNumber = "854821546514";

            CustomerManeger customer = new CustomerManeger();
            customer.Add(indivual);
            customer.Add(corporate);
           
        }
    }
}
