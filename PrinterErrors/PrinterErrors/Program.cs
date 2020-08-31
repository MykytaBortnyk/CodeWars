using System;
using System.Linq;

namespace PrinterErrors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string PrinterError(String s)
        {
            return String.Concat(s.Count(c => c > 'm'), "/" + s.Length);
        }
    }
}
