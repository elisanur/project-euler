using System;

namespace project_euler
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("This application has 3 programs, start with typing '1', '2' or '3' and pressing enter. ");
        Console.WriteLine("Return to this menu any time by entering 'q' and then pressing enter");
        Console.WriteLine("1: Multiples");
        Console.WriteLine("2: Largest Palindrome");
        Console.WriteLine("3: Sum square difference");

        string userInput = Console.ReadLine();

        if (userInput.Equals("q")){
          Console.WriteLine("moi");
        } else if (userInput.Equals("1")) {
          Console.WriteLine("Great! You selected Program 1, Multiples.");
        } else if (userInput.Equals("2")) {
          Console.WriteLine("Great! You selected Program 2, Largest Palindrome.");
        } else if (userInput.Equals("3")) {
          Console.WriteLine("Great! You selected Program 1, Sum Square Difference.");
        } else {
          Console.Clear();
          Console.WriteLine("I'm sorry I didn't quite understand you, please try following the instructions:");
        }
      }


    }
  }
}
