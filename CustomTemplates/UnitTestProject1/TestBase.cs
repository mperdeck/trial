using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public void Init()
        {
            /* ... */
        }

        [TearDown]
        public void Cleanup()
        {
            /* ... */
        }
    }
}
