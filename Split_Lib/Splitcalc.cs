using System;

namespace Split_Lib;

    // below is the of the method1
        public class Splitcalc
        {
            
            // below is the logic of the method
        public decimal SplitAmount(decimal amount, int numberOfPeople)
         {
        if (numberOfPeople <= 0)
        {
            throw new ArgumentException("Number of people must be greater than zero.");
        }

        return amount / numberOfPeople;
        }
        

    // below is the of the method2
        public decimal CalculateTipPerPerson(decimal price, int numberOfPatrons, float tipPercentage)
        {
            
            // below is the logic of the method
            if (numberOfPatrons <= 0)
                throw new ArgumentException("Number of members must be greater than zero.");

            decimal totalTip = (decimal)tipPercentage / 100 * price;
            return totalTip / numberOfPatrons;
        }
        
    // below is the of the method3
        public Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
            // below is the logic of the method
            decimal totalMealCost = 0;
            foreach (var pair in mealCosts)
            {
                totalMealCost += pair.Value;
            }

            Dictionary<string, decimal> tipAmounts = new Dictionary<string, decimal>();
            foreach (var pair in mealCosts)
            {
                decimal tipAmount = (decimal)tipPercentage / 100 * pair.Value;
                tipAmounts.Add(pair.Key, tipAmount);
            }

            return tipAmounts;
        }
}