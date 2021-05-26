using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TinkoffTest1.Builders;
using TinkoffTest1.CountersInterval;

namespace TinkoffTest1
{
    [TestFixture]
    class CollatzTest
    {
        private static AbstractBuilder builder = new CollatzBuilder();
        private static Director director = new Director(builder);
        private static AbstractCounterInterval counterInterval = builder.GetCounterInterval();

        [Test]
        public static void TestOperations()
        {
            Assert.AreEqual(15, counterInterval.GetSumStepsInterval(2, 5));
        }
    }
}

