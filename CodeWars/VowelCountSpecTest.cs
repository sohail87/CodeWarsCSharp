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
            var phrase = "Tomorrow";
            Assert.AreEqual(3, phrase.CountVowels());
        }
        [TestMethod]
        public void GivenTomorrowNeverDiesTodayVowelCountIs9()
        {
            var phrase = "Tomorrow Never Dies Today";
            Assert.AreEqual(9, phrase.CountVowels());
        }
        [TestMethod]
        public void GivenAaEeIiOoUuVowelCountIs10()
        {
            var phrase = "zAzaz zEzez zIziz zOzoz zUzuz";
            Assert.AreEqual(10, phrase.CountVowels());
        }

    }

    public static class ExtensionMethods
    {
        public static int CountVowels(this string value)
        {
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            return vowels.Select(v => value.Count(x => (x == char.ToLower(v) || x == char.ToUpper(v)))).Sum();
        }
    }

}
