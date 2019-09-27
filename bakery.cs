using System;

namespace myBakery
{
  class Bread
    {
      public int BreadPrice { get; set; }
      public int BreadQuantity { get; set; }

        public Bread()
        {
          BreadPrice = 5;
          BreadQuantity = 0;
        }

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
