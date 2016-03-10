using System;

namespace FunctionalDictionaryTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dictionary = new FunctionalDictionary<int, string>
            {
                {a => a >= 1 && a <= 10, "1_idan 10_is chatvlit"},
                {a => a%3 == 0, "3_is jeradi"},
                {a => a%5 == 0, "5_is jeradi"}
            };

            Console.WriteLine(dictionary[3]);
            Console.WriteLine(dictionary[5]);
            Console.WriteLine(dictionary[7]);
            Console.WriteLine(dictionary[12]);
            Console.WriteLine(dictionary[15]);
            Console.WriteLine(dictionary[20]);
            Console.WriteLine(dictionary[25]);

            Console.ReadLine();
        }
    }
}