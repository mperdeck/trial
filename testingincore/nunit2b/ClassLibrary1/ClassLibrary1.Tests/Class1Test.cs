using System;
using NUnit.Framework;
using ClassLibrary1;
using ClassLibrary2.TestLib;

namespace ClassLibrary1.Tests
{
    [TestFixture]
    public class Class1Test
    {

        [Test]
        public void Test1()
        {
            int i = Class1.F1();

            Class1t.t1(i,9);
        }

        [Test]
        public void Test2()
        {
            int i = Class1.F1();

            Assert.AreEqual(i, 6);
        }

        [Test]
        public void Test3()
        {
            int i = Class1.F1();

            Assert.AreEqual(i, 6);
        }

        [Test]
        public void Test4()
        {
            int i = Class1.F1();

            Assert.AreEqual(i, 6);
        }
    }
}
