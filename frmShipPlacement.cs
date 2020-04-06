using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// April 5th, 2020
// Project 3 - Battleship

namespace BattleShipGame
{
    public partial class frmShipPlacement : Form
    {
        // Form variables for use in placing ships
        Button[,] board; // Button array that build physical board on form
        Player playerOne;
        Player playerTwo;
        Player currentPlayer; // Additional reference to Player object of current player placing
        int playerNum; // Used to track which player is currently placing
        Ship currentShip; // The ship the player is currently placing
        InternalBoard currentInternalBoard; // For tracking ship placements
        int currentCords; // Gets assigned to coordinates of cell that's clicked when placing ships
        int shipNumber; //Counter for ship list, used as index in ship array and tracks if all ships have been placed

        // Form constructor, gets passed both player objects and player that's currently picking
        public frmShipPlacement(Player one, Player two, int currentPlayer)
        {
            InitializeComponent();
            playerNum = currentPlayer;
            this.playerOne = one;
            this.playerTwo = two;
            if(currentPlayer == 1)
            {
                this.currentPlayer = one;
            }
            else
            {
                this.currentPlayer = two;
            }
        }

        // Load event handler, instantiates certain form variables needed during ship placement
        // Creates physical placement board for user, and displays useful info on form
        private void frmShipPlacement_Load(object sender, EventArgs e)
        {
            currentInternalBoard = new InternalBoard();
            currentShip = currentPlayer.getShips()[shipNumber];
            board = BoardHandler.GenerateBoard(pnlShipPlacementBoard, Button_MouseClickPlacement);
            lblCurrentPlayerPlacement.Text = currentPlayer.getName() + " place your ships.";
            lblCurrentShipName.Text = currentShip.getShipType() + ", it has a length of " + currentShip.getShipSize().ToString();
            shipNumber = 0;
        }

              
        // Method for handling clicking on a board cell to place ship origin point
        // Checks all 4 orientations as valid placement options, enables buttons accordingly
        private void Button_MouseClickPlacement(object sender, EventArgs e)
        {
            btnPlaceDown.Enabled = false;
            btnPlaceLeft.Enabled = false;
            btnPlaceUp.Enabled = false;
            btnPlaceRight.Enabled = false;

            Button btn = (Button)sender;
            int shipSize = currentShip.getShipSize();
            currentCords = int.Parse(btn.Tag.ToString());

            StringBuilder sb = new StringBuilder("You can place your ship in the following orientations:"); 


            // Checks up orientation for valid placement
            if (currentInternalBoard.checkUp(getRow(currentCords), getCol(currentCords), shipSize))
            {
                btnPlaceUp.Enabled = true;
                sb.Append(" Up,");
            }
            // Checks left orientation for valid placement
            if (currentInternalBoard.checkLeft(getRow(currentCords), getCol(currentCords), shipSize))
            {
                btnPlaceLeft.Enabled = true;
                sb.Append(" Left,");
            }
            // Checks right orientation for valid placement
            if (currentInternalBoard.checkRight(getRow(currentCords), getCol(currentCords), shipSize))
            {
                btnPlaceRight.Enabled = true;
                sb.Append(" Right,");
            }
            // Checks down orientation for valid placement
            if (currentInternalBoard.checkDown(getRow(currentCords), getCol(currentCords), shipSize))
            {
                btnPlaceDown.Enabled = true;
                sb.Append(" Down,");
            }
            MessageBox.Show(sb.ToString().TrimEnd(','),"Valid Orientations");
        }

        // Method for clicking button to place ship left
        private void btnPlaceLeft_Click(object sender, EventArgs e)
        {
            shipNumber++;
            btnPlaceDown.Enabled = false;
            btnPlaceRight.Enabled = false;
            btnPlaceUp.Enabled = false;
            btnPlaceLeft.Enabled = false;
            if (shipNumber == 5)
            {
                // Change next ship button to notify that it's the next player's turn
                btnNextShip.Text = "Next Player";
                btnNextShip.BackColor = Color.LawnGreen;
            }
            if (shipNumber == 5 && playerNum == 2)
            {
                // Change next ship button to notify that it's time to play the game
                btnNextShip.Text = "Play Game!";
                btnNextShip.BackColor = Color.Red;
                btnNextShip.ForeColor = Color.White;
            }
            // Get row and column index of clicked origin cell, then place ship in left direction
            int row = getRow(currentCords);
            int col = getCol(currentCords);
            int size = currentShip.getShipSize();
            for (int i = col; i != (col-(size)); i-- )
            {
                // Places ship at each cell on board, changes cells color, and adds coordinate to ship object
                currentInternalBoard.placeShip(row, i);
                board[row, i].BackColor = Color.DarkSlateGray;
                currentShip.setCord(getCellNumber(row, i));
            }
            pnlShipPlacementBoard.Enabled = false;
            btnNextShip.Enabled = true;
        }

