using System;
using System.Collections.Generic;
using System.Text;

namespace InterfazDemo
{
    class FinanceCredit : ICreditManeger
    {
        public void Calculate()
        {
            Console.WriteLine("Finance Credit Calculate");
        }

        public void Demo()
        {
            throw new NotImplementedException();
        }
    }
}
