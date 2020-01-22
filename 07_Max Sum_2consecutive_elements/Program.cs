using System;

namespace _07_Max_Sum_2consecutive_elements
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter the number N: ");
            int N = int.Parse(Console.ReadLine());
           
            Console.WriteLine();
            
            Console.Write("Please, enter the number K! Number K should be smaller than N: ");
            int K = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Now, fill in the array with {N} elements!");
            int[] inputArray = new int[N];

            int maxSum = int.MinValue;
            int startIndex = K - 1;
            for (int i = 0; i < N; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < inputArray.Length - K + 1; i++)
            {
                int sum = 0;
                int index = 0;
                for (int j = i; j < i + K; j++)
                {
                    sum += inputArray[j];
                    index = j;
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    startIndex = index - K + 1;
                }
            }

            int[] maxSumArray = new int[K];
            for (int t = 0; t < K; t++)
            {
                maxSumArray[t] = inputArray[startIndex + t];
            }
            Console.WriteLine("The best array is:");
            Console.WriteLine(string.Join(" ", maxSumArray));
            Console.WriteLine("The max sum is:");
            Console.WriteLine(maxSum);
        }
    }
}
