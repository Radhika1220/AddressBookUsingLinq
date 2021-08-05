
using AddrBookUsingLinq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestValidation
{
    [TestClass]
    public class UnitTest1
    {
        ContactDataManager contactData;

        [TestInitialize]
        public void SetUp()
        {
            contactData = new ContactDataManager();
        }
        /// <summary>
        /// Returns the count of inserted data
        /// </summary>
        [TestMethod]
        [TestCategory("Insert Values in Data Table")]
        public void GivenInsertValues_returnInteger()
        {
            int expected = 2;
            int actual = contactData.AddValues();
            Assert.AreEqual(actual, expected);
        }
    }
}