using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Selection_sort_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selection sort algorithm");
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int temp = 0;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element [{0}]: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < array[min])
                    {
                        min = j;
                    }
                }
                if (array[min] != i)
                {
                    temp = array[min];
                    array[min] = array[i];
                    array[i] = temp;
                }
            }

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadLine();

        }
    }
}
