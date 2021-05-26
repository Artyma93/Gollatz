using System;
using System.Collections.Generic;
using System.Text;
using TinkoffTest1.Counters;
using TinkoffTest1.CountersInterval;

namespace TinkoffTest1.Builders
{
    class CollatzBuilder : AbstractBuilder
    {
        private AbstractCounter abstractCounter;
        private AbstractCounterInterval counterInterval;
        
        public override void CounterBuild()
        {
            abstractCounter = new CollatzCounter();
        }

        public override void CounterIntervalBuild()
        {
            if(abstractCounter == null)
            {
                CounterBuild();
            }
          
                counterInterval = new CollatzCounterInterval(abstractCounter);
        }

        public override AbstractCounter GetCounter()
        {
            return abstractCounter;
        }

        public override AbstractCounterInterval GetCounterInterval()
        {
            return counterInterval;
        }
    }
}
