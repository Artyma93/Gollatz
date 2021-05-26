using System;
using System.Collections.Generic;
using System.Text;
using TinkoffTest1.Counters;
using TinkoffTest1.CountersInterval;

namespace TinkoffTest1.Builders
{
    abstract class AbstractBuilder
    {
        public abstract void CounterBuild();
        public abstract void CounterIntervalBuild();
        public abstract AbstractCounter GetCounter();
        public abstract AbstractCounterInterval GetCounterInterval();
    }
}
