using System;
using System.Collections.Generic;
using System.Text;

namespace CS4050_Test2
{
    public class CargoItem
    {
        public int Size { get; private set; }

        public int Value { get; private set; }

        public CargoItem(int size, int value)
        {
            Size = size;
            Value = value;
        }
    }
}
