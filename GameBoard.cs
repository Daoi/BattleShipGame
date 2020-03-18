﻿using System;
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
    public partial class frmGameBoard : Form
    {
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

        public frmGameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            DisplayBoards(testBoard);
        }

        private void DisplayBoards(int[,] internalBoard)
        {
            //Create shipBoard
            Button[,] shipBoard = GenerateBoard(internalBoard, pnlShipBoard);
            //Create guessBoard
            Button[,] guessBoard = GenerateBoard(internalBoard, pnlGuessBoard);
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
            if (x == 300 || x == 600)
            {
                backColor = Color.Red;
            }

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
            if (y == 204 || y == 411)
            {
                backColor = Color.Red;
            }

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

        private void lblShipBoard_Click(object sender, EventArgs e)
        {

        }

        private void pnlShipBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        //Board Creation End



    }
}