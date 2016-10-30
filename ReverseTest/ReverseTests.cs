using System;
using Reverse;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseTest
{
    [TestClass]
    public class ReverseTests
    {
        bool testShort = true;
        readonly string original = "To be trusted is a greater compliment than to be loved.";
        readonly string reversed = ".devol eb ot naht tnemilpmoc retaerg a si detsurt eb oT";
        
        public ReverseTests()
        {
            if(!testShort)
            {
                original = string.Join("\n", System.IO.File.ReadAllLines("original.txt"));
                reversed = string.Join("\n", System.IO.File.ReadAllLines("reversed.txt"));
            }
        }

        [TestMethod]
        public void IteratorTest()
        {
            Assert.AreEqual(Reverses.Iterator(original), reversed);
        }

        [TestMethod]
        public void XORTest()
        {
            Assert.AreEqual(Reverses.XOR(original), reversed);
        }

        [TestMethod]
        public void LinqTest()
        {
            Assert.AreEqual(Reverses.Linq(original), reversed);
        }
        
        [TestMethod]
        public void ArrayTest()
        {
            Assert.AreEqual(Reverses.Array(original), reversed);
        }

        [TestMethod]
        public void YieldTest()
        {
            Assert.AreEqual(Reverses.Yield(original), reversed);
        }

        [TestMethod]
        public void VBTest()
        {
            Assert.AreEqual(Reverses.VisualBasic(original), reversed);
        }

        [TestMethod]
        public void PointerTest()
        {
            Assert.AreEqual(Reverses.Pointer(original), reversed);
        }

        [TestMethod]
        public void ConcatTest()
        {
            Assert.AreEqual(Reverses.Concat(original), reversed);
        }
        
        [TestMethod]
        public void StackSBTest()
        {
            Assert.AreEqual(Reverses.StackSB(original), reversed);
        }

        [TestMethod]
        public void StackYieldTest()
        {
            Assert.AreEqual(Reverses.StackYield(original), reversed);
        }

        [TestMethod]
        public void StackTest()
        {
            Assert.AreEqual(Reverses.StackYield(original), reversed);
        }

        [TestMethod]
        public void RecursiveTest()
        {
            if (original.Length > 10000) Assert.Fail();
            Assert.AreEqual(Reverses.Recursive(original), reversed);
        }

        [TestMethod]
        public void BogoTest()
        {
            Assert.AreEqual(Reverses.Bogo(original), reversed);
        }
    }
}
