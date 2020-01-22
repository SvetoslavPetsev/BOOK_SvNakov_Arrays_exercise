using System;

namespace _13_Matrix_N_x_M
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] matrix = new int[n, m];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            if (n >= 3 && m >= 3)
            {
                int maxsum = int.MinValue;
                int firstIndex = matrix[0, 0];
                int[,] bestMatrix = new int[3, 3];
                for (int i = 0; i < matrix.GetLength(0) - 3; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - 3; j++)
                    {
                        int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                                + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                                + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                        if (sum > maxsum)
                        {
                            maxsum = sum;
                            firstIndex = matrix[i, j];
                            for (int k = 0; k < bestMatrix.GetLength(0); k++)
                            {
                                for (int f = 0; f < bestMatrix.GetLength(1); f++)
                                {
                                    bestMatrix[k, f] = matrix[i + k, j + f];
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(maxsum);
                for (int i = 0; i < bestMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < bestMatrix.GetLength(1); j++)
                    {
                        Console.Write(" " + bestMatrix[i,j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
