using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Merge_elements_of_two_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length for first arrray: ");
            int lengthA = int.Parse(Console.ReadLine());
            int[] arrayA = new int[lengthA];
            int temp = 1;
            int index = 0;
            for (int i = 0; i < lengthA; i++)
            {
                Console.Write("Enter element [{0}] for first array: ", i + 1);
                arrayA[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter length for second arrray: ");
            int lengthB = int.Parse(Console.ReadLine());
            int[] arrayB = new int[lengthB];
            for (int i = 0; i < lengthB; i++)
            {
                Console.Write("Enter element [{0}] for first array: ", i + 1);
                arrayB[i] = int.Parse(Console.ReadLine());
            }

            int[] arrayAB = new int[lengthA + lengthB];
            for (int i = 0; i < (arrayAB.Length - arrayB.Length); i++)
            {

                arrayAB[i] = arrayA[i];
            }
            for (int i = (arrayAB.Length - arrayB.Length); i < arrayAB.Length; i++)
            {

                arrayAB[i] = arrayB[index];
                index++;
            }
            Console.Write("\nEnter \"1\" for merge in ascending order or \"2\" for merge in descending order: ");
            int choice = int.Parse(Console.ReadLine());
            for (int i = 0; i < arrayAB.Length; i++)
            {
                for (int j = i + 1; j < arrayAB.Length; j++)
                {
                    if(arrayAB[j] < arrayAB[i])
                    {
                        temp = arrayAB[j];
                        arrayAB[j] = arrayAB[i];
                        arrayAB[i] = temp;
                    }
                }
            }

            if (choice == 1)
            {
                Console.Write("\nMerged array in ascending order = ");
                for (int i = 0; i < arrayAB.Length; i++)
                {
                    Console.Write("{0} ", arrayAB[i]);
                }
            }
            else
            {
                Console.Write("\nMerged array in descending order = ");
                for (int i = arrayAB.Length - 1; i >= 0; i--)
                {
                    Console.Write("{0} ", arrayAB[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
