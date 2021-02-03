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
            ApplicationManager application = new ApplicationManager();
            //application.MakeApplication(vehicleCredit);

            List<ICreditManeger> creditManegers = new List<ICreditManeger>() { vehicleCredit, financeCredit, housingCredit };

            application.CalsulateCredits(creditManegers);
           
        }
    }
}
