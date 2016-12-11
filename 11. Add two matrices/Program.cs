using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Add_two_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            int[,] matrixOne = new int[length, length];
            int[,] matrixTwo = new int[length, length];
            int[,] matrixThree = new int[length, length];
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    Console.Write("First matrix. Enter element [{0},{1}]: ", row, col);
                    matrixOne[row, col] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    Console.Write("Second matrix. Enter element [{0},{1}]: ", row, col);
                    matrixTwo[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        matrixThree[row, col] = (matrixOne[row, col] * matrixTwo[row, col]) + (matrixOne[row, col + 1] * matrixTwo[row + 1, col]) + (matrixOne[row, col + 2] * matrixTwo[row + 2, col]);
                    }
                    if (row == 1 && col == 0)
                    {
                        matrixThree[row, col] = (matrixOne[row, col] * matrixTwo[col, col]) + (matrixOne[row, col + 1] * matrixTwo[row, col + 1]) + (matrixOne[row, row + 1] * matrixTwo[row + 1, col]);
                    }
                    if (row == 2 && col == 0)
                    {
                        matrixThree[row, col] = (matrixOne[row, col] * matrixTwo[col, col]) + (matrixOne[row, col + 1] * matrixTwo[col + 1, col]) + (matrixOne[row, row + 1] * matrixTwo[row, col]);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Dispaly matrix one:");
            for (int row = 0; row < matrixOne.GetLength(0); row++)
            {
                for (int col = 0; col < matrixOne.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrixOne[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Dispaly matrix two:");
            for (int row = 0; row < matrixTwo.GetLength(0); row++)
            {
                for (int col = 0; col < matrixTwo.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrixTwo[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Dispaly sum of both matrices:");
            for (int row = 0; row < matrixThree.GetLength(0); row++)
            {
                for (int col = 0; col < matrixThree.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrixThree[row, col]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
