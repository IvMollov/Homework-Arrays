using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Most_frequent_number
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
            int winner = 0;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element [{0}]: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] == array[j])
                    {
                        tempCount++;
                    }
                    if (tempCount > maxCount)
                    {
                        maxCount = tempCount;
                        winner = array[i];
                    }
                }
                tempCount = 1;
            }

            Console.WriteLine("Most frequent number si: {0}. We have met it {1} times.Line", winner, maxCount);

            Console.ReadLine();
        }
    }
}
