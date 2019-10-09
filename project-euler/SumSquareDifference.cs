using System;

namespace project_euler
{
  // Problem nro 6 https://projecteuler.net/problem=6 
  // Find the difference between the sum of the squares of the first one hundred natural numbers 
  // and the square of the sum.
  public class SumSquareDifference
  {
    private int value;

    public SumSquareDifference(int value)
    {
      this.value = value;
    }

    public int result()
    {
      return positiveDifference(SumOfSquares(), SquareOfSumOfNaturalNumbers());
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

    private int SquareOfSumOfNaturalNumbers()
    {
      return SumOfNaturalNumbers(1, this.value) * SumOfNaturalNumbers(1, this.value);
    }

    private int SumOfSquares()
    {
      int sumN = 0;
      for (int i = 0; i < this.value + 1; i++)
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