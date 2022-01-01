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

        //constuctor is for creating the objects of the players from the game
        //I'm using the player class to modify their names from the form with a Set method
        public Game()
        {
            this.playerLeft = new Player("");
            this.playerRight = new Player("");
        }

        //change the return type of this function in the UML diagram.
        public List<Card> CreateCards()
        {
            Random rand = new Random();
            this.cards = new List<Card>();

            for(int k = 0; k < 10; k++)
            {
                int randomNumber = rand.Next(1, 10);
                Card newCard = new Card(randomNumber, "Spades");
                cards.Add(newCard);
            }
            return cards;
        }

        public void DealCards()
        {
            Random randomIndex = new Random();

            foreach(var card in cards)
            {
                playerLeft.cards.Add(card);
                playerRight.cards.Add(card);
            }


        }
    }
}
