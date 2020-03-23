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
        const int boardDimensions = 9; //X by X board size
        int[,] board = new int[boardDimensions, boardDimensions];

        public frmGameBoard(Player playerOne, Player playerTwo)
        {
            InitializeComponent();
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            lblPlayerXsTurn.Text = "It's " + playerOne.getName() + "'s turn!";
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            playerNum = 1;
            currentPlayer = playerOne;
            otherPlayer = playerTwo;
            DisplayBoards(board);
            PlaceShips(playerOne.getShipBoard(),playerOne.getShips());
            PlaceShips(playerTwo.getShipBoard(),playerTwo.getShips());

            btnDoneTurn.Enabled = false;
            pnlGuessBoard_P2.Hide();
            pnlShipBoard_P2.Hide();
            pnlShipBoard_P1.Show();
            pnlGuessBoard_P1.Show();
        }

        private void DisplayBoards(int[,] internalBoard)
        {
            //Create and assign shipBoards
            Button[,] p1shipBoard = BoardHandler.GenerateBoard(pnlShipBoard_P1, Button_MouseClick);
            Button[,] p2shipBoard = BoardHandler.GenerateBoard(pnlShipBoard_P2, Button_MouseClick);
            //Create and assign guessBoards
            Button[,] p1guessBoard = BoardHandler.GenerateBoard(pnlGuessBoard_P1, Button_MouseClick);
            Button[,] p2guessBoard = BoardHandler.GenerateBoard(pnlGuessBoard_P2, Button_MouseClick);

            //Give boards to player objects

            playerOne.setGuessBoard(p1guessBoard);
            playerOne.setShipBoard(p1shipBoard);
            playerTwo.setGuessBoard(p2guessBoard);
            playerTwo.setShipBoard(p2shipBoard);
        }

        private void Button_MouseClick(object sender, EventArgs e)
        {
            btnDoneTurn.Enabled = true;
            bool hit = false;
            Ship[] otherPlayerShips = otherPlayer.getShips();
            Button btn = (Button)sender;
            string[] IndividualCoords = btn.Tag.ToString().Split('*');
            int coordinates = int.Parse(btn.Tag.ToString());
            Button[,] myGuessBoard = currentPlayer.getGuessBoard();
            Button[,] otherPlayerBoard = otherPlayer.getShipBoard();
            foreach (Ship ship in otherPlayerShips)
            {
                List<int> shipCoords = ship.getCord();
                foreach(int c in shipCoords)
                {
                    if (c == coordinates)
                    {
                        hit = true;
                        ship.Hit();
                        MessageBox.Show("Ship hit!!", "Hit");
                        // Sets board color to show hit
                        btn.BackColor = Color.Red;
                        otherPlayerBoard[getRow(coordinates), getCol(coordinates)].BackColor = Color.Red;

                        if (ship.IsShipSunk())
                        {
                            MessageBox.Show("You sunk the other player's " + ship.getShipType(), "Ship Sunk");
                            currentPlayer.addShipSunk();
                        }
                        if (currentPlayer.hasWon())
                        {
                            MessageBox.Show("Congratulations, " + currentPlayer.getName() + " you won!!!!", "Game Over");
                            Close();
                        }
                    }
                }
            }
            btn.Enabled = false;
            if (!hit)
            {
                btn.BackColor = Color.Aqua;
                otherPlayerBoard[getRow(coordinates), getCol(coordinates)].BackColor = Color.Aqua;
                MessageBox.Show("Ship missed!!", "Miss");
            }
            if (playerNum == 1)
            {
                pnlGuessBoard_P1.Enabled = false;
            }
            else
            {
                pnlGuessBoard_P2.Enabled = false;
            }
        }

        public void PlaceShips(Button[,] shipBoard, Ship[] ships)
        {
            foreach(Ship ship in ships)
            {
                for(int i = 0; i < ship.getShipSize(); i++)
                {
                    shipBoard[ship.getCord()[i] / 9, ship.getCord()[i] % 9].BackColor = Color.DarkSlateGray;
                }
            }
        }

        private void btnDoneTurn_Click(object sender, EventArgs e)
        {
            pnlGuessBoard_P1.Enabled = true;
            pnlGuessBoard_P2.Enabled = true;
            btnDoneTurn.Enabled = false;

            if (playerNum == 1)
            {
                pnlGuessBoard_P1.Hide();
                pnlShipBoard_P1.Hide();
                pnlShipBoard_P2.Show();
                pnlGuessBoard_P2.Show();
                currentPlayer = playerTwo;
                otherPlayer = playerOne;
                playerNum = 2;
                lblPlayerXsTurn.Text = "It's " + playerTwo.getName() + "'s turn!";
            }
            else
            {
                pnlGuessBoard_P2.Hide();
                pnlShipBoard_P2.Hide();
                pnlShipBoard_P1.Show();
                pnlGuessBoard_P1.Show();
                currentPlayer = playerOne;
                otherPlayer = playerTwo;
                playerNum = 1;
                lblPlayerXsTurn.Text = "It's " + playerOne.getName() + "'s turn!";
            }
        }

        public int getRow(int tile) { return tile / 9; }
        public int getCol(int tile) { return tile % 9; }

        private void frmGameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
