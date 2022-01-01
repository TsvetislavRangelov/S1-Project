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
            currentGame.DealCards();

            foreach(var card in currentGame.playerLeft.cards)
            {
                lbxPlayerLeft.Items.Add(card.number + $"{card.suit}");
            }

            foreach(var card in currentGame.playerRight.cards)
            {
                lbxPlayerRight.Items.Add(card.number + $"{card.suit}");
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
