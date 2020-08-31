using System;
using System.Linq;

namespace ShortestWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int FindShort(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }
    }
}
