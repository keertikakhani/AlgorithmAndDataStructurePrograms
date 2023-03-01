using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDataStructurePrograms
{
    public class Anagram
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();

            char[] chr1 = str1.ToLower().ToCharArray();
            char[] chr2 = str2.ToLower().ToCharArray();

            Array.Sort(chr1);
            Array.Sort(chr2);

            string val1 = new string(chr1);
            string val2 = new string(chr2);

            if(val1==val2)
            {
                Console.WriteLine("Both strings are anagrams");
            }
            else
            {
                Console.WriteLine("Both strings are not anagrams");
            }
        }
    }
}
