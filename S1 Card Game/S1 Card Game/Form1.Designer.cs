
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
            this.SuspendLayout();
            // 
            // lbxCards
            // 
            this.lbxCards.FormattingEnabled = true;
            this.lbxCards.ItemHeight = 15;
            this.lbxCards.Location = new System.Drawing.Point(12, 91);
            this.lbxCards.Name = "lbxCards";
            this.lbxCards.Size = new System.Drawing.Size(201, 244);
            this.lbxCards.TabIndex = 0;
            // 
            // btnCreateCards
            // 
            this.btnCreateCards.Location = new System.Drawing.Point(13, 55);
            this.btnCreateCards.Name = "btnCreateCards";
            this.btnCreateCards.Size = new System.Drawing.Size(110, 27);
            this.btnCreateCards.TabIndex = 1;
            this.btnCreateCards.Text = "Create Cards";
            this.btnCreateCards.UseVisualStyleBackColor = true;
            this.btnCreateCards.Click += new System.EventHandler(this.btnCreateCards_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cards";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player Left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Player Right";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Game";
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Location = new System.Drawing.Point(272, 145);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(110, 27);
            this.btnCreatePlayer.TabIndex = 7;
            this.btnCreatePlayer.Text = "Create Player";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(272, 200);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(110, 27);
            this.btnDeal.TabIndex = 8;
            this.btnDeal.Text = "Deal Cards";
            this.btnDeal.UseVisualStyleBackColor = true;
            // 
            // lbxPlayerLeft
            // 
            this.lbxPlayerLeft.FormattingEnabled = true;
            this.lbxPlayerLeft.ItemHeight = 15;
            this.lbxPlayerLeft.Location = new System.Drawing.Point(237, 241);
            this.lbxPlayerLeft.Name = "lbxPlayerLeft";
            this.lbxPlayerLeft.Size = new System.Drawing.Size(188, 94);
            this.lbxPlayerLeft.TabIndex = 9;
            // 
            // lbxPlayerRight
            // 
            this.lbxPlayerRight.FormattingEnabled = true;
            this.lbxPlayerRight.ItemHeight = 15;
            this.lbxPlayerRight.Location = new System.Drawing.Point(431, 241);
            this.lbxPlayerRight.Name = "lbxPlayerRight";
            this.lbxPlayerRight.Size = new System.Drawing.Size(188, 94);
            this.lbxPlayerRight.TabIndex = 10;
            // 
            // lbxGame
            // 
            this.lbxGame.FormattingEnabled = true;
            this.lbxGame.ItemHeight = 15;
            this.lbxGame.Location = new System.Drawing.Point(647, 91);
            this.lbxGame.Name = "lbxGame";
            this.lbxGame.Size = new System.Drawing.Size(201, 244);
            this.lbxGame.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(738, 341);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 27);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(738, 411);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(110, 27);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(509, 341);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 27);
            this.btnPlay.TabIndex = 14;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // tbxPlayerLeft
            // 
            this.tbxPlayerLeft.Location = new System.Drawing.Point(272, 107);
            this.tbxPlayerLeft.Name = "tbxPlayerLeft";
            this.tbxPlayerLeft.Size = new System.Drawing.Size(100, 23);
            this.tbxPlayerLeft.TabIndex = 15;
            // 
            // tbxPlayerRight
            // 
            this.tbxPlayerRight.Location = new System.Drawing.Point(469, 107);
            this.tbxPlayerRight.Name = "tbxPlayerRight";
            this.tbxPlayerRight.Size = new System.Drawing.Size(100, 23);
            this.tbxPlayerRight.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
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
    }
}

