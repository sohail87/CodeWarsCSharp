using System;
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
            throw new NotImplementedException();
        }
    }

}
