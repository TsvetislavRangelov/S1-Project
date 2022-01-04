using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace S1_Card_Game
{
    public partial class Form1 : Form
    {
        Game currentGame = new Game();
        
        

        public Form1()
        {
            
            
            InitializeComponent();
            
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
                    currentGame.DealCards();

                    foreach (var card in currentGame.playerLeft.cards)
                    {
                        lbxPlayerLeft.Items.Add(card.number + $"{card.suit}");
                        lbxCards.Items.Remove(card);
                    }

                    foreach (var card in currentGame.playerRight.cards)
                    {
                        lbxPlayerRight.Items.Add(card.number + $"{card.suit}");
                        lbxCards.Items.Remove(card);
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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int rightScore = 0;
            int leftScore = 0;
            ListBox.SelectedObjectCollection rightSelectedItem = new ListBox.SelectedObjectCollection(lbxPlayerRight);

            if(rightSelectedItem.Count > 0)
            {
                Card rightSelectedCard = new Card(1, "Spades");

                rightSelectedCard.SetNumber(Convert.ToInt32(lbxPlayerRight.SelectedValue));
                rightSelectedCard.SetSuit(lbxPlayerRight.SelectedItem.ToString());
                currentGame.playerRight.SetSelectedCard(rightSelectedCard);
            }

            ListBox.SelectedObjectCollection leftSelectedItem = new ListBox.SelectedObjectCollection(lbxPlayerLeft);
            
            if(leftSelectedItem.Count > 0)
            {
                Card leftSelectedCard = new Card(1, "Spades");

                leftSelectedCard.SetNumber(Convert.ToInt32(lbxPlayerLeft.SelectedValue));
                leftSelectedCard.SetSuit(lbxPlayerLeft.SelectedItem.ToString());
                currentGame.playerLeft.SetSelectedCard(leftSelectedCard);
                
            }
            //move the logic into the play function
            if(currentGame.Play() == currentGame.playerLeft)
            {
                lbxGame.Items.Add($"{currentGame.playerLeft.name} {leftScore++} - {leftScore} {currentGame.playerRight.name}");
            }

            else if(currentGame.Play() == currentGame.playerLeft)
            {
                lbxGame.Items.Add($"{currentGame.playerLeft.name} {rightScore} - {leftScore++} {currentGame.playerRight.name}");
            }

            else
            {
                lbxGame.Items.Add($"{currentGame.playerLeft.name} {rightScore} - {leftScore} {currentGame.playerRight.name}");
                MessageBox.Show("The game was a draw");
            }

        }
    }
}
