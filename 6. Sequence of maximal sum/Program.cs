using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Sequence_of_maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int tempSum = 0;
            int maxSum = int.MinValue;
            int start = 0;
            int end = 0;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element [{0}]: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i; j < array.Length; j++)
                {
                    tempSum += array[j];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        start = i;
                        end = j;
                    }
                }
                tempSum = 0;
            }

            Console.Write("\nMaximal sum si {0}: ", maxSum);

            for(int i = start; i <= end; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.ReadLine();
        }
    }
}
