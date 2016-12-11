using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.All_variations
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
            if (index >= array.Length)
            {
                Console.Write("(");
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < array.Length - 1)
                    {
                        Console.Write("{0} ", array[i]);
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
                for (int i = 1; i <= end; i++)
                {
                    array[index] = i;
                    Variation(array, index + 1, i, end);
                }
            }
        }
    }
}
