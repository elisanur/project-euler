using System;

namespace roject_euler
{
  // Problem 1 https://projecteuler.net/problem=1 
  // Find the sum of all the multiples of 3 or 5 below 1000.
  public class Multiples
  {

    private int sum = 0;
    private int value1, value2;

    public Multiples(int a, int b){
      value1 = a;
      value2 = b;
    }

    private int GetSumOfMultiples()
    {
      for (int i = 0; i < 1000; i++)
      {
        if ((i % value1 == 0) || (i % value2 == 0))
        {
          sum = sum + i;
        }
      }
      return sum;
    }
  }
}