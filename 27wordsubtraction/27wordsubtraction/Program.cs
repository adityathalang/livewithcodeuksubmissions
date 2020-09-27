using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _27wordsubtraction
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first word: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("{" + String.Join(",", Encoding.UTF8.GetBytes(word1.ToCharArray())) + "}\n");

            Console.WriteLine("Enter the second word: ");
            string word2 = Console.ReadLine();
            Console.WriteLine("{" + String.Join(",", Encoding.UTF8.GetBytes(word2.ToCharArray())) + "}\n");

            if (word1.Length == word2.Length)
            {
                Console.Write("{");
                for (int i = 0; i < word1.Length; i++)
                {
                    Console.Write(word1[i] - word2[i]);
                    if (i != word1.Length - 1) Console.Write(",");
                }
                Console.Write("}\n\n");
            }
            else
            {
                Console.WriteLine("For a byte comparison enter two words of equal length.\n");
            }

            Regex word2regex = new Regex($"[{word2}]");
            Console.WriteLine(word2regex.Replace(word1, String.Empty));

            Console.ReadLine();
        }
    }
}
