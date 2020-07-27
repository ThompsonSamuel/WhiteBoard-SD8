using System;

namespace LetterCountInString
{
    class Program
    {
		//3 - 'H'
		//Name of Movie
		//return how many of a letter are in the name
		public static int LetterCountInString(string title, char searchChar)
		{
			int letterCount = 0;

			searchChar = char.ToLower(searchChar);
			title = title.ToLower();
			
				for (int i = 0; i <= title.Length; i++)
			{
				if (title[0] == searchChar)
				{
					letterCount++;
				}
			}

			return letterCount;
		}
		static void Main(string[] args)
        {
            Console.WriteLine("Program.LetterCountInString()");

			string movieTitle = "Shawshank Redemption";
			char searchLetter = 'S';
			int count = LetterCountInString(movieTitle, searchLetter);

            Console.WriteLine($"There are {count} {searchLetter} in {movieTitle}");		
		}
    }
}
