using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShipGame
{
    public partial class frmShipPlacement : Form
    {
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

        frmWelcome welcome;
        Button[,] board;
        Player playerOne;
        Player playerTwo;
        Player currentPlayer;
        int playerNum;
        const int boardDimensions = 9; //X by X board size
        Ship currentShip;
        InternalBoard currentInternalBoard;
        int currentCords;
        int shipNumber; //Counter for ship list

        private void frmShipPlacement_Load(object sender, EventArgs e)
        {
            currentInternalBoard = new InternalBoard();
            currentShip = currentPlayer.getShips()[shipNumber];
            board = BoardHandler.GenerateBoard(pnlShipPlacementBoard, Button_MouseClickPlacement);
            lblCurrentPlayerPlacement.Text = currentPlayer.getName() + " place your ships.";
            lblCurrentShipName.Text = currentShip.getShipType() + ", it has a length of " + currentShip.getShipSize().ToString();
            shipNumber = 0;
        }

              
        //Method for handling clicking on a grid to place origin there.
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


            //Up orientation
            if (currentInternalBoard.checkUp(getRow(currentCords), getCol(currentCords), shipSize))
            {
                btnPlaceUp.Enabled = true;
                sb.Append(" Up,");
            }
            //Left orientation
            if (currentInternalBoard.checkLeft(getRow(currentCords), getCol(currentCords), shipSize))
            {
                btnPlaceLeft.Enabled = true;
                sb.Append(" Left,");
            }
            //Right orientation
            if (currentInternalBoard.checkRight(getRow(currentCords), getCol(currentCords), shipSize))
            {
                btnPlaceRight.Enabled = true;
                sb.Append(" Right,");
            }
            //Down orientation
            if (currentInternalBoard.checkDown(getRow(currentCords), getCol(currentCords), shipSize))
            {
                btnPlaceDown.Enabled = true;
                sb.Append(" Down,");
            }
            MessageBox.Show(sb.ToString().TrimEnd(','),"Valid Orientations");
        }

        private void btnPlaceLeft_Click(object sender, EventArgs e)
        {
            btnPlaceDown.Enabled = false;
            btnPlaceRight.Enabled = false;
            btnPlaceUp.Enabled = false;
            btnPlaceLeft.Enabled = false;
            shipNumber++;
            Button btn = (Button)sender;
            if (shipNumber == 5)
            {
                btnNextShip.Text = "Next Player";
                btnNextShip.BackColor = Color.LawnGreen;
            }
            if (shipNumber == 5 && playerNum == 2)
            {
                btnNextShip.Text = "Play Game!";
                btnNextShip.BackColor = Color.Red;
                btnNextShip.ForeColor = Color.White;
            }

            int row = getRow(currentCords);
            int col = getCol(currentCords);
            int size = currentShip.getShipSize();
            for (int i = col; i != (col-(size)); i-- )
            {
                currentInternalBoard.placeShip(row, i);
                board[row, i].BackColor = Color.DarkSlateGray;
                currentShip.setCord(getTile(row, i));
            }
            pnlShipPlacementBoard.Enabled = false;
            btnNextShip.Enabled = true;
        }

        private void btnPlaceRight_Click(object sender, EventArgs e)
        {
            btnPlaceDown.Enabled = false;
            btnPlaceLeft.Enabled = false;
            btnPlaceUp.Enabled = false;
            btnPlaceRight.Enabled = false;
            shipNumber++;
            if (shipNumber == 5)
            {
                btnNextShip.Text = "Next Player";
                btnNextShip.BackColor = Color.LawnGreen;
            }
            if (shipNumber == 5 && playerNum == 2)
            {
                btnNextShip.Text = "Play Game!";
                btnNextShip.BackColor = Color.Red;
                btnNextShip.ForeColor = Color.White;
            }

            int row = getRow(currentCords);
            int col = getCol(currentCords);
            int size = currentShip.getShipSize();
            for (int i = col; i != (col + (size)); i++)
            {
                currentInternalBoard.placeShip(row, i);
                board[row, i].BackColor = Color.DarkSlateGray;
                currentShip.setCord(getTile(row, i));
            }
            pnlShipPlacementBoard.Enabled = false;
            btnNextShip.Enabled = true;
        }

        private void btnPlaceUp_Click(object sender, EventArgs e)
        {
            btnPlaceDown.Enabled = false;
            btnPlaceRight.Enabled = false;
            btnPlaceLeft.Enabled = false;
            btnPlaceUp.Enabled = false;
            shipNumber++;
            if (shipNumber == 5)
            {
                btnNextShip.Text = "Next Player";
                btnNextShip.BackColor = Color.LawnGreen;
            }
            if (shipNumber == 5 && playerNum == 2)
            {
                btnNextShip.Text = "Play Game!";
                btnNextShip.BackColor = Color.Red;
                btnNextShip.ForeColor = Color.White;
            }

            int row = getRow(currentCords);
            int col = getCol(currentCords);
            int size = currentShip.getShipSize();
            for (int i = row; i != (row - (size)); i--)
            {
                currentInternalBoard.placeShip(i, col);
                board[i, col].BackColor = Color.DarkSlateGray;
                currentShip.setCord(getTile(i,col));

            }
            pnlShipPlacementBoard.Enabled = false;
            btnNextShip.Enabled = true;
        }

        private void btnPlaceDown_Click(object sender, EventArgs e)
        {
            btnPlaceRight.Enabled = false;
            btnPlaceLeft.Enabled = false;
            btnPlaceUp.Enabled = false;
            btnPlaceDown.Enabled = false;
            shipNumber++;
            if (shipNumber == 5)
            {
                btnNextShip.Text = "Next Player";
                btnNextShip.BackColor = Color.LawnGreen;
            }
            if (shipNumber == 5 && playerNum == 2)
            {
                btnNextShip.Text = "Play Game!";
                btnNextShip.BackColor = Color.Red;
                btnNextShip.ForeColor = Color.White;
            }

            int row = getRow(currentCords);
            int col = getCol(currentCords);
            int size = currentShip.getShipSize();
            for (int i = row; i != (row + (size)); i++)
            {
                currentInternalBoard.placeShip(i, col);
                board[i, col].BackColor = Color.DarkSlateGray;
                currentShip.setCord(getTile(i, col));

            }
            pnlShipPlacementBoard.Enabled = false;
            btnNextShip.Enabled = true;
        }

        private void btnNextShip_Click(object sender, EventArgs e)
        {
            // placed all ships, next player or next form
            if(shipNumber == 5)
            {
                if (playerNum != 1)
                {
                    frmGameBoard gameBoard = new frmGameBoard(playerOne, playerTwo);
                    Hide();
                    gameBoard.Show();
                }
                else
                {
                    frmShipPlacement secondPlayerPlacement = new frmShipPlacement(playerOne, playerTwo, 2);
                    Hide();
                    secondPlayerPlacement.Show();
                }
            }
            else
            {
                // Not placed all ships yet, keep going
                pnlShipPlacementBoard.Enabled = true;
                currentShip = currentPlayer.getShips()[shipNumber];
                lblCurrentShipName.Text = currentShip.getShipType() + " it has a lenght of " + currentShip.getShipSize().ToString();
                btnNextShip.Enabled = false;
            }
        }

        public int getRow(int tile) { return tile / 9; }
        public int getCol(int tile) { return tile % 9; }
        public int getTile(int row, int col) { return ((row * 9) + col); }

        private void frmShipPlacement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
