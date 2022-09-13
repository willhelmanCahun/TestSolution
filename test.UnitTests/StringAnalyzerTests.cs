using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using test.application.Services;

namespace test.UnitTests
{
    [TestClass]
    public class StringAnalyzerTests
    {
        /// <summary>
        /// Method to test the successful rearrange of elements
        /// </summary>
        /// <param name="individuals">array of names to be rearrange</param>
        /// <param name="order">array with indexes to be use to rearrange elements</param>
        /// <param name="expected">array with expected output</param>
        [TestMethod]
        [DataRow(new string[] { "Sonia", "Maria", "Wood", "Dempster" }, new string[] { "4", "1", "2", "3" }, new string[] { "Dempster", "Sonia", "Maria", "Wood" })]
        [DataRow(new string[] { "Lauren", "Ana", "Eagles", "Beneke" }, new string[] { "4", "3", "2", "1" }, new string[] { "Beneke", "Eagles", "Ana", "Lauren" })]
        [DataRow(new string[] { "Chris", "Rebeka", "Justin", "Jose", "Christine" }, new string[] { "1", "3", "4", "2" , "5"}, new string[] { "Chris", "Justin", "Jose", "Rebeka", "Christine" })]
        [DataRow(new string[] { "Chris", "Rebeka", "Justin" }, new string[] { "2", "1", "3"}, new string[] { "Rebeka", "Chris", "Justin" })]
        public void reOrderString_test(string[] individuals, string[] order, string[] expected)
        {
            ////arrange

            StringAnalyzer sa = new StringAnalyzer();
            //act
            string[] actual = sa.ReArrangeString(individuals, order);

            //assert
            CollectionAssert.AreEqual(expected, actual);
            

        }
        /// <summary>
        /// Method to validate data integrity
        /// </summary>
        /// <param name="individuals">array of names to be rearrange</param>
        /// <param name="order">array with indexes to be use to rearrange elements</param>
        /// <param name="expected">array with expected output</param>
        /// <param name="message">"message to be display when it's not thrown an exception</param>
        [TestMethod]
        [DataRow(new string[] {}, new string[] { "4", "1", "2", "3" }, new string[] { "Dempster", "Sonia", "Maria", "Wood" },"Individuals names array is empty")]
        [DataRow(new string[] { "Sonia", "Maria", "Wood", "Dempster" }, new string[] {  }, new string[] { "Dempster", "Sonia", "Maria", "Wood" },"Desire order array is empty, please verify")]
        [DataRow(new string[] { "Sonia", "Maria", "Wood", "Dempster" }, new string[] { "4", "1", "2" }, new string[] { "Dempster", "Sonia", "Maria", "Wood" },"order array must contain same number of elements as individuals array")]
        [DataRow(new string[] { "Sonia", "Maria", "Wood", "Dempster" }, new string[] { "4", "1", "2", "one" }, new string[] { "Dempster", "Sonia", "Maria", "Wood" },"Desire order array only allows elements of type Integer")]
        [DataRow(new string[] { "Sonia", "Maria", "Wood", "Dempster" }, new string[] { "4", "1", "2", "5" }, new string[] { "Dempster", "Sonia", "Maria", "Wood" }, "Desire order array element is out of bounds")]
        [DataRow(new string[] { "Sonia", "Maria", "Wood", "Dempster" }, new string[] { "4", "1", "2", "-1" }, new string[] { "Dempster", "Sonia", "Maria", "Wood" },"Desire order array element is out of bounds")]
        [DataRow(new string[] { "Sonia", "Maria", "Wood", "Dempster" }, new string[] { "4", "1", "2", "0" }, new string[] { "Dempster", "Sonia", "Maria", "Wood" },"Desire order array element is out of bounds")]
        public void reOrderString_shouldThrowException(string[] individuals, string[] order, string[] expected, string message)
        {
            //arrange
           
            StringAnalyzer sa = new StringAnalyzer();
            //act
            Assert.ThrowsException<System.Exception>(() => sa.ReArrangeString(individuals, order), message);

        }
    }
}
