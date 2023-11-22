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

            if (balance<0 )
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
            => (decimal) (InterestRate(balance)/100 * (float) balance);


        public static decimal AnnualBalanceUpdate(decimal balance)
            => balance + Interest(balance);

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int years = 0;
            while (balance<=targetBalance && balance>=0)
            {
                balance = AnnualBalanceUpdate(balance);
                years++;
            }
            return years;
        }
    }
}
