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
        [TestMethod]
        public void GivenTomorrowNeverDiesTodayVowelCountIs9()
        {
            Assert.AreEqual(9, VowelCount("Tomorrow Never Dies Today"));
        }
        [TestMethod]
        public void GivenAaEeIiOoUuVowelCountIs10()
        {
            Assert.AreEqual(10, VowelCount("zAzaz zEzez zIziz zOzoz zUzuz"));
        }

        private int VowelCount(string phrase)
        {
            var vowels = new[] {'a', 'e', 'i', 'o', 'u'};
            return vowels.Select(v => phrase.Count(x => (x == char.ToLower(v) || x == char.ToUpper(v)))).Sum();
        }
    }

}
