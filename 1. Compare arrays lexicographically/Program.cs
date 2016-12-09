using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Compare_arrays_lexicographically
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            char[] first = new char[length];
            char[] second = new char[length];
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter letter {0} of first array: ", i + 1);
                first[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter letter {0} of second array: ", i + 1);
                second[i] = char.Parse(Console.ReadLine());
            }


            for (int i = 0; i < length; i++)
            {
                if (Char.ToLower(first[i]) == Char.ToLower(second[i]))
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("Two char arrays are not lexicographically comparable!");
                    break;
                }
            }

            if (count != 0)
            {
                Console.WriteLine("Two char arrays are lexicographically comparable!");
            }

            Console.ReadLine();
        }
    }
}
