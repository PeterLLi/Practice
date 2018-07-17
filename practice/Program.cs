using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var wordSearch = words.Where(w => w.Contains("th")).Count();

            Console.WriteLine(wordSearch);
            Console.ReadKey();
        }
    }
}
