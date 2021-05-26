using System;
using TinkoffTest1.Builders;
using TinkoffTest1.Counters;
using TinkoffTest1.CountersInterval;

namespace TinkoffTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeCollatz facadeCollatz = new FacadeCollatz();
            facadeCollatz.GetSumStepsInterval(2, 5);

            //CollatzCounter collatzCounter = new CollatzCounter();
            //int result = collatzCounter.GetStepCount(5);
            //Console.WriteLine(result);
        }
    }
}
