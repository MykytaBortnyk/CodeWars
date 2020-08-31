using System;
using System.Linq;

namespace TwoToOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }

        public static string Longest(string s1, string s2)
        {
            var str = s1.Union(s2);

            return String.Concat(str.OrderBy(c => c));
        }
    }
}
