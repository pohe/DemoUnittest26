using System;
using System.Collections.Generic;
using System.Text;

namespace DemoUnittest26
{
    public class MediCare
    {
        public double SubsidisedExpense(double expense)
        {

            if (expense < 0)
            {
                throw new ArgumentException("Expense kan ikke være mindre end 0");
            }
            else if (expense < 1045)
            {
                return 0;
            }
            else if (expense < 1750)
            {
                return 50;
            }
            else if (expense < 3795)
            {
                return 75;
            }
            else if (expense < 20636)
            {
                return 85;
            }
            else
                return 100; 
        }
    }
}
