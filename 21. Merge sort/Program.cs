using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element [{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            MergeSort(array);
            PrintArray(array);
            Console.ReadLine();
        }

        public static void MergeSort(int[] array)
        {
            if(array.Length < 2)
            {
                Console.WriteLine("Array already sorted.");
                return;
            }
            int step = 1;
            int startL, startR;

            while(step < array.Length)
            {
                startL = 0;
                startR = step;
                while(startR + step <= array.Length)
                {
                    MergeArrays(array, startL, startL + step, startR, startR + step);
                    startL = startR + step;
                    startR = startL + step;
                }
                if(startR < array.Length)
                {
                    MergeArrays(array, startL, startL + step, startR, array.Length);
                }
                step *= 2;
            }      
        }
        public static void MergeArrays(int[] array, int startL, int stopL, int startR, int stopR)
        {
            int[] right = new int[stopR - startR + 1];
            int[] left = new int[stopL - startL + 1];

            for (int i = 0, k = startR; i < (right.Length - 1); ++i, ++k)
            {
                right[i] = array[k];
            }
            for (int i = 0, k = startL; i < (left.Length - 1); ++i, ++k)
            {
                left[i] = array[k];
            }

            right[right.Length - 1] = int.MaxValue;
            left[left.Length - 1] = int.MaxValue;

            for (int k = startL, m = 0, n = 0; k < stopR; ++k)
            {
                if (left[m] <= right[n])
                {
                    array[k] = left[m];
                    m++;
                }
                else
                {
                    array[k] = right[n];
                    n++;
                }
            }
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
