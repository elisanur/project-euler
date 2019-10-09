using System;

namespace project_euler
{


  // Problem 4 https://projecteuler.net/problem=4
  // Find the largest palindrome made from the product of two 3-digit numbers.

  public class LargestPalindromeProduct
  {

    int firstPalindromeValue, secondPalindromeValue;
    public LargestPalindromeProduct(int firstPalindromeValue, int secondPalindromeValue)
    {
      this.firstPalindromeValue = firstPalindromeValue;
      this.secondPalindromeValue = secondPalindromeValue;
    }

    public string BiggestPalindromeNumber()
    {
      int biggestPalindrome = -1;
      string palindrome = "";

      if (this.firstPalindromeValue > -1 && this.firstPalindromeValue < 10000 && this.secondPalindromeValue > -1 && this.secondPalindromeValue < 10000)
      {
        for (int i = 0; i < firstPalindromeValue; i++)
        {
          for (int j = 0; j < secondPalindromeValue; j++)
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
      else
      {
        return "I couldn't find a palindrome product, did you insert whole numbers between 0 and 9999?";
      }
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
  }
}