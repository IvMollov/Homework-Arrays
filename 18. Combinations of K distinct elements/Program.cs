using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Combinations_of_K_distinct_elements
{
    class Program
    {
            static void Main(string[] args)
        {
                Console.Write("Enter N: ");
                int set = int.Parse(Console.ReadLine());

                Console.Write("Enter K: ");
                int number = int.Parse(Console.ReadLine());
                int[] array = new int[number];
                Variation(array, 0, 1, set);
                Console.ReadLine();

            }
        public static void Variation(int[] array, int index, int start, int end)
        {
            Console.WriteLine("Enter index = {0}, start = {1}", index, start);
            if (index >= array.Length)
            {
                Console.Write("(");
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < array.Length - 1)
                    {
                        Console.Write("{0}, ", array[i]);
                    }
                    else
                    {
                        Console.Write("{0}", array[i]);
                    }
                }
                Console.Write("), ");
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    Console.WriteLine("Enter loop. i = {0}, start = {1}", i, start);
                    Console.WriteLine("array[{0}] = {1}, because index = {2}, i = {3}", index, i, index, i);

                    array[index] = i;
                    Console.WriteLine("Before recursion index = {0}, i = {1}", index, i);
                    Variation(array, index + 1, i + 1, end);
                    Console.WriteLine("After recursion index = {0}, i = {1}", index, i);
                }
            }
        }
    }
}
