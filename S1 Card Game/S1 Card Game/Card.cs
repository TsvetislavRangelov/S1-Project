using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Card_Game
{
   public class Card
    {
        public int number { get; private set; }
        public string suit { get; private set; }

        public Card(int number, string suit)
        {
            this.number = number;
            this.suit = suit;
        }

        public void SetNumber(int number)
        {
            this.number = number;
        }

        public void SetSuit(string suit)
        {
            this.suit = suit;
        }
    }
}
