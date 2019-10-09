using System;

namespace project_euler
{
  public class MultiplesController
  {


    public MultiplesController()
    {
      

    }

    public void multiples(){
      Console.WriteLine("Find the sum of all the multiples of x or y below 1000.");
      Console.WriteLine("e.g. giving input 3 and 5, you should receive 233168 as an answer");
      Console.WriteLine("Please remember to give one number at a time and press enter.");
      Console.WriteLine("Press q and enter to quit anytime.");

      Console.Write("x: ");
      string userInput1 = Console.ReadLine();
   
      Console.Write("y: ");
      string userInput2 = Console.ReadLine();

      try {
        int input1 = System.Convert.ToInt32(userInput1);
        int input2 = System.Convert.ToInt32(userInput2);
        Multiples multiples = new Multiples(input1, input2);
        Console.WriteLine("Answer is: " + multiples.GetSumOfMultiples());
        Console.WriteLine("_______________________________________________________________________________________");
      } catch {
        Console.WriteLine("Please try again");
      }
    }

  }
}