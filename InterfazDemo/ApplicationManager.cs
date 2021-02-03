using System;
using System.Collections.Generic;
using System.Text;


namespace InterfazDemo
{
    class ApplicationManager
    {
        public void MakeApplication(ICreditManeger creditManeger)
        {
            creditManeger.Calculate();
        }
        public void CalsulateCredits(List<ICreditManeger> creditManegers)
        {
            foreach (var credits in creditManegers)
            {
                credits.Calculate();
            }
        }
    }
}