        // Method for clicking button to place ship right
        private void btnPlaceRight_Click(object sender, EventArgs e)
        {
            shipNumber++;
            btnPlaceDown.Enabled = false;
            btnPlaceLeft.Enabled = false;
            btnPlaceUp.Enabled = false;
            btnPlaceRight.Enabled = false;
            if (shipNumber == 5)
            {
                // Change next ship button to notify that it's the next player's turn
                btnNextShip.Text = "Next Player";
                btnNextShip.BackColor = Color.LawnGreen;
            }
            if (shipNumber == 5 && playerNum == 2)
            {
                // Change next ship button to notify that it's time to play the game
                btnNextShip.Text = "Play Game!";
                btnNextShip.BackColor = Color.Red;
                btnNextShip.ForeColor = Color.White;
            }
            // Get row and column index of clicked origin cell, then place ship in right direction
            int row = getRow(currentCords);
            int col = getCol(currentCords);
            int size = currentShip.getShipSize();
            for (int i = col; i != (col + (size)); i++)
            {
                // Places ship at each cell on board, changes cells color, and adds coordinate to ship object
                currentInternalBoard.placeShip(row, i);
                board[row, i].BackColor = Color.DarkSlateGray;
                currentShip.setCord(getCellNumber(row, i));
            }
            pnlShipPlacementBoard.Enabled = false;
            btnNextShip.Enabled = true;
        }

        // Method for clicking button to place ship up
        private void btnPlaceUp_Click(object sender, EventArgs e)
        {
            shipNumber++;
            btnPlaceDown.Enabled = false;
            btnPlaceRight.Enabled = false;
            btnPlaceLeft.Enabled = false;
            btnPlaceUp.Enabled = false;
            if (shipNumber == 5)
            {
                // Change next ship button to notify that it's the next player's turn
                btnNextShip.Text = "Next Player";
                btnNextShip.BackColor = Color.LawnGreen;
            }
            if (shipNumber == 5 && playerNum == 2)
            {
                // Change next ship button to notify that it's time to play the game
                btnNextShip.Text = "Play Game!";
                btnNextShip.BackColor = Color.Red;
                btnNextShip.ForeColor = Color.White;
            }
            // Get row and column index of clicked origin cell, then place ship in up direction
            int row = getRow(currentCords);
            int col = getCol(currentCords);
            int size = currentShip.getShipSize();
            for (int i = row; i != (row - (size)); i--)
            {
                // Places ship at each cell on board, changes cells color, and adds coordinate to ship object
                currentInternalBoard.placeShip(i, col);
                board[i, col].BackColor = Color.DarkSlateGray;
                currentShip.setCord(getCellNumber(i,col));

            }
            pnlShipPlacementBoard.Enabled = false;
            btnNextShip.Enabled = true;
        }

        // Method for clicking button to place ship down
        private void btnPlaceDown_Click(object sender, EventArgs e)
        {
            shipNumber++;
            btnPlaceRight.Enabled = false;
            btnPlaceLeft.Enabled = false;
            btnPlaceUp.Enabled = false;
            btnPlaceDown.Enabled = false;
            if (shipNumber == 5)
            {
                // Change next ship button to notify that it's the next player's turn
                btnNextShip.Text = "Next Player";
                btnNextShip.BackColor = Color.LawnGreen;
            }
            if (shipNumber == 5 && playerNum == 2)
            {
                // Change next ship button to notify that it's time to play the game
                btnNextShip.Text = "Play Game!";
                btnNextShip.BackColor = Color.Red;
                btnNextShip.ForeColor = Color.White;
            }
            // Get row and column index of clicked origin cell, then place ship in down direction
            int row = getRow(currentCords);
            int col = getCol(currentCords);
            int size = currentShip.getShipSize();
            for (int i = row; i != (row + (size)); i++)
            {
                // Places ship at each cell on board, changes cells color, and adds coordinate to ship object
                currentInternalBoard.placeShip(i, col);
                board[i, col].BackColor = Color.DarkSlateGray;
                currentShip.setCord(getCellNumber(i, col));

            }
            pnlShipPlacementBoard.Enabled = false;
            btnNextShip.Enabled = true;
        }

        // Method for clicking next ship button
        private void btnNextShip_Click(object sender, EventArgs e)
        {
            if(shipNumber == 5)
            // placed all ships, time to load next player placement form or game play form
            {
                if (playerNum == 2)
                {
                    // Both players have placed ships, move onto game form
                    frmGameBoard gameBoard = new frmGameBoard(playerOne, playerTwo);
                    Hide();
                    gameBoard.Show();
                }
                else
                {
                    // First player has placed ships, load ship placement form for player 2 this time
                    frmShipPlacement secondPlayerPlacement = new frmShipPlacement(playerOne, playerTwo, 2);
                    Hide();
                    secondPlayerPlacement.Show();
                }
            }
            else
            {
                // Current player not placed all ships yet, keep placing
                pnlShipPlacementBoard.Enabled = true;
                currentShip = currentPlayer.getShips()[shipNumber];
                lblCurrentShipName.Text = currentShip.getShipType() + " it has a lenght of " + currentShip.getShipSize().ToString();
                btnNextShip.Enabled = false;
            }
        }

        // Methods used to get row and column of board cell from cell number
        // Or get cell number from row and column of board cell
        public int getRow(int cellNumber) { return cellNumber / 9; }
        public int getCol(int cellNumber) { return cellNumber % 9; }
        public int getCellNumber(int row, int col) { return ((row * 9) + col); }

        // Exits application on form close
        private void frmShipPlacement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
