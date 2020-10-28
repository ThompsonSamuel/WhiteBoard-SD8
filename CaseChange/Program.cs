using System;
using System.Linq;

namespace CaseChange {
    class Program {
        static void Main(string[] args) {
            string[] test = { "this", "is", "the$$  ", "test##ing", "arr%ay" };
            string[] test2 = { "t $$h e", "q ui ck", "br o123w n", "fox" };
            Console.WriteLine(toCamel(test));
            Console.WriteLine(toPascel(test2));
        }

        static string toCamel(string[] input) {
            string result = "";
            for(int i = 0; i < input.Length; i++) {
                string temp = "";
                for (int j = 0; j < input[i].Length; j++) {
                    if (Char.IsLetter(input[i][j])) {
                        temp += input[i][j].ToString();
                    }
                }
                result += temp[0].ToString().ToUpper();
                result += temp[1..];
            }
            return result;
        }

        static string toPascel(string[] input) {
            string result = "";
            for (int i = 0; i < input.Length; i++) {
                string temp = "";
                for (int j = 0; j < input[i].Length; j++) {
                    if (Char.IsLetter(input[i][j])) {
                        temp += input[i][j].ToString();
                    }
                }
                if( i != 0) {
                    result += temp[0].ToString().ToUpper();
                    result += temp[1..];
                }
                else {
                    result += temp;
                }
            }
            return result;
        }
    }
}
