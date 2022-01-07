using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            

            for(int k = 0; k < 3; k++)
            {
                int randomNumber = rand.Next(2, 11);
                Card newCard = new Card(randomNumber, "Spades");
                cards.Add(newCard);
            }

            for(int i = 0; i < 2; i++)
            {
                int randomNumber = rand.Next(2, 11);
                Card newCard = new Card(randomNumber, "Hearts");
                cards.Add(newCard);
            }

            for(int j = 0; j < 3; j++)
            {
                int randomNumber = rand.Next(2, 11);
                Card newCard = new Card(randomNumber, "Clubs");
                cards.Add(newCard);
            }

            for(int h = 0; h < 2; h++)
            {
                int randomNumber = rand.Next(2, 11);
                Card newCard = new Card(randomNumber, "Diamonds");
                cards.Add(newCard);
            }
            return this.cards;
        }

        public void DealCards(ListBox lbx)
        {
            Random randomIndex = new Random();

            for(int i = 0; i < cards.Count; i++)
            {
                int indexer = randomIndex.Next(cards.Count);
                playerRight.cards.Add(cards.ElementAt(indexer));
                //I've set a listbox as a parameter in order to remove the elements
                //that need to be removed from the function itself, not from
                //the form control
                lbx.Items.RemoveAt(indexer);
                cards.RemoveAt(indexer);
            }

            for (int k = 0; k < cards.Count + 5; k++)
            {
                int secondIndexer = randomIndex.Next(cards.Count);
                playerLeft.cards.Add(cards.ElementAt(secondIndexer));
                lbx.Items.RemoveAt(secondIndexer);
                cards.RemoveAt(secondIndexer);
            }
        }

        public Player Play()
        {
            if (playerRight.selectedCard.number > playerLeft.selectedCard.number)
            {
                return playerRight;
            }
            else if (playerRight.selectedCard.number < playerLeft.selectedCard.number)
            {
                return playerLeft;
            }
            else
            {
                return null;
            }

            
        }
    }
}
