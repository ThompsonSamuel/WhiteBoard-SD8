using System;

namespace Palindrome
{
    public class Palindrome
    {

        public static bool isPalindrome(string inputString)
        {
            bool result;
            string x = inputString.ToLower();
            char[] array = x.ToCharArray();
            Array.Reverse(array);
            string y = new string(array);
            
            if (string.Equals(x, y))
                result = true;
            else
                result = false;

            return result;
        }


        static void Main(string[] args)
        {
            string teststring = "racecAr";
            Console.WriteLine(isPalindrome(teststring));
        }
    }
}
