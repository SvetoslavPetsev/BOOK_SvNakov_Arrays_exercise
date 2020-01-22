using System;
using System.Linq;

namespace _11_Find_SUM_in_ARRAY
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int number = int.Parse(Console.ReadLine());
            bool numInArray = false;
            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int sum = array[i];
                for (int j = i + 1; j < array.Length ; j++)
                {
                    sum += array[j];

                    if (sum == number)
                    {
                        maxIndex = j;
                        numInArray = true;
                    }
                }
            }

            if (numInArray || array.Length == 1 && array[0] == number)
            {
                int counter = 0;
                int n = number;

                while (n > 0)
                {
                    n -= array[maxIndex];
                    maxIndex--;
                    counter++;
                }

                int[] sumArray = new int[counter];

                for (int i = 0; i < sumArray.Length; i++)
                {
                    sumArray[i] = array[maxIndex + 1];
                    maxIndex++;
                }

                Console.WriteLine($"The sequance for the SUM = {number} in filled ARRAY is: ");
                Console.Write(string.Join(" ", sumArray));
            }

            else
            {
                Console.WriteLine($"Doesn't have SUM in the ARRAY, equal to {number}");
            }
        }
    }
}
