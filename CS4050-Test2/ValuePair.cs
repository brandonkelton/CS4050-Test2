using System;
using System.Collections.Generic;
using System.Text;

namespace CS4050_Test2
{
    public class ValuePair
    {
        public int Value1 { get; private set; }

        public int Value2 { get; private set; }

        public bool HasDistance => Value2 > -1;

        public int Distance => Value2 - Value1;

        public ValuePair(int value1, int value2 = -1)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
}
