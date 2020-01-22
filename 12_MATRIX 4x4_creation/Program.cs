using System;

namespace _12_MATRIX_4x4_creation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("a");
            int[,] matrixA = new int[4, 4];
            int a = 1;
            for (int row = 0; row < matrixA.GetLength(0); row++)
            {
                for (int col = 0; col < matrixA.GetLength(1); col++)
                {
                    matrixA[row, col] += a;
                    a += 7;
                    Console.Write(" " + matrixA[row, col]);
                }
                a -= 15;
                Console.WriteLine();
            }
            Console.WriteLine("b");

            int[,] matrixB = new int[4, 4];
            int b = 1;
            int c = 8;
            int d = 9;
            int e = 16;
            for (int row = 0; row < matrixB.GetLength(0); row++)
            {
                for (int col = 0; col < matrixB.GetLength(1); col++)
                {
                    if (col == 0)
                    {
                        matrixB[row, col] = b;
                        b++;
                    }
                    else if (col == 1)
                    {
                        matrixB[row, col] = c;
                        c--;
                    }
                    else if (col == 2)
                    {
                        matrixB[row, col] = d;
                        d++;
                    }
                    else
                    {
                        matrixB[row, col] = e;
                        e--;
                    }
                    Console.Write(" " + matrixB[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("c");
            int[,] matrixC = new int[4, 4];

            for (int row = 0; row < matrixC.GetLength(0); row++)
            {
                int C = 4;
                int N = 3;
                for (int col = 0; col < matrixC.GetLength(1); col++)
                {
                    int cell = 0;
                    if (row == 0)
                    {
                        cell = N + 4;
                        N = C + cell - 4;
                        C--;
                    }
                    else if (row == 1)
                    {
                        if (col > 1)
                        {
                            cell = N + 9;
                            N += N;
                        }
                        else
                        {
                            cell = C;
                            C += C;
                        }
                    }
                    else if (row == 2)
                    {
                        if (col < 2)
                        {
                            cell = N - 1;
                            N += N;
                        }
                        else
                        {
                            cell = C + 5;
                            C += C;
                        }
                    }
                    else
                    {
                        cell = N - 2;
                        N += C - 2;
                        C++;
                    }
                    matrixC[row, col] = cell;
                    Console.Write(" " + matrixC[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
