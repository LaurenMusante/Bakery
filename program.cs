using System;
using myBakery;

class Program
{
  static void Main()
  {




  } //main curly
public static void PromptUser(_____, parameter) // what am I taking in as parameters here?. Line 25 in Plant gh
  {
    Console.WriteLine("Would you like to purchase a loaf of bread or a pastry today? Press 'b' for bread; press 'p' for pastry");
    string userAnswer = Console.ReadLine();

    if (userAnswer.ToLower() == "b" || userAnswer.ToLower() == "bread")
    {
      Console.WriteLine("Please enter how many loaves of bread you'd like to purchase.");
      string breadAnswer = Console.ReadLine();
      int breadAnswerInt = int.Parse(breadAnswer);

        if (breadAnswerInt == 1)
        {
          Console.WriteLine("Your price is $5.");
        }
        else if (breadAnswerInt == 2)
        {
          Console.WriteLine("You get an extra loaf on the house! You might only want 2 loaves. But you get 3 loaves for $10!");
        }
        else (breadAnswerInt % 2 == 0)
        {
          price = breadAnswerInt/2 * 5; //(2 for 1) times $5
          //code for if a user wants to purchase more than 2 loaves. Include math to calc buy 2, get 1 free.
        }
    }
    else if   (userAnswer.ToLower() == "p" || userAnswer.ToLower() == "pastry")
    {
      Console.WriteLine("Please enter how many pastries you'd like to purchase.");
      string pastryAnswer = Console.ReadLine();
      int pastryAnswerInt = int.Parse(pastryAnswer);

      if (pastryAnswerInt == 1)
      {
        Console.WriteLine("Your price is $2.");
      }
      else if (pastryAnswerInt == 2)
      {
        Console.WriteLine("Your price is $4.");
      }
      else if (pastryAnswerInt == 3)
      {
        Console.WriteLine("You get a bulk discount! Your price for 3 pastries is $5.");
      }
      else (pastryAnswerInt % 3 == 0)
      {
        price = pastryAnswerInt/3 * 5; // code for if a user wants to purchase more than 3 pastries. Include math to calculate buy 3 for $5.
      }
    }
    else
    {
      Console.WriteLine("Sorry, we didn't understand that. Please try again.");
      PromptUser(_____);
    }
  } //PromptUserBread curly

} //program curly
