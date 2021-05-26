using System;
using System.Collections.Generic;
using System.Text;
using TinkoffTest1.Counters;

namespace TinkoffTest1.CountersInterval
{
    abstract class AbstractCounterInterval
    {
        protected readonly AbstractCounter counter;

        public AbstractCounterInterval(AbstractCounter counter)
        {
            this.counter = counter;
        }
        public abstract int GetSumStepsInterval(int intervalNumberStart, int intervalNumberEnd);
    }
}
