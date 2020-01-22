using System;
using System.Linq;

namespace _03_Max_EQUAL_SEQUENCE
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please fill in random array with string separate ", "!");
            int[] inputArray = Console
                .ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            
            int counterEqual = 1;
            int numberEqual = inputArray[0];
            int maxsequance = 1;
            for (int index = 0; index < inputArray.Length - 1; index++)
            {
                if (inputArray[index] == inputArray[index + 1])
                {
                    counterEqual++;
                    if (counterEqual > maxsequance )
                    {
                        maxsequance = counterEqual;
                        numberEqual = inputArray[index];
                    }
                }
                else
                {
                    counterEqual = 1;
                }
            }
            int[] bestSeq = new int[maxsequance];
            for (int i = 0; i < bestSeq.Length; i++)
            {
                bestSeq[i] = numberEqual;
            }
            Console.Write("The longest squance with equal number in your array is: ");
            Console.WriteLine(string.Join(", ", bestSeq));
        }
    }
}
