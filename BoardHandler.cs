using System;
using System.Drawing;
using System.Windows.Forms;

namespace BattleShipGame
{
    internal class BoardHandler
    {
        static Button[,] board;
        static int cardCellWidth;
        static int cardCellHeight;
        const int barWidth = 3;  // Width or thickness of horizontal and vertical bars
        const int xcardUpperLeft = 0;
        const int ycardUpperLeft = 0;
        const int padding = 2;
        const int boardDimensions = 9; //X by X board size

        public static Button[,] GenerateBoard(Panel pnlBoard, Action<object, EventArgs> mouseClick)
        {
            cardCellWidth = (pnlBoard.Size.Width / boardDimensions) - (padding);
            cardCellHeight = (pnlBoard.Size.Height / boardDimensions) - (padding);
            Size size = new Size(cardCellWidth, cardCellHeight);
            Point loc = new Point(0, 0);
            int x = 0;
            int y = 0;
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
                    //board[row, col].Tag = row.ToString() + "*" + col.ToString();
                    board[row, col].Tag = ((row * boardDimensions) + col).ToString();
                    board[row, col].Name = "btn" + row.ToString() + col.ToString();
                    board[row, col].BackColor = Color.White;

                    //Associates the same event handler with each of the buttons generated
                    board[row, col].MouseClick += new MouseEventHandler(mouseClick);

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

        public static void drawVertBar(int x, int y, Panel pnlBoard)
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

        public static void drawHorizBar(int x, int y, int cardSize, Panel pnlBoard)
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
    }
}