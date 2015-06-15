using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions;


namespace UnitTest
{
    [TestClass]
    public class Int32Extension
    {
        [TestMethod]
        public void Date28thAugust1971()
        {
            var day = 28;

            var testdate = new DateTime(1971, 8, 28);

            var date = day.August(1971);

            Assert.AreEqual(testdate, date);
        }
    }
}
