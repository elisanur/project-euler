using System;

namespace roject_euler
{


    // Problem 4 https://projecteuler.net/problem=4
    // Find the largest palindrome made from the product of two 3-digit numbers.

    public class LargestPalindromeProduct
    {
        public string ReturnMessage()
        {
            return "";
        }

        public static Boolean IntIsPalindrome(string isPalindrome)
    {
      //Console.WriteLine("is this palindrome?: " + isPalindrome);
      string first = "";
      string second = "";

      // if palindrome is 
      if (isPalindrome.Length % 2 == 0)
      {
        first = isPalindrome.Substring(0, (isPalindrome.Length / 2));
        second = isPalindrome.Substring(isPalindrome.Length / 2, isPalindrome.Length / 2);
      }
      else
      {
        double value = (isPalindrome.Length / 2);
        value = value + 1;
        int index = Convert.ToInt32(value);
        first = isPalindrome.Substring(0, index);
        second = isPalindrome.Substring((index - 1), index);
      }

      second = ReverseString(second);

      return first.Equals(second);

    }

    public static string ReverseString(string s)
    {
      char[] arr = s.ToCharArray();
      Array.Reverse(arr);
      return new string(arr);
    }


    public static string BiggestPalindromeNumber(int a, int b)
    {
      int biggestPalindrome = -1;
      string palindrome = "";

      for (int i = 100; i < 999; i++)
      {
        for (int j = 100; j < 999; j++)
        {
          if (IntIsPalindrome((i * j).ToString()))
          {
            if (i * j > biggestPalindrome)
            {
              biggestPalindrome = i * j;
              palindrome = (i * j).ToString();
            }

          }
        }
      }

      return palindrome;
    }
    }
}