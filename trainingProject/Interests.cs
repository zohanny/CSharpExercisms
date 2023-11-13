using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    static class SavingsAccount
    {
        public static float InterestRate(decimal balance)
        {
            float interest;

            if (balance<30 )
                interest = 3.213f;
            else if (balance < 1000)
                interest = 0.5f;
            else if (balance < 5000)
                interest = 1.621f;
            else
                interest = 2.475f;

            return interest;
        }

        public static decimal Interest(decimal balance)
        {
            throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
        }

        public static decimal AnnualBalanceUpdate(decimal balance)
        {
            throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
        }

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
        }
    }
}
