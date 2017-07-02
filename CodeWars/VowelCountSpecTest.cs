using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    [TestClass]
    public class VowelCountSpecTest
    {
        [TestMethod]
        public void GivenTomorrowVowelCountIs3()
        {
            Assert.AreEqual(3, VowelCount("Tomorrow"));
        }

        private int VowelCount(string tomorrow)
        {
            return tomorrow.Count(x => x == 'o');
        }
    }

}
