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
                return expense - 0;
            }
            else if (expense < 1750)
            {
                return expense - 50;
            }
            else if (expense < 3795)
            {
                return expense - 75;
            }
            else if (expense < 20636)
            {
                return expense- 85;
            }
            else
                return expense- 100; 
        }
    }
}
