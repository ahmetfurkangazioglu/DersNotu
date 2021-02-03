using System;
using System.Collections.Generic;
using System.Text;

namespace InterfazDemo
{
    class FileLoggerService : ILoggerService
    {
        public void Logg()
        {
            Console.WriteLine("File Logged ");
        }
    }
}
