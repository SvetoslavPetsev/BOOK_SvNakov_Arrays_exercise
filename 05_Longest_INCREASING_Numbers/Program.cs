using System;
using System.Linq;

namespace _05_Longest_INCREASING_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, read an array, separate with ", "!");
            int[] inputArray = Console
                .ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int lengthBest = 1;
            int counter = 1;
            int[] bestSequence = new int[1];
            bestSequence[0] = inputArray[0];
            int firstNumberInSeq = inputArray[0];

            for (int index = 1; index < inputArray.Length; index++)
            {
                if (inputArray[index] == inputArray[index - 1] + 1)
                {
                    counter++;
                    if (counter > lengthBest)
                    {
                        lengthBest = counter;
                        int[] longestSequence = new int[lengthBest];
                        for (int i = 0; i < lengthBest; i++)
                        {
                            longestSequence[i] = inputArray[index - (lengthBest - 1) + i];
                        }
                        bestSequence = longestSequence;
                    }
                    continue;
                }
                counter = 1;
            }
            Console.WriteLine(string.Join(", ", bestSequence));
        }
    }
}
