using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S1_Card_Game
{
    public partial class Form1 : Form
    {
        Game currentGame = new Game();
        
        public Form1()
        {    
            InitializeComponent();   
        }

        public void ClearFields()
        {
            lbxCards.Items.Clear();
            lbxPlayerLeft.Items.Clear();
            lbxPlayerRight.Items.Clear();
            lbxGame.Items.Clear();
            lblPlayerRight.Text = "";
            lblPlayerLeft.Text = "";

            currentGame.cards.Clear();
            currentGame.playerLeft.cards.Clear();
            currentGame.playerRight.cards.Clear();

            currentGame.cards.Clear();
        }

        private void btnCreateCards_Click(object sender, EventArgs e)
        {
            foreach (var card in currentGame.CreateCards())
            {
                lbxCards.Items.Add(card.number + $" {card.suit}");
            }
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            if(tbxPlayerLeft.Text != "" && tbxPlayerRight.Text != "")
            {
                currentGame.playerLeft.SetName(tbxPlayerLeft.Text);
                currentGame.playerRight.SetName(tbxPlayerRight.Text);

                lblPlayerLeft.Text = currentGame.playerLeft.name;
                lblPlayerRight.Text = currentGame.playerRight.name;
                
            }
            
            if(tbxPlayerLeft.Text == "" || tbxPlayerRight.Text == "")
            {
                MessageBox.Show("Please, specifiy a player name.");
            }

            tbxPlayerLeft.Text = "";
            tbxPlayerRight.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentGame.cards.Count <= 0)
                {
                    MessageBox.Show("Please, create cards before dealing.");
                }

                else if(lblPlayerLeft.Text == "" || lblPlayerLeft.Text == "")
                {
                    MessageBox.Show("Please, create the players before dealing.");
                }
                else
                {
                    currentGame.DealCards(lbxCards);

                    foreach (var card in currentGame.playerLeft.cards)
                    {
                        lbxPlayerLeft.Items.Add(card.number + $" ,{card.suit}");
                        
                        
                    }

                    foreach (var card in currentGame.playerRight.cards)
                    {
                        lbxPlayerRight.Items.Add(card.number + $" ,{card.suit}");
                        
                    }
                }       
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please, create the cards before dealing them.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //getting just the number of the selected card using substrings
            string lSelected = lbxPlayerLeft.SelectedItem.ToString();
            string lNumber = lSelected.Substring(0, lSelected.IndexOf(' '));

            string rSelected = lbxPlayerRight.SelectedItem.ToString();
            string rNumber = rSelected.Substring(0, rSelected.IndexOf(' '));
            
            ListBox.SelectedObjectCollection rightSelectedItem = new ListBox.SelectedObjectCollection(lbxPlayerRight);

            if(rightSelectedItem.Count > 0)
            {
                //setting the selected card and its number from the substring
                Card rSelectedCard = new Card(0, "");
                rSelectedCard.SetNumber(Convert.ToInt32(rNumber));
                currentGame.playerRight.SetSelectedCard(rSelectedCard);
            }

            ListBox.SelectedObjectCollection leftSelectedItem = new ListBox.SelectedObjectCollection(lbxPlayerLeft);
            
            if(leftSelectedItem.Count > 0)
            {
                Card lSelectedCard = new Card(0, "");
                lSelectedCard.SetNumber(Convert.ToInt32(lNumber));
                currentGame.playerLeft.SetSelectedCard(lSelectedCard);
            }
            
            if(currentGame.Play() == currentGame.playerRight)
            {
                lbxGame.Items.Add($"The winner is:  {currentGame.playerRight.name}");
                lbxPlayerLeft.Items.Remove(lSelected);
                lbxPlayerRight.Items.Remove(rSelected);
            }
            else if(currentGame.Play() == currentGame.playerLeft)
            {
                lbxGame.Items.Add($"The Winner is:  {currentGame.playerLeft.name}");
                lbxPlayerLeft.Items.Remove(lSelected);
                lbxPlayerRight.Items.Remove(rSelected);
            }
            else
            {
                lbxGame.Items.Add("Draw, card numbers were equal");
                lbxPlayerLeft.Items.Remove(lSelected);
                lbxPlayerRight.Items.Remove(rSelected);
            }
        }
    }
}
