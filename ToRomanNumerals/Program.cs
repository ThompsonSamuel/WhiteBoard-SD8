using System;
using System.Linq;
using System.Collections.Generic;

namespace ToRomanNumerals {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(ToRoman(140));
        }

        static string ToRoman(int input) {
            string[] first = new string[]{ "","I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] second = new string[]{ "","X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] third = new string[]{ "","C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            List<int> inputList = new List<int>(); 
            while(input > 9) {
                if(input % 10 == 0) 
                    inputList.Add(0);
                else
                    inputList.Add(input % 10);
                input /= 10;
            }
            inputList.Add(input);
            string roman = "";
            for(int i = inputList.Count; i > 0; i--) {
                if(i == 3) 
                    roman += third[inputList[i-1]];
                else if(i == 2) 
                    roman += second[inputList[i-1]];
                else if(i == 1) 
                    roman += first[inputList[i-1]];
            }
            return roman;
        }
    }
}
