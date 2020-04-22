using System;
using System.Collections.Generic;
using System.Text;

namespace CS4050_Test2
{
    public class ShortestRoute
    {
        private CityDistance[] MemoizedCityDistances;
        private List<Route> ShortestRoutes = new List<Route>();

        public ShortestRoute(CityDistance[] cityDistances)
        {
            MemoizedCityDistances = cityDistances;
        }

        //public Route[] Solve()
        //{
        //    // Use memoized city distances to 
        //}
    }
}
