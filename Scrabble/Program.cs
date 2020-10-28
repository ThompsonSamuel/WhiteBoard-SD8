using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble {
    class Program {
        static void Main() {
            int i = 0;
            Console.Clear();
            random(i);
        }
        static void random(int i) {
            string input = Console.ReadLine();
            if (input == "55") {
                Main();
            }
            Console.WriteLine(i += scrabbleValue(input));
            random(i);
        }

        public static int scrabbleValue(string input) {
            int result = 0;

            Dictionary<char, int> scabbleValues = new Dictionary<char, int>() {
                {'A', 1},
                {'B', 3},
                {'C', 3},
                {'D', 2},
                {'E', 1},
                {'F', 4},
                {'G', 2},
                {'H', 4},
                {'I', 1},
                {'J', 8},
                {'K', 5},
                {'L', 1},
                {'M', 3},
                {'N', 1},
                {'O', 1},
                {'P', 3},
                {'Q', 10},
                {'R', 1},
                {'S', 1},
                {'T', 1},
                {'U', 1},
                {'V', 4},
                {'W', 4},
                {'X', 8},
                {'Y', 4},
                {'Z', 10}
            };

            string newinput = "";
            foreach (var i in input.ToUpper()) {
                if (scabbleValues.ContainsKey(i))
                    newinput += i;
            }

            foreach (char i in newinput) {
                result += scabbleValues[i];
            }

            return result;
        }
    }
}
