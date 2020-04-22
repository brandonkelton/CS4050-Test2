using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS4050_Test2
{
    public class ZeroOneKnapsack
    {
        private const int MaxCapacity = 17;
        private readonly CargoItem[] AvailableItems;
        private readonly int[,] MemoizedSolutions;

        public ZeroOneKnapsack(CargoItem[] availableItems = null)
        {
            AvailableItems = availableItems != null ? availableItems : GetDefaultItems();
            MemoizedSolutions = new int[AvailableItems.Length, MaxCapacity + 1];

            for (int i=0; i < AvailableItems.Length * (MaxCapacity + 1); i++) 
                MemoizedSolutions[i % AvailableItems.Length, i / AvailableItems.Length] = -1;
        }

        public int GetSolution()
        {
            return GetSolution(AvailableItems.Length - 1, MaxCapacity);
        }

        private int GetSolution(int index, int currentCapacity)
        {
            int result;

            if (MemoizedSolutions[index, currentCapacity] != -1)
            {
                return MemoizedSolutions[index, currentCapacity];
            }

            if (index == 0 || currentCapacity == 0)
            {
                result = 0;
            }
            else if (AvailableItems[index].Size > currentCapacity)
            {
                result = GetSolution(index - 1, currentCapacity);
            }
            else
            {
                var solution1 = GetSolution(index - 1, currentCapacity);
                var solution2 = AvailableItems[index].Value + GetSolution(index - 1, currentCapacity - AvailableItems[index].Size);
                result = solution1 >= solution2 ? solution1 : solution2;
            }

            MemoizedSolutions[index, currentCapacity] = result;
            return result;
        }

        private CargoItem[] GetDefaultItems()
        {
            var items = new List<CargoItem>();

            var A = Enumerable.Repeat(new CargoItem(2, 3), 7);
            var B = Enumerable.Repeat(new CargoItem(3, 4), 4);
            var C = Enumerable.Repeat(new CargoItem(5, 8), 5);
            var D = Enumerable.Repeat(new CargoItem(7, 9), 3);
            var E = Enumerable.Repeat(new CargoItem(8, 11), 4);

            items.AddRange(A.Concat(B).Concat(C).Concat(D).Concat(E));

            return items.ToArray();
        }
    }
}
