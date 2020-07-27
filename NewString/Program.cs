using System;

namespace NewString
{
    class Program
    {
        static string ReverseString( string inputSring)
        {
            string outputString = "";
            for (int i = inputSring.Length; i > 0;)
            {
                outputString += inputSring[--i];
            }
            return outputString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ReverseString.Program.Main()");
            string myString = "testString";
            Console.WriteLine($"{myString} <> {ReverseString(myString)}");
        }
    }
}
