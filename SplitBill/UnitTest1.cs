using Split_Lib; 

namespace SplitBill
{
    [TestClass]
    public class Splitcalc
    {
     // test cases for firts method.   
        [TestMethod]
        public void SplitAmount_WhenAmountIs100AndNumberOfPeopleIs5_ShouldReturn20()
        {
          
            Split_Lib.Splitcalc calculator = new Split_Lib.Splitcalc();

           
            decimal result = calculator.SplitAmount(100, 5);

            
            Assert.AreEqual(20, result);
        }
       [TestMethod]
        public void SplitAmount_WhenAmountIs50AndNumberOfPeopleIs2_ShouldReturn25()
        {
           
            
            Split_Lib.Splitcalc  calculator = new Split_Lib.Splitcalc();

            
            decimal result = calculator.SplitAmount(50, 2);

           
            Assert.AreEqual(25, result);
        }
        [TestMethod]
        public void SplitAmount_WhenAmountIs40AndNumberOfPeopleIs2_ShouldReturn20()
        {
           
            
            Split_Lib.Splitcalc  calculator = new Split_Lib.Splitcalc();

            
            decimal result = calculator.SplitAmount(40, 2);

           
            Assert.AreEqual(20, result);
        }
        // test cases for second method
        [TestMethod]
        public void CalculateTipPerPerson_WithValidInput_ShouldReturnCorrectTipAmount()
        {
            Split_Lib.Splitcalc calculator = new Split_Lib.Splitcalc();
            decimal price = 100.00m;
            int numberOfPatrons = 5;
            float tipPercentage = 15;
            decimal expectedTipPerPerson = 3.00m;

            decimal actualTipPerPerson = calculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

            Assert.AreEqual(expectedTipPerPerson, actualTipPerPerson, "Tip per person should be 3.00");
        }
        [TestMethod]
        public void CalculateTipPerPerson_WithZeroPrice_ShouldReturnZeroTipPerPerson()
        {
           Split_Lib.Splitcalc calculator = new Split_Lib.Splitcalc();
            decimal price = 0m;
            int numberOfPatrons = 5;
            float tipPercentage = 15;
            decimal actualTipPerPerson = calculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);
            Assert.AreEqual(0m, actualTipPerPerson, "Tip per person should be 0.00 for zero price");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateTipPerPerson_WithZeroPatrons_ShouldThrowArgumentException()
        {
            Split_Lib.Splitcalc calculator = new Split_Lib.Splitcalc();
            decimal price = 100.00m;
            int numberOfPatrons = 0;
            float tipPercentage = 15;
            decimal actualTipPerPerson = calculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);
        }
        // test case for third method

        [TestMethod]
        public void CalculateTip_EqualSplit_ShouldReturnCorrectAmounts()
        {
            var tipCalculator = new Split_Lib.Splitcalc();
            var mealCosts = new Dictionary<string, decimal>
            {
                { "venus", 10m },
                { "meet", 20m },
                { "tej", 30m }
            };
            float tipPercentage = 10; 
            var expectedTipAmounts = new Dictionary<string, decimal>
            {
                { "venus", 1m },
                { "meet", 2m },
                { "tej", 3m }
            };
            var actualTipAmounts = tipCalculator.CalculateTip(mealCosts, tipPercentage);
            CollectionAssert.AreEqual(expectedTipAmounts, actualTipAmounts);
        }
        [TestMethod]
        public void CalculateTip_NoCost_ShouldReturnZeroTip()
        {
            var tipCalculator = new Split_Lib.Splitcalc();




            var mealCosts = new Dictionary<string, decimal>
            {
                { "milan", 12m },
                { "sagar", 10m },
                { "pratham", 0m }
            };
            float tipPercentage = 15; // 15% tip



            var expectedTipAmounts = new Dictionary<string, decimal>
            {
                { "milan", 19m },
                { "sagar", 0m },
                { "pratham", 0m }
            };



            var actualTipAmounts = tipCalculator.CalculateTip(mealCosts, tipPercentage);

     
     
     
            CollectionAssert.AreEqual(expectedTipAmounts, actualTipAmounts);
        }
     




    }
}
    