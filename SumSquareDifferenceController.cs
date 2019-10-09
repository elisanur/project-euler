using System;

namespace project_euler
{
  public class SumSquareDifferenceController
  {
    public string SumSquareDifference(){
      return "";
    }

    public void start(){

      Console.WriteLine("Find the difference between the sum of the squares of the first x natural "
      + "numbers and the square of the sum.");
      Console.WriteLine("E.g. if you give 100 as input, you should receive 25164150 as an answer");

      string userInput = Console.ReadLine();
      
      try {
        int input = System.Convert.ToInt32(userInput);
        SumSquareDifference ssd = new SumSquareDifference(input);
        Console.WriteLine("positive difference between the sum of the squares of " +
        "the first one hundred natural numbers and the square of the sum: " + ssd.result());
        Console.WriteLine("_______________________________________________________________________________________");
      } catch {
        Console.WriteLine("Please try again.");
      }

      

    }
  }
}