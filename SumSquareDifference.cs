using System;

namespace roject_euler
{
  // Problem nro 6 https://projecteuler.net/problem=6 
  // Find the difference between the sum of the squares of the first one hundred natural numbers 
  // and the square of the sum.
  public class SumSquareDifference
  {
    public string ReturnMessage()
    {

      Console.WriteLine("square of sum of natural numbers: " + (SumOfNaturalNumbers(1, 100) * SumOfNaturalNumbers(1, 100)));

      Console.WriteLine("sum of squares: " + SumOfSquares(100));

      Console.WriteLine("positive difference between the sum of the squares of " +
        "the first one hundred natural numbers and the square of the sum: " +
        positiveDifference(SumOfSquares(100), SquareOfSumOfNaturalNumbers(100)));
      return "";
    }

    public static int positiveDifference(int a, int b)
    {
      if (a > b)
      {
        return (a - b);
      }
      else
      {
        return (b - a);
      }
    }

    public static int SquareOfSumOfNaturalNumbers(int x)
    {
      return SumOfNaturalNumbers(1, x) * SumOfNaturalNumbers(1, x);
    }

    public static int SumOfSquares(int x)
    {
      int sumN = 0;
      for (int i = 1; i < 101; i++)
      {
        sumN = sumN + (i * i);
      }

      return sumN;
    }

    static int SumOfNaturalNumbers(int min, int max)
    {
      return CalcuSum(min, max);
    }

    static int CalcuSum(int min, int val)
    {
      if (val == min)
        return val;
      return val + CalcuSum(min, val - 1);
    }
  }
}