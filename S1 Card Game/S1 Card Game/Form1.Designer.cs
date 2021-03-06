
namespace S1_Card_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxCards = new System.Windows.Forms.ListBox();
            this.btnCreateCards = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lbxPlayerLeft = new System.Windows.Forms.ListBox();
            this.lbxPlayerRight = new System.Windows.Forms.ListBox();
            this.lbxGame = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbxPlayerLeft = new System.Windows.Forms.TextBox();
            this.tbxPlayerRight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPlayerLeft = new System.Windows.Forms.Label();
            this.lblPlayerRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCards
            // 
            this.lbxCards.FormattingEnabled = true;
            this.lbxCards.ItemHeight = 20;
            this.lbxCards.Location = new System.Drawing.Point(14, 121);
            this.lbxCards.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxCards.Name = "lbxCards";
            this.lbxCards.Size = new System.Drawing.Size(229, 324);
            this.lbxCards.TabIndex = 0;
            // 
            // btnCreateCards
            // 
            this.btnCreateCards.Location = new System.Drawing.Point(15, 73);
            this.btnCreateCards.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateCards.Name = "btnCreateCards";
            this.btnCreateCards.Size = new System.Drawing.Size(126, 36);
            this.btnCreateCards.TabIndex = 1;
            this.btnCreateCards.Text = "Create Cards";
            this.btnCreateCards.UseVisualStyleBackColor = true;
            this.btnCreateCards.Click += new System.EventHandler(this.btnCreateCards_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cards";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player Left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Player Right";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(739, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Game";
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Location = new System.Drawing.Point(311, 193);
            this.btnCreatePlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(126, 36);
            this.btnCreatePlayer.TabIndex = 7;
            this.btnCreatePlayer.Text = "Create Players";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(311, 237);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(126, 36);
            this.btnDeal.TabIndex = 8;
            this.btnDeal.Text = "Deal Cards";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lbxPlayerLeft
            // 
            this.lbxPlayerLeft.FormattingEnabled = true;
            this.lbxPlayerLeft.ItemHeight = 20;
            this.lbxPlayerLeft.Location = new System.Drawing.Point(271, 321);
            this.lbxPlayerLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxPlayerLeft.Name = "lbxPlayerLeft";
            this.lbxPlayerLeft.Size = new System.Drawing.Size(214, 124);
            this.lbxPlayerLeft.TabIndex = 9;
            // 
            // lbxPlayerRight
            // 
            this.lbxPlayerRight.FormattingEnabled = true;
            this.lbxPlayerRight.ItemHeight = 20;
            this.lbxPlayerRight.Location = new System.Drawing.Point(493, 321);
            this.lbxPlayerRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxPlayerRight.Name = "lbxPlayerRight";
            this.lbxPlayerRight.Size = new System.Drawing.Size(214, 124);
            this.lbxPlayerRight.TabIndex = 10;
            // 
            // lbxGame
            // 
            this.lbxGame.FormattingEnabled = true;
            this.lbxGame.ItemHeight = 20;
            this.lbxGame.Location = new System.Drawing.Point(739, 121);
            this.lbxGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxGame.Name = "lbxGame";
            this.lbxGame.Size = new System.Drawing.Size(229, 324);
            this.lbxGame.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(843, 455);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 36);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(843, 548);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(126, 36);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(582, 455);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(126, 36);
            this.btnPlay.TabIndex = 14;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tbxPlayerLeft
            // 
            this.tbxPlayerLeft.Location = new System.Drawing.Point(311, 143);
            this.tbxPlayerLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPlayerLeft.Name = "tbxPlayerLeft";
            this.tbxPlayerLeft.Size = new System.Drawing.Size(114, 27);
            this.tbxPlayerLeft.TabIndex = 15;
            // 
            // tbxPlayerRight
            // 
            this.tbxPlayerRight.Location = new System.Drawing.Point(536, 143);
            this.tbxPlayerRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPlayerRight.Name = "tbxPlayerRight";
            this.tbxPlayerRight.Size = new System.Drawing.Size(114, 27);
            this.tbxPlayerRight.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Name:";
            // 
            // lblPlayerLeft
            // 
            this.lblPlayerLeft.AutoSize = true;
            this.lblPlayerLeft.Location = new System.Drawing.Point(271, 293);
            this.lblPlayerLeft.Name = "lblPlayerLeft";
            this.lblPlayerLeft.Size = new System.Drawing.Size(0, 20);
            this.lblPlayerLeft.TabIndex = 19;
            // 
            // lblPlayerRight
            // 
            this.lblPlayerRight.AutoSize = true;
            this.lblPlayerRight.Location = new System.Drawing.Point(493, 293);
            this.lblPlayerRight.Name = "lblPlayerRight";
            this.lblPlayerRight.Size = new System.Drawing.Size(0, 20);
            this.lblPlayerRight.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 600);
            this.Controls.Add(this.lblPlayerRight);
            this.Controls.Add(this.lblPlayerLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxPlayerRight);
            this.Controls.Add(this.tbxPlayerLeft);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbxGame);
            this.Controls.Add(this.lbxPlayerRight);
            this.Controls.Add(this.lbxPlayerLeft);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnCreatePlayer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateCards);
            this.Controls.Add(this.lbxCards);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCards;
        private System.Windows.Forms.Button btnCreateCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.ListBox lbxPlayerLeft;
        private System.Windows.Forms.ListBox lbxPlayerRight;
        private System.Windows.Forms.ListBox lbxGame;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox tbxPlayerLeft;
        private System.Windows.Forms.TextBox tbxPlayerRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPlayerLeft;
        private System.Windows.Forms.Label lblPlayerRight;
    }
}

