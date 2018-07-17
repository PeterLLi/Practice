using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };


            List<string> distinct = names.Distinct().ToList();
            foreach (string value in distinct)
            {
                Console.WriteLine("{0}", value);
            }

        }

        public void Contains(){
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordSearch = words.Where(w => w.Contains("th")).Count();
            Console.WriteLine(wordSearch);
        }

        public void Duplicates(){
            
        }
    }
}
