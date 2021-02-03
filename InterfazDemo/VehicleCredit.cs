using System;
using System.Collections.Generic;
using System.Text;

namespace InterfazDemo
{
    class VehicleCredit : ICreditManeger
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle Credit Calculate");
        }

        public void Demo()
        {
            throw new NotImplementedException();
        }
    }
}
