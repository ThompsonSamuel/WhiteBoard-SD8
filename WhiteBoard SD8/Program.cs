using System;
using System.Collections;
using System.Linq;

namespace WhiteboardSD8 
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine(Alphabetical("sdfuhiuwe ASFHIuaf sfohWOVvvIHasiD"));
		}

		static string Alphabetical(string input)
		{
			input = String.Concat(input.Where(x => !char.IsWhiteSpace(x)));
			input = input.ToLower();
			char[] inputA = input.ToCharArray();
			for (int i = 0; i < inputA.Length - 2; i++)
			{
				for (int a = 0; a < inputA.Length - 2; a++)
				{
					if (inputA[a] > inputA[a + 1])
					{
						char temp = inputA[a];
						inputA[a] = inputA[a + 1];
						inputA[a + 1] = temp;
					}
				}
			}
			string result = "";
			foreach(char i in inputA)
            {
				result += i;
            }
			return result;
		}
	}
}
