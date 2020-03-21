using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace BattleShipGame
{
    public partial class frmGameBoard : Form
    {
        Player currentPlayer;
        Player playerOne;
        Player playerTwo;

        Button[,] shipBoard;
        Button[,] guessBoard;
        static int[] testShipCords = { 41, 42, 43, 44, 45 };
        //Ship ship = new Ship(testShipCords, "Carrier");
        int cardCellWidth;
        int cardCellHeight;
        int barWidth = 3;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 0;
        int ycardUpperLeft = 0;
        int padding = 2;
        const int boardDimensions = 9;//X by X board size
        int[,] testBoard = new int[,] { { 0, 0, 0, 1, 1, 1, 0, 0, 0 }, 
                                        { 0, 0, 0, 1, 1, 1, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 1, 0, 0 }, 
                                        { 0, 0, 1, 1, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 1, 1, 0, 0, 0 }, 
                                        { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

        public frmGameBoard(Player playerOne, Player playerTwo)
        {
            InitializeComponent();
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            DisplayBoards(testBoard);
            Ship[] p1Ships = playerOne.getShips();
            foreach (Ship ship in p1Ships)
            {
                string cords = "P1 SHIP CORDS: ";
                List<string> shipCords = ship.GetCords();
                foreach (String cord in shipCords)
                {
                    cords += cord + " ";
                }
                MessageBox.Show(cords);
            }
        }

        private void DisplayBoards(int[,] internalBoard)
        {
            //Create shipBoard
            shipBoard = GenerateBoard(internalBoard, pnlShipBoard);
            //Create guessBoard
            guessBoard = GenerateBoard(internalBoard, pnlGuessBoard);
            //Give boards to player object
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
                    //int value = InternalBoardClass.getCellValue(row, col); Not implemented yet
                    int value = internalBoard[row, col];
                    board[row, col].Text = value.ToString();
                    board[row, col].Tag = value.ToString();
                    board[row, col].Name = "btn" + row.ToString() + col.ToString();
                    board[row, col].BackColor = Color.Aqua;


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

        private void Button_MouseClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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

        //Set the backcolor for the tiles to grey if there is a ship there(Only on the ship board)
        //Set the backcolor for the tiles to red if there is a hit marked there(On both boards)
        //Set the backcolor for the tiles to white if there is a miss marked there(On both boards)
        //Red/White markers on the ship board represent the other players hits/misses. Grey represents current players ships.
        //Red/white markers on the guess board represent the current players hit/misses
        //When handle hits/misses etc we just need to change the btn's tag value. E.g. Player 1 clicks on guessBoard[2,2] and its a miss
        //so set Player 1s guessBoard[2,2].Tag = 3 and Player 2s shipBoard[2,2].Tag = 3
        public void DisplayShips()
        {
            foreach(Button btn in shipBoard)
            {
                if((string)btn.Tag == "1") {//Ship
                    btn.BackColor = Color.DarkGray;
                }
                else if((string)btn.Tag == "2"){//Hits
                    btn.BackColor = Color.Red;
                }
                else if ((string)btn.Tag == "3")//Miss
                {
                    btn.BackColor = Color.White;
                }
            }

            foreach(Button btn in guessBoard)
            {
                if((string)btn.Tag == "2")//Hits
                {
                    btn.BackColor = Color.Red;
                }
                else if ((string)btn.Tag == "3")//Miss
                {
                    btn.BackColor = Color.White;
                }
            }
        }
        //Use this to set a buttons tag to its new status after a hit/miss
        //Value represents the new state. (2 = Hit, 3 = Miss) btn is the tile that was clicked/guessed.
        public void updateTileStatus(Button btn, string value)
        {
            btn.Tag = value;
        }


        private void btnDoneTurn_Click(object sender, EventArgs e)
        {
            DisplayShips();
            
        }
    }
}
