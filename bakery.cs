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

        public int calculateBreadPrice(int breadAnswerInt)
        {
          if (breadAnswerInt == 1)
          {
            BreadPrice = 5;
          }
          else if (breadAnswerInt == 2)
          {
            BreadPrice = 10;
          }
          else if (breadAnswerInt == 3)
          {
            BreadPrice =10;
          }
          return BreadPrice;
        }
    }
    class Pastry
    {
      public int PastryPrice { get; set; }

        public Pastry()
        {
          PastryPrice = 2;
        }
        public int calculatePastryPrice(int pastryAnswerInt)
          {
            if (pastryAnswerInt == 1)
            {
              PastryPrice = 2; 
            }
            else if (pastryAnswerInt == 2)
            {
              PastryPrice = 4;
            }
            else if (pastryAnswerInt == 3)
            {
              PastryPrice = 5;
            }
            return PastryPrice;
          }
    }
  }

