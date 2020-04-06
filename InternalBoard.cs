// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// April 5th, 2020
// Project 3 - Battleship

namespace BattleShipGame
{
    // Class that models the internal 2D board array, used during ship placement to track where player's place ships
    public class InternalBoard
    {
        private int[,] board;

        // InternalBoard constructor
        public InternalBoard()
        {
            board = new int[9, 9];
        }

        // Method that marks ship location in array from row and column
        public void placeShip(int row, int col)
        {
            board[row, col] = 1;
        }

        // Method that checks for valid ship placement in left direction
        public bool checkLeft(int row, int col, int size)
        {
            // Checks that ship isn't being placed into negative index on board
            if ((col - (size - 1)) < 0)
            {
                return false;
            }
            // Checks that ship isn't already placed in any of the cells
            for(int i = col; i > (col - size); i--)
            {
                if(board[row, i] == 1)
                {
                    return false;
                }
            }
            return true;
        }

        // Method that checks for valid ship placement in right direction
        public bool checkRight(int row, int col, int size)
        {
            // Checks that ship isn't being placed into index larger than the board
            if ((col + (size - 1)) > 8)
            {
                return false;
            }
            // Checks that ship isn't already placed in any of the cells
            for (int i = col; i < (col + size); i++)
            {
                if (board[row, i] == 1)
                {
                    return false;
                }
            }
            return true;
        }

        // Method that checks for valid ship placement in down direction
        public bool checkDown(int row, int col, int size)
        {
            // Checks that ship isn't being placed into index larger than the board
            if ((row + (size - 1)) > 8)
            {
                return false;
            }
            // Checks that ship isn't already placed in any of the cells
            for (int i = row; i < (row + size); i++)
            {
                if (board[i, col] == 1)
                {
                    return false;
                }
            }
            return true;
        }

        // Method that checks for valid ship placement in up direction
        public bool checkUp(int row, int col, int size)
        {
            // Checks that ship isn't being placed into negative index on board
            if ((row - (size - 1)) < 0)
            {
                return false;
            }
            // Checks that ship isn't already placed in any of the cells
            for (int i = row; i > (row - size); i--)
            {
                if (board[i, col] == 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}