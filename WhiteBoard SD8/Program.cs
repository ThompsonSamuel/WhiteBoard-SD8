using System;
using System.Linq;
using System.Runtime.Serialization;

namespace WhiteboardSD8 {
    class Program {
        static void Main(string[] args) {
            DateTime time = new DateTime(2000, 1, 1, 6, 55, 0);
            Console.WriteLine(ClockHandAngle(time));
        }

        static double ClockHandAngle(DateTime input) {
            double angle = Math.Abs(input.Hour * 30 + input.Minute / 2.0 - (input.Minute * 6));
            return angle > 360 ? angle - 360 : angle;
        }

        static bool isPalindrome(string input) {
            for (int i = input.Length - 1, j = 0; i > input.Length / 2; i--, j++) {
                if (input.ToLower()[j] != input.ToLower()[i])
                    return false;
            }
            return true;
        }

        static string Alphabetical(string input) {
            input = String.Concat(input.Where(x => !char.IsWhiteSpace(x)));
            input = input.ToLower();
            char[] inputA = input.ToCharArray();
            for (int i = 0; i < inputA.Length - 2; i++) {
                for (int a = 0; a < inputA.Length - 2; a++) {
                    if (inputA[a] > inputA[a + 1]) {
                        char temp = inputA[a];
                        inputA[a] = inputA[a + 1];
                        inputA[a + 1] = temp;
                    }
                }
            }
            string result = "";
            foreach (char i in inputA) {
                result += i;
            }
            return result;
        }
    }
}
