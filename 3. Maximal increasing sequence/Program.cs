using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Maximal_increasing_sequence
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
            int finalEnd = 0;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element [{0}]: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] + 1) == (array[i + 1]))
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
                    finalEnd = i + 1;
                }
            }

            Console.WriteLine();

            if ((maxCount >= tempCount) && (maxCount > 1))
            {

                Console.Write("Maximal sequence of increasing elements is: ");

                for (int i = (finalEnd - maxCount) + 1; i <= finalEnd; i++)
                {
                    Console.Write("{0}, ", array[i]);
                }
            }
            if(maxCount == 1)
            {
                Console.Write("There is no sequence of increasing elements.");
            }
            Console.ReadLine();
        }
    }
}
