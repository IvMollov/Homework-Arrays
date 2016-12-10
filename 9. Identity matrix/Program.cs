using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Identity_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            int[,] matrix = new int[length, length];
            int countZero = 0;
            int countOne = 0;
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
                    if (row == col)
                    {
                        if (matrix[row, col] == 1)
                        {
                            countOne++;
                        }
                        else
                        {
                            countOne = 0;
                        }
                    }
                    else
                    {
                        if(matrix[row, col] == 0)
                        {
                            countZero++;
                        }
                        else
                        {
                            countZero = 0;
                        }
                    }
                }
            }

            if ((countZero != 0) && (countOne != 0))
            {
                Console.WriteLine("This matrix is Identity matrix!");
            }
            else
            {
                Console.WriteLine("This matrix is not Identity matrix!");
            }
            Console.ReadLine();
        }
    }
}
