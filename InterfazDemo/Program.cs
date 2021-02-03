using System;
using System.Collections.Generic;

namespace InterfazDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleCredit vehicleCredit = new VehicleCredit();
            FinanceCredit financeCredit = new FinanceCredit();
            HousingCredit housingCredit = new HousingCredit();
            ILoggerService smsLoggerService = new SmsLoggerService();
            ApplicationManager application = new ApplicationManager();
            application.MakeApplication(vehicleCredit,new List<ILoggerService>() {new FileLoggerService(),new DatabaseLoggerService(),smsLoggerService });
           
            List<ICreditManeger> creditManegers = new List<ICreditManeger>() { vehicleCredit, financeCredit, housingCredit };

            //application.CalsulateCredits(creditManegers);
           
        }
    }
}
