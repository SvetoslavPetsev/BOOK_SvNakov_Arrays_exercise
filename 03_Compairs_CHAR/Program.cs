using System;

namespace _03_Compairs_CHAR
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the lenght of the ARRAYS: ");
            int length = int.Parse(Console.ReadLine());
            char[] arrayFirst = new char[length];
            Console.WriteLine("Now, fill in the first:");
            for (int index = 0; index < length; index++)
            {
                arrayFirst[index] = char.Parse(Console.ReadLine());
            }
            char[] arraySecond = new char[length];
            Console.WriteLine("And the second:");
            for (int index = 0; index < length; index++)
            {
                arraySecond[index] = char.Parse(Console.ReadLine());
            }
            bool winnerFirst = false;
            bool winnerSecond = false;
            for (int index = 0; index < length; index++)
            {
                if (arrayFirst[index] < arraySecond[index])
                {
                    winnerFirst = true;
                    break;
                }
                else if (arraySecond[index] < arrayFirst[index])
                {
                    winnerSecond = true;
                    break;
                }
            }
            if (winnerFirst)
            {
                Console.WriteLine("And the Winer is FIRST array");
                return;
            }
            else if (winnerSecond)
            {
                Console.WriteLine("And the Winer is SECOND array");
                return;
            }
            Console.WriteLine("WoW! They are the same!");
        }
    }
}
