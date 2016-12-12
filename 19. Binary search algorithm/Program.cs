using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Binary_search_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter target value: ");
            int target = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int temp = 0;
            int min = 0;
            int max = array.Length - 1;
            int middle = (min + max) / 2;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element [{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
            for (int i = min; i <= max; i++)
            {
                if (array[middle] < target)
                {
                    i = middle + 1;
                    middle = (i + max) / 2;
                }
                if (array[middle] > target)
                {
                    max = middle - 1;
                    middle = (i + max) / 2;
                }
                if (array[middle] == target)
                {
                    Console.WriteLine("Target {0} was found at index [{1}]!", target, middle);
                    break;
                }
                if (i >= max)
                {
                    Console.WriteLine("The search is unsuccessful!");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
