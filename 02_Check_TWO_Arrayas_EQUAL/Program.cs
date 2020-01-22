using System;
using System.Linq;

namespace _02_Check_TWO_Arrayas_EQUAL
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter the LENGTH of the ARRAYS: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, fill in the first ARRAY:");
            int[] arrayOne = new int[arrayLenght];
            for (int index = 0; index < arrayLenght; index++)
            {
                arrayOne[index] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("And now, fill in the second ARRAY:");
            int[] arrayTwo = new int[arrayLenght];
            for (int index = 0; index < arrayLenght; index++)
            {
                arrayTwo[index] = int.Parse(Console.ReadLine());
            }
            bool equal = true;
            for (int index = 0; index < arrayOne.Length; index++)
            {
                if (arrayOne[index] != arrayTwo[index])
                {
                    equal = false;
                }
            }
            if (equal)
            {
                Console.WriteLine("They're equal!");
            }
            else
            {
                Console.WriteLine("Sorry, they're NOT equal!");
            }
        }
    }
}
