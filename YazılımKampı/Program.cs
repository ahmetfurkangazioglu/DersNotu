using System;

namespace YazılımKampı
{
    class Program
    {
        static void Main(string[] args)
        {
            Product products1 = new Product();
            products1.Adi = "Armut";
            products1.Id = 1;
            products1.Aciklama = "Armutun iyisini Ayılar yer";
            products1.Fiyat = 8;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "Elma";
            product2.Aciklama = "Amasya Elması";
            product2.Fiyat = 5;

            Product[] products = new Product[] { products1, product2 };
            foreach (var product in products)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyat);            
                
            }
            Console.WriteLine("----------Metotlar-------------\n");

            BoxManager boxManager = new BoxManager();
            boxManager.Add(products1);
            boxManager.Add(product2);

        }
    }
}
