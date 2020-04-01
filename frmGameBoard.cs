using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BattleShipGame
{
    public partial class frmGameBoard : Form
    {
        Player currentPlayer;
        Player otherPlayer;
        Player playerOne;
        Player playerTwo;
        int playerNum;

        // Form constructor
        public frmGameBoard(Player playerOne, Player playerTwo)
        {
            InitializeComponent();
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            lblPlayerXsTurn.Text = "It's " + playerOne.getName() + "'s turn!";
        }

        // Form load event handler, shows P1's boards and hides P2's boards
        private void GameBoard_Load(object sender, EventArgs e)
        {
            playerNum = 1;
            currentPlayer = playerOne;
            otherPlayer = playerTwo;
            CreateBoards();

            btnDoneTurn.Enabled = false;
            pnlGuessBoard_P2.Hide();
            pnlShipBoard_P2.Hide();
            pnlShipBoard_P1.Show();
            pnlGuessBoard_P1.Show();
        }

        // Method that creates each player's 2 board for game play and assigns them to each player
        private void CreateBoards()
        {
            //Create and assign shipBoards
            Button[,] p1shipBoard = BoardHandler.GenerateBoard(pnlShipBoard_P1, Button_MouseClick);
            Button[,] p2shipBoard = BoardHandler.GenerateBoard(pnlShipBoard_P2, Button_MouseClick);
            //Create and assign guessBoards
            Button[,] p1guessBoard = BoardHandler.GenerateBoard(pnlGuessBoard_P1, Button_MouseClick);
            Button[,] p2guessBoard = BoardHandler.GenerateBoard(pnlGuessBoard_P2, Button_MouseClick);
            // Marks ship locations on each players ship board
            PlaceShips(p1shipBoard, playerOne.getShips());
            PlaceShips(p2shipBoard, playerTwo.getShips());
            //Give boards to player objects
            playerOne.setGuessBoard(p1guessBoard);
            playerOne.setShipBoard(p1shipBoard);
            playerTwo.setGuessBoard(p2guessBoard);
            playerTwo.setShipBoard(p2shipBoard);
        }

        // Click handler for cells on the current players guess board
        private void Button_MouseClick(object sender, EventArgs e)
        {
            btnDoneTurn.Enabled = true;
            bool hit = false;
            Ship[] otherPlayerShips = otherPlayer.getShips();
            Button btn = (Button)sender;
            int coordinates = int.Parse(btn.Tag.ToString());
            Button[,] myGuessBoard = currentPlayer.getGuessBoard();
            Button[,] otherPlayerBoard = otherPlayer.getShipBoard();
            // Checks coordinates of all the other players ships to see if guess was a hit / miss
            foreach (Ship ship in otherPlayerShips)
            {
                // Grabs ship coordinates for each ship looped over
                List<int> shipCoords = ship.getCord();
                foreach(int c in shipCoords)
                {
                    if (c == coordinates)
                    {
                        // Found matching ship coordinate, enemy ship has been hit
                        hit = true;
                        ship.Hit();
                        MessageBox.Show("Ship hit!!", "Hit");
                        // Sets board color to show hit
                        btn.BackColor = Color.Red;
                        otherPlayerBoard[getRow(coordinates), getCol(coordinates)].BackColor = Color.Red;

                        if (ship.IsShipSunk())
                        {
                            // Ship sunk, increment ship sunk counter for other player
                            MessageBox.Show("You sunk the other player's " + ship.getShipType(), "Ship Sunk");
                            currentPlayer.addShipSunk();
                        }
                        if (currentPlayer.hasWon())
                        {
                            // Current player sunk last ship and won
                            MessageBox.Show("Congratulations, " + currentPlayer.getName() + " you won!!!!", "Game Over");
                            Close();
                        }
                    }
                }
            }
            // Disables clicked board cell
            btn.Enabled = false;
            if (!hit)
            {
                // Sets board cells for a miss
                btn.BackColor = Color.Aqua;
                otherPlayerBoard[getRow(coordinates), getCol(coordinates)].BackColor = Color.Aqua;
                MessageBox.Show("Ship missed!!", "Miss");
            }
            // Disables current player's guess board after clicking on guess board
            if (playerNum == 1)
            {
                pnlGuessBoard_P1.Enabled = false;
            }
            else
            {
                pnlGuessBoard_P2.Enabled = false;
            }
        }

        // Method that marks ship locations on each players ship board
        public void PlaceShips(Button[,] shipBoard, Ship[] ships)
        {
            foreach(Ship ship in ships)
            {
                for(int i = 0; i < ship.getShipSize(); i++)
                {
                    int cord = ship.getCord()[i];
                    shipBoard[getRow(cord), getCol(cord)].BackColor = Color.DarkSlateGray;
                }
            }
        }

        // Click handler for done turn button
        // Prepares board to swap by hiding current guess/ship board to prevent cheating, assuming
        //both players are on the same pc.
        private void btnDoneTurn_Click(object sender, EventArgs e)
        {
            pnlGuessBoard_P1.Enabled = true;
            pnlGuessBoard_P2.Enabled = true;
            btnDoneTurn.Enabled = false;

            if (playerNum == 1)
            {
                // Switch to player 2
                pnlGuessBoard_P1.Hide();
                pnlShipBoard_P1.Hide();
                btnSwitchPlayers.Visible = true;
                btnSwitchPlayers.Enabled = true;
            }
            else
            {
                // Switch to player 1
                pnlGuessBoard_P2.Hide();
                pnlShipBoard_P2.Hide();
                btnSwitchPlayers.Visible = true;
                btnSwitchPlayers.Enabled = true;

            }
        }

        // Methods for getting board cell row and column from its cell number
        public int getRow(int cellNumber) { return cellNumber / 9; }
        public int getCol(int cellNumber) { return cellNumber % 9; }

        private void frmGameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Finishes swapping current player
        private void btnSwitchPlayers_Click(object sender, EventArgs e)
        {
            if(playerNum == 1)
            {
                pnlShipBoard_P2.Show();
                pnlGuessBoard_P2.Show();
                currentPlayer = playerTwo;
                otherPlayer = playerOne;
                playerNum = 2;
                lblPlayerXsTurn.Text = "It's " + playerTwo.getName() + "'s turn!";
                btnSwitchPlayers.Visible = false;
                btnSwitchPlayers.Enabled = false;
            }
            else
            {
                pnlShipBoard_P1.Show();
                pnlGuessBoard_P1.Show();
                currentPlayer = playerOne;
                otherPlayer = playerTwo;
                playerNum = 1;
                lblPlayerXsTurn.Text = "It's " + playerOne.getName() + "'s turn!";
                btnSwitchPlayers.Visible = false;
                btnSwitchPlayers.Enabled = false;
            }
        }
    }
}
