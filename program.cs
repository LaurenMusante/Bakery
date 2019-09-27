using System;
using myBakery;

public class Program
{
  public static void Main()
  {
    Bread newBread = new Bread(); //because contsructor is a method. Parenthesis
   
    Console.WriteLine("Welcome to my bakery! Would you like to purchase a loaf of bread or a pastry today? Press 'b' for bread; press 'p' for pastry");
    string userAnswer = Console.ReadLine();

    if (userAnswer.ToLower() == "b" || userAnswer.ToLower() == "bread")
    {
      Console.WriteLine("Please enter how many loaves of bread you'd like to purchase.");
      string breadAnswer = Console.ReadLine();
      int breadAnswerInt = int.Parse(breadAnswer);
        if (breadAnswerInt == 1)
        {
          breadquantity.AddBread(); //??
          Console.WriteLine("Your total price is $5.");
        }
        else if (breadAnswerInt == 2)
        {
          BreadQuantity.Add(breadAnswerInt); //??
          Console.WriteLine("You get an extra loaf on the house! You might only want 2 loaves. But you get 3 loaves for only $10!");
        }
        else if (breadAnswerInt % 2 == 0 && breadAnswerInt != 2)
        {
          BreadQuantity.Add(breadAnswerInt); // add user's int bread answer to BreadQuantity (in the class definition) and do maths on it.
          BreadPrice = (BreadQuantity/2) * 5;
          Console.WriteLine("Bulk Discount! Your total price is $" + BreadPrice + ".");
        }
        else if (breadAnswerInt % 2 == 1 && breadAnswerInt != 2 && breadAnswerInt !=1)
        {
          BreadQuantity.Add(breadAnswerInt); // add user's int bread answer to BreadQuantity (in the class definition) and do maths on it.
          BreadPrice = ((BreadQuantity/2) * 5) +5;
          Console.WriteLine("Bulk discount! Your total price is $" + BreadPrice + ".");
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
        else if (pastryAnswerInt % 3 == 0 && pastryAnswerInt !=3)
        {
          PastryQuantity.Add(pastryAnswerInt);
          PastryPrice = (PastryQuantity/3 * 5);
          Console.WriteLine("Your total price is $" + PastryPrice + ".");
        }
        else if (pastryAnswerInt % 3 == 1 && pastryAnswerInt !=3)
        {
          PastryQuantity.Add(pastryAnswerInt);
          PastryPrice = ((PastryQuantity/3 * 5)) + 2;
          Console.WriteLine("Bulk Discount! Your total price is $" + PastryPrice + ".");
        }
        else if (pastryAnswerInt % 3 == 0 && pastryAnswerInt !=3)
        {
          PastryQuantity.Add(pastryAnswerInt);
          PastryPrice = ((PastryQuantity/3 * 5)) + 4 ;
          Console.WriteLine("Bulk Discount! Your total price is $" + PastryPrice + ".");
        }
    }
    else
    {
      Console.WriteLine("Sorry, we didn't understand that. Please try again.");
      Main();
    }
  } //PromptUserBread curly
}