﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Problem one
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordSearch = words.Where(w => w.Contains("th")).Count();
            Console.WriteLine(wordSearch);

            //Problem two
            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            foreach (string value in names)
            {
                Console.WriteLine("Before: {0}", value);
            }

            List<string> distinct = names.Distinct().ToList();
            foreach (string value in distinct)
            {
                Console.WriteLine("After: {0}", value);
            }

            //Problem three
            List<string> classGrades = new List<string>(){
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            List<double> studentAverage = new List<double>();
            double classAverage;

            for (int i = 0; i < classGrades.Count; i++){
                var usersGrades = classGrades[i].Split(',').Select(s => int.Parse(s)).ToList();
                var ascendingOrder = usersGrades.OrderBy(j => j).ToList();
                Console.WriteLine("Sort");
                foreach (var item in ascendingOrder)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");

                var dropLowest = from lowestScore in ascendingOrder
                                 where lowestScore > ascendingOrder.Min()
                                 select lowestScore;
                Console.WriteLine("Drop lowest");
                foreach (var item in dropLowest)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
                studentAverage.Add(dropLowest.Average());
            }

            Console.WriteLine("Individual Averages");
            for (int k = 0; k < studentAverage.Count; k++){
                Console.WriteLine(studentAverage[k]);
            }
            Console.WriteLine("");

            Console.WriteLine("Class Average");
            classAverage = studentAverage.Average();
            Console.WriteLine(classAverage);
            Console.WriteLine("");

            //Problem 4
            string str = "terrill";
            List<string> charCounts = str.GroupBy(ch => ch).OrderBy(item => item.Key).Select(item => item.Key + "=" + item.Count().ToString()).ToList();

            foreach (string s in charCounts)
            {
                Console.WriteLine(s);

            }
            Console.ReadKey();
        }
    }
}
