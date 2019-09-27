using System;
using myBakery;

class Program
{
  static void Main()
  {


  } //main curly
public static void PromptUser(quantity) // what am I taking in as parameters here?. Line 25 in Plant gh
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
          BreadQuantity.Add(breadAnswerInt); //??
          Console.WriteLine("Your total price is $5.");
        }
        else if (breadAnswerInt == 2)
        {
          BreadQuantity.Add(breadAnswerInt); //??
          Console.WriteLine("You get an extra loaf on the house! You might only want 2 loaves. But you get 3 loaves for only $10!");
        }
        else (breadAnswerInt % 2 == 0)
        {
          BreadQuantity.Add(breadAnswerInt); // add user's int bread answer to BreadQuantity (in the class definition) and do maths on it.
            if (BreadQuantity % 2 == 0)
            {
              BreadPrice = (BreadQuantity/2) * 5;
              Console.WriteLine("Your total price is " + BreadPrice.)
            }
        }
    }
    else if   (userAnswer.ToLower() == "p" || userAnswer.ToLower() == "pastry")
    {
      Console.WriteLine("Please enter how many pastries you'd like to purchase.");
      string pastryAnswer = Console.ReadLine();
      int pastryAnswerInt = int.Parse(pastryAnswer);

      if (pastryAnswerInt == 1)
      {
        PastryQuantity.Add(pastryAnswerInt);
        Console.WriteLine("Your price is $2.");
      }
      else if (pastryAnswerInt == 2)
      {
        PastryQuantity.Add(pastryAnswerInt);
        Console.WriteLine("Your price is $4.");
      }
      else if (pastryAnswerInt == 3)
      {
        PastryQuantity.Add(pastryAnswerInt);
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
      PromptUser(quantity);
    }
  } //PromptUserBread curly

} //program curly
