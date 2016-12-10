using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Determinant_of_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            int[,] matrix = new int[length, length];
            int determinant = 0;
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

            determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            Console.WriteLine("Determinant of the matrix is {0}", determinant);

            Console.ReadLine();
        }
    }
}
