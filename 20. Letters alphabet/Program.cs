using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Letters_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(i + (int)('A'));
            }

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (char.ToUpper(word[i]) == alphabet[j])
                    {
                        Console.WriteLine("Index of letter \"{0}\" in alphabet is [{1}]", word[i], j);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
