using System;
using System.Linq;

namespace _07_INCREASING_in_ALL_ARRAY
{
    class Program
    {
        static void Main()
        {
            {
                int[] inputArray = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();
                int maxLength = 0;
                int lastIndex = -1;
                int[] longestIndex = new int[inputArray.Length];
                int[] prevIndex = new int[inputArray.Length];

                for (int i = 0; i < inputArray.Length; i++)
                {
                    longestIndex[i] = 1;
                    prevIndex[i] = -1;

                    for (int k = 0; k < i; k++)
                    {
                        if (inputArray[k] < inputArray[i] && longestIndex[k] + 1 > longestIndex[i])
                        {
                            longestIndex[i] = longestIndex[k] + 1;
                            prevIndex[i] = k;
                        }
                    }

                    if (longestIndex[i] > maxLength)
                    {
                        maxLength = longestIndex[i];
                        lastIndex = i;
                    }
                }

                int[] longestSequence = new int[maxLength];
                int currentIndex = maxLength - 1;

                while (lastIndex != -1)
                {
                    longestSequence[currentIndex] = inputArray[lastIndex];
                    currentIndex--;
                    lastIndex = prevIndex[lastIndex];
                }

                Console.WriteLine(string.Join(" ", longestSequence));
            }
        }
    }
}