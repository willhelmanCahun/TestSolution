using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using test.application.Services;

namespace test.UnitTests
{
    [TestClass]
    public class StringAnalyzerTests
    {
        [TestMethod]
        public void reOrderString_test()
        {
            //arrange
            string[] individuals = { "Sonia", "Maria", "Wood", "Dempster" };
            string[] order = { "4", "1", "2", "3" };
            string[] expected = { "Dempster", "Sonia", "Maria", "Wood" };

            StringAnalyzer sa = new StringAnalyzer();
            //act
            string[] actual = sa.ReArrangeString(individuals, order);

            //assert
            CollectionAssert.AreEqual(expected, actual);
            

        }

        [TestMethod]
        public void reOrderString_shouldThrowException() {
            //arrange
            string[] individuals = { "Sonia", "Maria", "Wood", "Dempster" };
            string[] order = { "4", "1", "2" };
            StringAnalyzer sa = new StringAnalyzer();

            Assert.ThrowsException<System.Exception>(() => sa.ReArrangeString(individuals, order), "order array must contain same number of elements as individuals array");

        }
    }
}
