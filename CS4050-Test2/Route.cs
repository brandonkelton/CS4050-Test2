using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS4050_Test2
{
    public class Route
    {
        public List<CityDistance> Cities { get; private set; }

        public void AddCityDistance(CityDistance cityDistance)
        {
            Cities.Add(cityDistance);
        }

        public int GetTotalDistance()
        {
            return Cities.Sum(c => c.Distance);
        }
    }
}
