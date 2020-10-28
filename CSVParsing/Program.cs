using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CSVParsing {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Reading CSV with embedded commas");
            List<string> myList = new List<string>();
            string input1 = "\"a,b\",c";
            myList.Add(input1);
            string input2 = "\"Obama, Barack\",\"August 4, 1961\",\"Washington, D.C.\"";
            myList.Add(input2);
            string input3 = "\"Ft. Benning, Georgia\",32.3632N,84.9493W," +
            "\"Ft. Stewart, Georgia\",31.8691N,81.6090W," +
            "\"Ft. Gordon, Georgia\",33.4302N,82.1267W";
            myList.Add(input3);

            var file = @"C:\Users\erau\Downloads\pres-test.csv";
            var filestring = new StreamReader(file);
            string input4 = filestring.ReadToEnd();
            myList.Add(input4);

            foreach (string s in myList) {
                Console.WriteLine($"Current input is {s}");
                List<string> output = getCSV(s);
                int len = output.Count;
                Console.WriteLine($"This line has {len} fields. They are:");
                foreach (string s1 in output)
                    Console.WriteLine(s1);
            }
        }

        public static List<string> getCSV(string input) {
            List<string> newList = input.Split('\"', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();
            for (int i = 0; i < newList.Count; i++) {
                if (newList[i].StartsWith(',')) {
                    newList[i] = newList[i].Trim(',');
                    foreach (var j in newList[i].Split(',', StringSplitOptions.RemoveEmptyEntries)) {
                        result.Add(j);
                    }
                }
                else
                    result.Add(newList[i]);
            }
            return result;
        }
    }
}
