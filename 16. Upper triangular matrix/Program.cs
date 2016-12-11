using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Upper_triangular_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            int[,] matrix = new int[length, length];
            int count = 0;

            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    Console.Write("Enter element [{0},{1}]: ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row >= 1) && (col >= 1) && (row == col))
                    {
                        for (int i = 0; i < col; i++)
                        {
                            if (matrix[row, i] == 0)
                            {
                                count++;
                            }
                        }
                        break;
                    }
                }
            }

            if (count == (((length * length) - length) / 2))
            {
                Console.WriteLine("This matrix is Upper triangular matrix!");
            }
            else
            {
                Console.WriteLine("This matrix is not Upper triangular matrix!");
            }
            Console.ReadLine();
        }
    }
}
