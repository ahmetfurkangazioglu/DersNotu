using System;
using System.Collections.Generic;
using System.Text;

namespace YazılımKampı
{
    class BoxManager
    {
        public void Add(Product product )
        {
            Console.WriteLine("Ürün Eklendi: "+ product.Adi );        
        }
    }
}
