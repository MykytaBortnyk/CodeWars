using System;
using System.Linq;

namespace VowelCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }

        public static int GetVowelCount(string str)
        {
            //int vowelCount = 0;

            // Your code here

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };



            return str.ToLower().Count(v => vowels.Contains(v));
        }
    }
}
