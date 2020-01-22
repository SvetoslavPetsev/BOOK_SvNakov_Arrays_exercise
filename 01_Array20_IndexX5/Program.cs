using System;
using System.Linq;

namespace _08_Selection_sort
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] sortedArray = new int[inputArray.Length];

            //int counter = 0;

            for (int q = 0; q < sortedArray.Length; q++)
            {
                int minNumber = int.MaxValue;
                int pointIndex = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] < minNumber)
                    {
                        pointIndex = i;
                        minNumber = inputArray[i];
                        sortedArray[q] = minNumber;
                    }
                }

                int[] helpArray = new int[inputArray.Length - 1];
                int counter = -1;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (i != pointIndex)
                    {
                        counter++;
                        helpArray[counter] = inputArray[i];
                    }
                }

                inputArray = helpArray;
            }

            Console.WriteLine(string.Join(" ", sortedArray));
        }
    }
}
