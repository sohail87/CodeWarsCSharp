using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TribonacciSequence
{
    [TestClass]
    public class SequenceSpecTest
    {
        private Xbonacci variabonacci;

        [TestMethod]
        public void WhenN_IsZeroReturnArrayWithOneItemOfZero()
        {
            variabonacci = new Xbonacci();
            CollectionAssert.AreEqual(new double[] { 0 }, variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 0));
        }
        [TestMethod]
        public void WhenN_IsTenReturnValidSequenceForAllSignatures()
        {
            variabonacci = new Xbonacci();
            CollectionAssert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, variabonacci.Tribonacci(new double[] { 0, 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, variabonacci.Tribonacci(new double[] { 0, 1, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 10));
        }
        [TestMethod]
        public void WhenN_IsElevenReturnValidSequenceForAllSignatures()
        {
            variabonacci = new Xbonacci();
            CollectionAssert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105, 193 }, variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 11));
        }
    }
    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0) return new double[1] { 0 };
            var sequence = new double[n];
            Array.Copy(signature, 0, sequence, 0, signature.Length);
            for (var i = signature.Length; i < n; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2] + sequence[i - 3];
            }
            return sequence;

        }
    }
}
