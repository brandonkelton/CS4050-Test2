using System;
using System.Collections.Generic;
using System.Text;

namespace CS4050_Test2
{
    public class CityDistance
    {
        public string City1 { get; private set; }
        public string City2 { get; private set; }
        public int Distance { get; private set; }

        public CityDistance(string city1, string city2, int distance)
        {
            City1 = city1;
            City2 = city2;
            Distance = distance;
        }
    }
}
