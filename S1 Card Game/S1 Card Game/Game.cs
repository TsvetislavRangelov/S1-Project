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

        //default constructor overload is for creating
        //the objects of the players from the form.
        //I'm using the player class to modify their
        //names from the form with a Set function.
        public Game()
        {
            
            this.cards = new List<Card>();
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
                int randomNumber = rand.Next(2, 11);
                Card newCard = new Card(randomNumber, "Spades");
                cards.Add(newCard);
            }
            return cards;
        }

        public void DealCards()
        {
            Random randomIndex = new Random();

            for(int i = 0; i < cards.Count; i++)
            {
                int indexer = randomIndex.Next(cards.Count);
                playerRight.cards.Add(cards.ElementAt(indexer));
                cards.RemoveAt(indexer);
            }

            Random scndRandomIndex = new Random();

            for (int k = 0; k < cards.Count + 5; k++)
            {
                int secondIndexer = scndRandomIndex.Next(cards.Count);
                playerLeft.cards.Add(cards.ElementAt(secondIndexer));
                cards.RemoveAt(secondIndexer);
            }
        }

      
    }
}
