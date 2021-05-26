using System;
using System.Collections.Generic;
using System.Text;

namespace TinkoffTest1.Counters
{
    class CollatzCounter : AbstractCounter
    {
        private int counter;
        public override int GetStepCount(int number)
        {
            try
            {

                counter = 0;
                while (number > 1)
                {
                    if (number % 2 == 0)
                    {
                        number = number / 2;
                    }
                    else
                    {
                        number = 3 * number + 1;
                    }
                    counter++;
                }

                return counter;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
