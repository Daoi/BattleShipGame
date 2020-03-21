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
        Button[,] board;
        Player playerOne;
        Player playerTwo;
        Player currentPlayer;
        int playerNum;
        int cardCellWidth;
        int cardCellHeight;
        int barWidth = 3;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 0;
        int ycardUpperLeft = 0;
        int padding = 2;
        const int boardDimensions = 9;//X by X board size
        Ship currentShip;
        InternalBoard currentInternalBoard;
        string[] currentCords = new string[2];
        int shipNumber;//Counter for ship list

        private void frmShipPlacement_Load(object sender, EventArgs e)
        {
            currentInternalBoard = new InternalBoard();
            currentShip = currentPlayer.getShips()[shipNumber];
            GenerateBoard(pnlShipPlacementBoard);
            lblCurrentPlayerPlacement.Text = currentPlayer.getName() + " place your ships.";
            lblCurrentShipName.Text = currentShip.getShipType() + " it has a lenght of " + currentShip.getShipSize().ToString();
            shipNumber = 0;

        }

        private Button[,] GenerateBoard(Panel pnlBoard)
        {
            cardCellWidth = (pnlBoard.Size.Width / boardDimensions) - (padding);
            cardCellHeight = (pnlBoard.Size.Height / boardDimensions) - (padding);
            Size size = new Size(cardCellWidth, cardCellHeight);
            Point loc = new Point(0, 0);
            int x;
            int y;
            x = xcardUpperLeft;
            y = ycardUpperLeft;
            board = new Button[boardDimensions, boardDimensions];
            //Top Line
            drawHorizBar(x, y, boardDimensions, pnlBoard);
            y = y + barWidth;

            //Button Start
            drawVertBar(x, y, pnlBoard);
            for (int row = 0; row < boardDimensions; row++)
            {
                loc.Y = row * (size.Height + padding);

                for (int col = 0; col < boardDimensions; col++)
                {
                    board[row, col] = new Button
                    {
                        Location = new Point(col * (size.Width + padding) + barWidth, loc.Y),
                        Size = size,
                        Font = new Font("Arial", 24, FontStyle.Bold),
                        Enabled = true
                    };

                    board[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    //int value = InternalBoardClass.getCellValue(row, col); Not implemented yet
                    int value = 0;
                    board[row, col].Text = value.ToString();
                    board[row, col].Tag = row.ToString() + "*" + col.ToString();
                    board[row, col].Name = "btn" + row.ToString() + col.ToString();
                    board[row, col].BackColor = Color.Aqua;


                    //Associates the same event handler with each of the buttons generated
                    board[row, col].MouseClick += new MouseEventHandler(Button_MouseClickPlacement);

                    // Add button to the form
                    pnlBoard.Controls.Add(board[row, col]);

                    // Draw vertical line                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x, y, pnlBoard);
                } // end for col
                // One row now complete

                // Draw bottom line
                x = xcardUpperLeft;
                y = y + cardCellHeight + padding;
                drawHorizBar(x, y - 6, boardDimensions, pnlBoard);
            }

            return board;
        }

        private void drawVertBar(int x, int y, Panel pnlBoard)
        {
            Color backColor = Color.Black;

            Label lblVertBar = new Label
            {
                BackColor = backColor,
                Location = new System.Drawing.Point(x, y),
                Name = "lblVertBar" + x.ToString(),
                Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding) * boardDimensions),
                TabIndex = 1000
            };
            pnlBoard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }

        private void drawHorizBar(int x, int y, int cardSize, Panel pnlBoard)
        {
            Color backColor = Color.Black;
            Label lblHorizBar = new Label
            {
                BackColor = backColor,
                Location = new System.Drawing.Point(x, y),
                Name = "lblHorizBar" + y.ToString(),
                Size = new System.Drawing.Size((cardCellWidth + padding) * cardSize, barWidth),
                TabIndex = 1000
            };



            pnlBoard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            x = x + cardCellWidth;
        }

        //Board Creation End
        //
        //
        //

        private void Button_MouseClickPlacement(object sender, EventArgs e)
        {
            btnPlaceDown.Enabled = false;
            btnPlaceLeft.Enabled = false;
            btnPlaceUp.Enabled = false;
            btnPlaceRight.Enabled = false;

            Button btn = (Button)sender;
            int shipSize = currentShip.getShipSize();
            currentCords = btn.Tag.ToString().Split('*');
            StringBuilder sb = new StringBuilder("You can place your ship in the following orientations:"); 
            //Up orientation
            if (currentInternalBoard.checkUp(int.Parse(currentCords[0]), int.Parse(currentCords[1]), shipSize))
            {
                btnPlaceUp.Enabled = true;
                sb.Append(" Up,");
            }
            //Left orientation
            if (currentInternalBoard.checkLeft(int.Parse(currentCords[0]), int.Parse(currentCords[1]), shipSize))
            {
                btnPlaceLeft.Enabled = true;
                sb.Append(" Left,");
            }
            //Right orientation
            if (currentInternalBoard.checkRight(int.Parse(currentCords[0]), int.Parse(currentCords[1]), shipSize))
            {
                btnPlaceRight.Enabled = true;
                sb.Append(" Right,");

            }
            //Down orientation
            if (currentInternalBoard.checkDown(int.Parse(currentCords[0]), int.Parse(currentCords[1]), shipSize))
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
            if (shipNumber == 5)
            {
                btnNextShip.Text = "Next Player";
                btnNextShip.BackColor = Color.LawnGreen;
            }
            if (shipNumber == 5 && playerNum == 2)
            {
                btnNextShip.Text = "Play Game!";
                btnNextShip.BackColor = Color.Red;
            }

            int row = int.Parse(currentCords[0]);
            int col = int.Parse(currentCords[1]);
            int size = currentShip.getShipSize();
            List<string> shipCords = new List<string>();
            for (int i = col; i != (col-(size)); i-- )
            {
                currentInternalBoard.placeShip(row, i);
                board[row, i].BackColor = Color.DarkGray;
                shipCords.Add(row + "*" + i);
            }
            currentShip.setCords(shipCords);
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
            }

            int row = int.Parse(currentCords[0]);
            int col = int.Parse(currentCords[1]);
            int size = currentShip.getShipSize();
            List<string> shipCords = new List<string>();
            for (int i = col; i != (col + (size)); i++)
            {
                currentInternalBoard.placeShip(row, i);
                board[row, i].BackColor = Color.DarkGray;
                shipCords.Add(row + "*" + i);
            }
            currentShip.setCords(shipCords);
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
            }

            int row = int.Parse(currentCords[0]);
            int col = int.Parse(currentCords[1]);
            int size = currentShip.getShipSize();
            List<string> shipCords = new List<string>();
            for (int i = row; i != (row - (size)); i--)
            {
                currentInternalBoard.placeShip(i, col);
                board[i, col].BackColor = Color.DarkGray;
                shipCords.Add(i + "*" + col);
            }
            currentShip.setCords(shipCords);
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
            }

            int row = int.Parse(currentCords[0]);
            int col = int.Parse(currentCords[1]);
            int size = currentShip.getShipSize();
            List<string> shipCords = new List<string>();
            for (int i = row; i != (row + (size)); i++)
            {
                currentInternalBoard.placeShip(i, col);
                board[i, col].BackColor = Color.DarkGray;
                shipCords.Add(i + "*" + col);
            }
            currentShip.setCords(shipCords);
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
                    Close();
                }
                else
                {
                    frmShipPlacement secondPlayerPlacement = new frmShipPlacement(playerOne, playerTwo, 2);
                    Hide();
                    secondPlayerPlacement.Show();
                    Close();
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
    }
}
