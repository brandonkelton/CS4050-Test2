using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CS4050_Test2
{
    public class ClosestValues
    {
        private Random Generator = new Random();
        public readonly int[] Values;

        public ClosestValues()
        {
            var values = new List<int>();
            for (int i=0; i<10; i++)
            {
                values.Add(Generator.Next(1, 100));
            }
            Values = values.OrderBy(n => n).ToArray();
        }

        //public ValuePair Solve()
        //{
        //    return Solve(Values);
        //}

        //private ValuePair Solve(int[] range)
        //{
        //    if (range.Length == 1) return new ValuePair(range[0]);
        //    //if (range.Length == 2) return new ValuePair(range[0], range[1]);

        //    var midPoint = range.Length / 2;
            
        //}

        //private ClosestPair Solve(int[] range)
        //{
        //    if (range.Length == 1) return new ClosestPair(range[0]);
        //    if (range.Length == 2) return new ClosestPair(range[0], range[1]);

        //    var midPoint = range.Length / 2;
        //    var pair1 = Solve(range.Take(midPoint).ToArray());
        //    var pair2 = Solve(range.Skip(midPoint).ToArray());

        //    if (pair1.HasDistance && !pair2.HasDistance)
        //    {
        //        var partialPairDistance = pair2.Value1 - pair1.Value2;
        //        return pair1.Distance <= partialPairDistance ? pair1 : new ClosestPair(pair1.Value2, pair2.Value1);
        //    }

        //    if (!pair1.HasDistance && pair2.HasDistance)
        //    {
        //        var partialPairDistance = pair2.Value1 - pair1.Value1;
        //        return pair2.Distance <= partialPairDistance ? pair2 : new ClosestPair(pair1.Value1, pair2.Value1);
        //    }

        //    var interPairDistance = pair2.Value1 - pair1.Value2;
        //    if (interPairDistance <= pair1.Distance && interPairDistance <= pair2.Distance)
        //    {
        //        return new ClosestPair(pair1.Value2, pair2.Value1);
        //    }
        //    return pair1.Distance <= pair2.Distance ? pair1 : pair2;

        //    //var interPairDistance = pair2.Value1 - pair1.Value2;
        //    //if (interPairDistance < pair1.Distance && interPairDistance < pair2.Distance)
        //    //{
        //    //    return new ClosestPair(pair1.Value2, pair2.Value1);
        //    //}
        //    //return pair1.Distance <= pair2.Distance ? pair1 : pair2;

        //    //if (range.Length > 3)
        //    //{
        //    //    var midPoint = range.Length / 2;
        //    //    var pair1 = Solve(range.Take(midPoint).ToArray());
        //    //    var pair2 = Solve(range.Skip(midPoint).ToArray());
        //    //    var interPairDistance = pair2.Value1 - pair1.Value2;
        //    //    if (interPairDistance < pair1.Distance && interPairDistance < pair2.Distance)
        //    //    {
        //    //        return new ClosestPair(pair1.Value2, pair2.Value1);
        //    //    }
        //    //    return pair1.Distance <= pair2.Distance ? pair1 : pair2;
        //    //}

        //    //if (range.Length == 3)
        //    //{
        //    //    var distance1 = range[1] - range[0];
        //    //    var distance2 = range[2] - range[1];
        //    //    if (distance2 <= distance1) return new ClosestPair(range[1], range[2]);
        //    //}

        //    //return new ClosestPair(range[0], range[1]);
        //}
    }
}
