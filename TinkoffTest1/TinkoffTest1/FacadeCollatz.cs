using System;
using System.Collections.Generic;
using System.Text;
using TinkoffTest1.Builders;
using TinkoffTest1.CountersInterval;

namespace TinkoffTest1
{
    class FacadeCollatz
    {
        private AbstractBuilder builder;
        private Director director;

        public void GetSumStepsInterval(int intervalNumberStart, int intervalNumberEnd)
        {

            builder = new CollatzBuilder();
            director = new Director(builder);
            
            director.Construct();

            AbstractCounterInterval counterInterval = builder.GetCounterInterval();

            int result = counterInterval.GetSumStepsInterval(intervalNumberStart, intervalNumberEnd);

            Console.WriteLine(result);
        }
    }
}
