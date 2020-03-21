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

        int[,] board = new int[9, 9];

        int cardCellWidth;
        int cardCellHeight;
        int barWidth = 3;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 0;
        int ycardUpperLeft = 0;
        int padding = 2;
        const int boardDimensions = 9; //X by X board size

        public frmGameBoard(Player playerOne, Player playerTwo)
        {
            InitializeComponent();
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            playerNum = 1;
            currentPlayer = playerOne;
            otherPlayer = playerTwo;
            DisplayBoards(board);
            PlaceShips(playerOne.getShipBoard(),playerOne.getShips());
            PlaceShips(playerTwo.getShipBoard(),playerTwo.getShips());

            pnlGuessBoard_P2.Hide();
            pnlShipBoard_P2.Hide();
            pnlShipBoard_P1.Show();
            pnlGuessBoard_P1.Show();
        }

        private void DisplayBoards(int[,] internalBoard)
        {
            //Create and assign shipBoards
            Button[,] p1shipBoard = GenerateBoard(internalBoard, pnlShipBoard_P1);
            Button[,] p2shipBoard = GenerateBoard(internalBoard, pnlShipBoard_P2);
            //Create and assign guessBoards
            Button[,] p1guessBoard = GenerateBoard(internalBoard, pnlGuessBoard_P1);
            Button[,] p2guessBoard = GenerateBoard(internalBoard, pnlGuessBoard_P2);

            //Give boards to player objects

            playerOne.setGuessBoard(p1guessBoard);
            playerOne.setShipBoard(p1shipBoard);
            playerTwo.setGuessBoard(p2guessBoard);
            playerTwo.setShipBoard(p2shipBoard);
        }

        private Button[,] GenerateBoard(int[,] internalBoard, Panel pnlBoard)
        {
            cardCellWidth = (pnlBoard.Size.Width / boardDimensions) - (padding);
            cardCellHeight = (pnlBoard.Size.Height / boardDimensions) - (padding);
            Size size = new Size(cardCellWidth, cardCellHeight);
            Point loc = new Point(0, 0);
            int x;
            int y;
            x = xcardUpperLeft;
            y = ycardUpperLeft;
            Button[,] board = new Button[boardDimensions, boardDimensions];
            //Top Line
            drawHorizBar(x, y, boardDimensions, pnlBoard);
            y = y + barWidth;

            //Button Start
            drawVertBar(x, y, pnlBoard);
            for (int row = 0; row<boardDimensions; row++)
            {
                loc.Y = row* (size.Height + padding);

                for (int col = 0; col<boardDimensions; col++)
                {
                    board[row,col] = new Button
                    {
                        Location = new Point(col* (size.Width + padding) + barWidth, loc.Y),
                        Size = size,
                        Font = new Font("Arial", 24, FontStyle.Bold),
                        Enabled = true
                    };

                    board[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    board[row, col].Tag = row.ToString() + "*" + col.ToString();
                    board[row, col].Name = "btn" + row.ToString() + col.ToString();
                    board[row, col].BackColor = Color.White;

                    //Associates the same event handler with each of the buttons generated
                    board[row, col].MouseClick += new MouseEventHandler(Button_MouseClick);

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

        private void Button_MouseClick(object sender, EventArgs e)
        {
            bool hit = false; ;
            Ship[] otherPlayerShips = otherPlayer.getShips();
            Button btn = (Button)sender;
            string[] IndividualCoords = btn.Tag.ToString().Split('*');
            string coordinates = btn.Tag.ToString();
            Button[,] myGuessBoard = currentPlayer.getGuessBoard();
            Button[,] otherPlayerBoard = otherPlayer.getShipBoard();
            foreach (Ship ship in otherPlayerShips)
            {
                List<string> shipCoords = ship.GetCords();
                foreach (string c in shipCoords)
                {
                    if (c == coordinates)
                    {
                        hit = true;
                        ship.Hit();
                        MessageBox.Show("Ship hit!!");
                        // Sets board color to show hit
                        btn.BackColor = Color.Red;
                        otherPlayerBoard[Int32.Parse(IndividualCoords[0]), Int32.Parse(IndividualCoords[1])].BackColor = Color.Red;

                        if (ship.IsShipSunk())
                        {
                            MessageBox.Show("You sunk the other player's " + ship.getShipType());
                            currentPlayer.addShipSunk();
                        }
                        if (currentPlayer.hasWon())
                        {
                            MessageBox.Show("Congratulations, " + currentPlayer.getName() + " you won!!!!");
                            Close();
                        }
                    }
                }
            }
            btn.Enabled = false;
            if (!hit)
            {
                btn.BackColor = Color.Aqua;
                otherPlayerBoard[Int32.Parse(IndividualCoords[0]), Int32.Parse(IndividualCoords[1])].BackColor = Color.Aqua;
                MessageBox.Show("Ship missed!!");
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
            foreach(Button btn in shipBoard)
            {
                foreach(Ship ship in ships)
                {
                    List<String> coords = ship.GetCords();
                    foreach(string cord in coords)
                    {
                        if (btn.Tag.ToString() == cord)
                        {
                            btn.BackColor = Color.DarkSlateGray;
                        }
                    }
                }
            }
        }

        private void btnDoneTurn_Click(object sender, EventArgs e)
        {
            pnlGuessBoard_P1.Enabled = true;
            pnlGuessBoard_P2.Enabled = true;

            if (playerNum == 1)
            {
                pnlGuessBoard_P1.Hide();
                pnlShipBoard_P1.Hide();
                pnlShipBoard_P2.Show();
                pnlGuessBoard_P2.Show();
                currentPlayer = playerTwo;
                otherPlayer = playerOne;
                playerNum = 2;
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
            }
        }
    }
}
