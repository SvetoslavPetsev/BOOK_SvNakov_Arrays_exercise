using System;
using System.Linq;

namespace _08._2_Selection_sprt_ALGORITHM
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Selection sort");
            Console.Write("Initial array is: ");
            int[] arr = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int temp, smallest;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }

                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine();
            Console.Write("Sorted array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
