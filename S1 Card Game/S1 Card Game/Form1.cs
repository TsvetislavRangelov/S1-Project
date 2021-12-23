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
    }
}
