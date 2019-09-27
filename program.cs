using System;
using myBakery;

public class Program
{
  public static void Main()
  {
    Bread newBread = new Bread(); //because contsructor is a method. Parenthesis
    Pastry newPastry = new Pastry();
   
    Console.WriteLine("Welcome to my bakery! Would you like to purchase a loaf of bread or a pastry today? Press 'b' for bread; press 'p' for pastry");
    
    string userAnswer = Console.ReadLine();

    if (userAnswer.ToLower() == "b" || userAnswer.ToLower() == "bread")
      {
        Console.WriteLine("Please enter how many loaves of bread you'd like to purchase. We have a special: buy 2 loaves, get 1 free. Three loaf maximum");
        string breadAnswer = Console.ReadLine();
        int breadAnswerInt = int.Parse(breadAnswer);
        newBread.calculateBreadPrice(breadAnswerInt);
        Console.WriteLine ("Your price is " + newBread.BreadPrice);
      }
    else if (userAnswer.ToLower() == "p" || userAnswer.ToLower() == "pastry")
      {
        Console.WriteLine("Please enter how many pastries you'd like to purchase. Maximum purchase is 3.");
        string pastryAnswer = Console.ReadLine();
        int pastryAnswerInt = int.Parse(pastryAnswer);
        newPastry.calculatePastryPrice(pastryAnswerInt);
        Console.WriteLine ("Your price is " + newPastry.PastryPrice);
      }
    else
      {
      Console.WriteLine("Sorry, we didn't understand that. Please try again.");
      Main();
      }
  }
}