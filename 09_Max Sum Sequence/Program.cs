using System;
using System.Linq;

namespace _09_Max_Sum_Sequence
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int maxsum = int.MinValue;
            int lastIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < array.Length; j++)
                {
                    sum += array[j];
                    if (sum > maxsum)
                    {
                        maxsum = sum;
                        lastIndex = j;
                    }
                }
            }
            //here I find the number of elements for best SUM:
            int counter = 0;
            while (maxsum > 0)
            {
                maxsum -= array[lastIndex];
                lastIndex--;
                counter++;
            }
            //here I put this elements in the array
            int[] bestArray = new int[counter];
            for (int i = 0; i < bestArray.Length; i++)
            {
                lastIndex++;
                bestArray[i] = array[lastIndex];
            }
            //printing Array:)
            Console.WriteLine(string.Join(" ", bestArray));
        }
    }
}
