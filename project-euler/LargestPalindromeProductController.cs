using System;

namespace project_euler
{
  public class LargestPalindromeProductController
  {



    public void start()
    {
      Console.WriteLine("Find the largest palindrome made from the product of two whole numbers between 0-999.");
      Console.WriteLine("E.g. if you give 999 and 999 as input, you should receive 906609 as an answer.");




      Console.Write("1. number: ");
      string userInput1 = Console.ReadLine();

      Console.Write("2. number: ");
      string userInput2 = Console.ReadLine();

      try
      {
        int input1 = System.Convert.ToInt32(userInput1);
        int input2 = System.Convert.ToInt32(userInput2);
        LargestPalindromeProduct largestProduct = new LargestPalindromeProduct(input1, input2);
        Console.WriteLine("result: "+ largestProduct.BiggestPalindromeNumber()); 
        Console.WriteLine("_______________________________________________________________________________________");
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("please try again");
        Console.WriteLine("_______________________________________________________________________________________");
      }

    }
  }
}