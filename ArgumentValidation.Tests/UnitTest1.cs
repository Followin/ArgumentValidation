using System;
using ArgumentValidation.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArgumentValidation.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Int32[] someInts = new int[0];
            someInts.Argument("someInts")
                    .NotEmpty();
            Int32 i = 5;

        }

        [TestMethod]
        public void Enumerable_Test_Method()
        {
            Int32[] someInts = new int[0];

            try
            {
                someInts.Argument("someInts")
                        .NotNull()
                        .NotEmpty();
            }
            catch(ArgumentException ex)
            {
                Assert.AreEqual("someInts", ex.ParamName);
            }

        }
    }
}
