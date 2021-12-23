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
            Player playerLeft = new Player(tbxPlayerLeft.Text);
            Player playerRight = new Player(tbxPlayerRight.Text);
        }

        private void btnCreateCards_Click(object sender, EventArgs e)
        {
            
            foreach(var card in currentGame.CreateCards())
            {
                lbxCards.Items.Add(card.number + $" {card.suit}");
            }

            //disabling the button if cards exceed 20 
            if(lbxCards.Items.Count >= 20)
            {
                btnCreateCards.Enabled = false;
            }
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            if(tbxPlayerLeft.Text != "" && tbxPlayerRight.Text != "")
            {
                Player playerLeft = new Player(tbxPlayerLeft.Text);
                Player playerRight = new Player(tbxPlayerRight.Text);

                lblPlayerLeft.Text = playerLeft.name;
                lblPlayerRight.Text = playerRight.name;
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
            Player playerLeft = new Player(tbxPlayerLeft.Text);
            Player playerRight = new Player(lblPlayerRight.Text);
            currentGame.DealPlayerLeft(playerLeft);
            currentGame.DealPlayerLeft(playerRight);

            foreach(var card in playerLeft.cards)
            {
                lbxPlayerLeft.Items.Add(card.number + $"{card.suit}");
                lbxCards.Items.Remove(card.number + $"{card.suit}");
                currentGame.cards.Remove(card);
            }

            foreach(var card in playerRight.cards)
            {
                lbxPlayerRight.Items.Add(card.number + $"{card.suit}");
                lbxCards.Items.Remove(card.number + $"{card.suit}");
                currentGame.cards.Remove(card);  
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
            

        }
    }
}
