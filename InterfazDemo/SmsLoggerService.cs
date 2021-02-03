using System;
using System.Collections.Generic;
using System.Text;

namespace InterfazDemo
{
    class SmsLoggerService : ILoggerService
    {
        public void Logg()
        {
            Console.WriteLine("Sms Logged");
        }
    }
}
