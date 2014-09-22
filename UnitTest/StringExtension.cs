using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions;

namespace UnitTest
{
    [TestClass]
    public class StringExtension
    {
        [TestMethod]
        public void String_Right()
        {
            var input = "Hello World";
            var expected = "World";

            Assert.AreEqual(expected, input.Right(expected.Length));
        }

        [TestMethod]
        public void String_Is_Not_Null()
        {
            var input = "This string is not null";

            Assert.AreEqual(false, input.IsNull());
        }

        [TestMethod]
        public void String_Is_Null()
        {
            string input = null;

            Assert.AreEqual(true, input.IsNull());
        }
    }
}
