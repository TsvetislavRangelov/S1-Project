using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Card_Game
{
   public class Game
    {
        public List<Card> cards { get; private set; }
        public Player playerLeft { get; private set; }
        public Player playerRight { get; private set; }

        public void CreateCards()
        {
            this.cards = new List<Card>();

            

        }
    }
}
