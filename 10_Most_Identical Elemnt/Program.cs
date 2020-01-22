using System;
using System.Linq;

namespace _10_Most_Identical_Elemnt
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int maxCount = 0;
            int bestElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                int counterIdentical = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (element == array[j])
                    {
                        counterIdentical++;
                    }
                    if (counterIdentical > maxCount)
                    {
                        maxCount = counterIdentical;
                        bestElement = element;
                    }
                }
            }
            Console.WriteLine($"The max identical element is {bestElement} with count of {maxCount}!");
        }
    }
}
