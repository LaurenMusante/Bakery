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
          else if (breadAnswerInt == 3)
          {
            BreadPrice =10;
          }
        }
    }
    class Pastry
    {
      public int PastryPrice { get; set; }

        public Pastry()
        {
          PastryPrice = 2;
        }
        calculatePastryPrice(int pastryAnswerInt)
          {
            if (PastryAnswerInt == 1)
            {
              PastryPrice = 2; 
            }
            else if (PastryAnswerInt == 2)
            {
              PastryPrice = 4;
            }
            else if (PastryAnswerInt == 3)
            {
              PastryPrice = 5;
            }
          }
    }
  }

