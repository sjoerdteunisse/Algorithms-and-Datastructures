using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Core.Lesson_9
{
    public class InterestCalculator
    {

        public static double Calculate(float years, float percentage, float currentAmount)
        {
            if (years == 0)
                return currentAmount;

            currentAmount = currentAmount / 100 * (100 + percentage);
            return Calculate(years - 1, percentage, currentAmount);
        }


        public static float calculateInterest(float initialSum, float interestRate, int years)
        {
            if (years == 0) return initialSum;
            else
                initialSum = initialSum * (1 + interestRate / 100);
            return calculateInterest(initialSum, interestRate, years - 1);
        }
    }
}
