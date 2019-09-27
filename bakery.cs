using System;

namespace myBakery
{
  class Bread
    {
      public int BreadPrice { get; set; }

        public Bread()
        {
          BreadPrice = 5;
        }

        calculateBreadPrice(int breadAnswerInt)
        {
          if (breadAnswerInt == 1)
          {
            BreadPrice = 5;
          }
          else if (breadAnswerInt == 2)
          {
            BreadPrice = 10;
          }
          else if (breadAnswerInt > 2 && breadAnswerInt %2 == 0)
          {
            BreadPrice = (BreadAnswerInt/2) * 5;
          }
          else if (breadAnswerInt > 2 && breadAnswerInt %2 == 1)
          {
            BreadPrice = ((BreadAnswerInt/2) *5) +5; 
          }
        }
        //now wwrite methods to calculate price and have them return the price. then call the method in the frontend and do the console.writeline up there. 

    }

    class Pastry
    {
      public int PastryPrice { get; set; }
      public int PastryQuantity { get; set; }

        public Pastry()
        {
          PastryPrice = 2;
          PastryQuantity = 0;
        }

    }
}
