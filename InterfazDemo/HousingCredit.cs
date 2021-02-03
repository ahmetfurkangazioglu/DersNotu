using System;
using System.Collections.Generic;
using System.Text;

namespace InterfazDemo
{
    class HousingCredit : ICreditManeger
    {
        public void Calculate()
        {
            Console.WriteLine("Housing Credit Calculate");
        }

        public void Demo()
        {
            throw new NotImplementedException();
        }
    }
}
