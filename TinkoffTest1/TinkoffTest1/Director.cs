using System;
using System.Collections.Generic;
using System.Text;
using TinkoffTest1.Builders;

namespace TinkoffTest1
{
    class Director
    {
        private readonly AbstractBuilder builder;

        public Director(AbstractBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.CounterBuild();
            builder.CounterIntervalBuild();
        }
    }
}
