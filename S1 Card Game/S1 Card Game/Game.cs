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


        //change the return type of this function in the UML diagram.
        public List<Card> CreateCards()
        {
            Random rand = new Random();
            this.cards = new List<Card>();

            for(int k = 0; k < 5; k++)
            {
                int randomNumber = rand.Next(1, 10);
                Card newCard = new Card(randomNumber, "Clubs♣");
                cards.Add(newCard);
            }

            for(int j = 0; j < 3; j++)
            {
                int randomNumber = rand.Next(1, 10);
                Card newCard = new Card(randomNumber, "Hearts♥");
                cards.Add(newCard);
            }
            
            for(int i = 0; i < 2; i++)
            {
                int randomNumber = rand.Next(1, 10);
                Card newCard = new Card(randomNumber, "Spades♠");
                cards.Add(newCard);
            }
            return cards;
        }

        public void DealCards()
        {

        }
    }
}
