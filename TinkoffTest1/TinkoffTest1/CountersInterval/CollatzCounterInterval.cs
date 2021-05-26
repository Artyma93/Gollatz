using System;
using System.Collections.Generic;
using System.Text;
using TinkoffTest1.Counters;

namespace TinkoffTest1.CountersInterval
{
    class CollatzCounterInterval : AbstractCounterInterval
    {
        private int sumStepsInterval;

        public CollatzCounterInterval(AbstractCounter counter) : base(counter)
        {
        }

        public override int GetSumStepsInterval(int intervalNumberStart, int intervalNumberEnd)
        {
            try
            {
                for (int i = intervalNumberStart; i <= intervalNumberEnd; i++)
                {
                    sumStepsInterval += base.counter.GetStepCount(i);
                }

                return sumStepsInterval;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
