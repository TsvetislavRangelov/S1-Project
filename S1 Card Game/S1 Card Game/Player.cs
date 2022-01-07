using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Card_Game
{
  public class Player
    {
        public string name { get; private set; }
        public List<Card> cards { get; private set; }
        public Card selectedCard { get; private set; }

        //constructor
        public Player(string name)
        {
            this.name = name;
            this.cards = new List<Card>();
            this.selectedCard = new Card(0, "");
        }  

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSelectedCard(Card selectedCard)
        {
            this.selectedCard = selectedCard;
        }
    }
}
