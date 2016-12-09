using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Maximal_sequence_of_equal_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int tempCount = 1;
            int maxCount = 1;
            int number = 0;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element [{0}]: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    tempCount++;
                }
                else
                {
                    tempCount = 1;
                }
                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                    number = array[i];
                }
            }

            if (number != 0)
            {
                Console.Write("Maximal sequence of equal elements is: ");
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write("{0}, ", number);
                }
            }
            else
            {
                Console.Write("There is no sequence of equal elements");
            }

            Console.ReadLine();
        }
    }
}
