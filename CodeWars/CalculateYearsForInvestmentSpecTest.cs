using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    [TestClass]
    public class CalculateYearsForInvestmentSpecTest
    {
        [TestMethod]
        public void GetNumberOfYears0()
        {
            Assert.AreEqual(0, Kata.CalculateYears(1000, 0.05, 0.18, 1000));
        }
        [TestMethod]
        public void GetNumberOfYears1()
        {
            Assert.AreEqual(14, Kata.CalculateYears(1000, 0.01625, 0.18, 1200));
        }
    }
    public class Kata
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            var years = 0;
            var newPrincipal = principal;
            while (newPrincipal < desiredPrincipal)
            {
                years++;
                var moneyGainedFromInterest = newPrincipal * interest;
                var payableTaxOnInterest = moneyGainedFromInterest * tax;
                var profit = moneyGainedFromInterest - payableTaxOnInterest;
                newPrincipal += profit;
            }
            return years;
        }
    }
}
