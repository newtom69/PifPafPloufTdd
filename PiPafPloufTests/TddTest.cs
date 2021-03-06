using Microsoft.VisualStudio.TestTools.UnitTesting;
using PifPafPloufProject;

namespace PifafTest
{
    [TestClass]
    public class TddTest
    {
        readonly PifPafPlouf PifPafPlouf = new PifPafPlouf();
        [TestMethod]
        public void ShouldbenumberIfNumberIsnot3or4orMultiples()
        {
            Assert.AreEqual("1", PifPafPlouf.SuitElementFromNumber(1));
            Assert.AreEqual("2", PifPafPlouf.SuitElementFromNumber(2));
            Assert.AreEqual("5", PifPafPlouf.SuitElementFromNumber(5));
            Assert.AreEqual("7", PifPafPlouf.SuitElementFromNumber(7));
        }

        [TestMethod]
        public void ShouldbePifIfNumberIs3orMultipleAnNot12Multipple()
        {
            Assert.AreEqual("Pif", PifPafPlouf.SuitElementFromNumber(3 * 1));
            Assert.AreEqual("Pif", PifPafPlouf.SuitElementFromNumber(3 * 2));
            Assert.AreEqual("Pif", PifPafPlouf.SuitElementFromNumber(3 * 3));
            Assert.AreEqual("Pif", PifPafPlouf.SuitElementFromNumber(3 * 5));
            Assert.AreEqual("Pif", PifPafPlouf.SuitElementFromNumber(3 * 6));

        }

        [TestMethod]
        public void ShouldbePafIfNumberIs4orMultipleAndnot12Multiple()
        {
            Assert.AreEqual("Paf", PifPafPlouf.SuitElementFromNumber(4 * 1));
            Assert.AreEqual("Paf", PifPafPlouf.SuitElementFromNumber(4 * 2));
            Assert.AreEqual("Paf", PifPafPlouf.SuitElementFromNumber(4 * 4));
            Assert.AreEqual("Paf", PifPafPlouf.SuitElementFromNumber(4 * 5));
        }

        [TestMethod]
        public void ShouldbePloufIfNumberIs12orMultiple()
        {
            Assert.AreEqual("Plouf", PifPafPlouf.SuitElementFromNumber(12 * 1));
            Assert.AreEqual("Plouf", PifPafPlouf.SuitElementFromNumber(12 * 2));
            Assert.AreEqual("Plouf", PifPafPlouf.SuitElementFromNumber(12 * 3));
            Assert.AreEqual("Plouf", PifPafPlouf.SuitElementFromNumber(12 * 4));
            Assert.AreEqual("Plouf", PifPafPlouf.SuitElementFromNumber(12 * 5));
        }

        [TestMethod]
        public void SuitShouldbeOnly1StringIfOnly1Number()
        {
            Assert.AreEqual("1", PifPafPlouf.SuitBetween2Number(1, 1));
            Assert.AreEqual("2", PifPafPlouf.SuitBetween2Number(2, 2));
            Assert.AreEqual("Pif", PifPafPlouf.SuitBetween2Number(3, 3));
            Assert.AreEqual("Paf", PifPafPlouf.SuitBetween2Number(4, 4));
            Assert.AreEqual("Plouf", PifPafPlouf.SuitBetween2Number(12, 12));
        }

        [TestMethod]
        public void SuitShouldbe2StringsIfDiffNumberIs1()
        {
            Assert.AreEqual("12", PifPafPlouf.SuitBetween2Number(1, 2));
            Assert.AreEqual("2Pif", PifPafPlouf.SuitBetween2Number(2, 3));
            Assert.AreEqual("PifPaf", PifPafPlouf.SuitBetween2Number(3, 4));
            Assert.AreEqual("Paf5", PifPafPlouf.SuitBetween2Number(4, 5));
            Assert.AreEqual("11Plouf", PifPafPlouf.SuitBetween2Number(11, 12));
            Assert.AreEqual("1314", PifPafPlouf.SuitBetween2Number(13, 14));
        }

        [TestMethod]
        public void SuitShouldbeMoreStringsIfDiffNumberIsSup1()
        {
            Assert.AreEqual("12Pif", PifPafPlouf.SuitBetween2Number(1, 3));
            Assert.AreEqual("12PifPaf", PifPafPlouf.SuitBetween2Number(1, 4));
            Assert.AreEqual("12PifPaf5", PifPafPlouf.SuitBetween2Number(1, 5));
            Assert.AreEqual("12PifPaf5Pif", PifPafPlouf.SuitBetween2Number(1, 6));

        }
    }
}
