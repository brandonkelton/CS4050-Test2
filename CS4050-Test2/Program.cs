using System;

namespace CS4050_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            var knapsack = new ZeroOneKnapsack();
            var result = knapsack.GetSolution();

            Console.WriteLine($"The most valuable shipment is worth:  ${result}");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit... ");

            ///////////////////////

            //var closestValues = new ClosestValues();

            //Console.WriteLine(String.Join("\r\n", closestValues.Values));

            //var result = closestValues.Solve();
            //Console.WriteLine();
            //Console.WriteLine($"Result: ({result.Value1}, {result.Value2})");

            Console.ReadKey();
        }
    }
}
