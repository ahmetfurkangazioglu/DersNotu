using System;
using System.Collections.Generic;
using System.Text;

namespace InterfazDemo
{
     class DatabaseLoggerService : ILoggerService
    {
        public void Logg()
        {
            Console.WriteLine("Database Logged");
        }
    }
}
