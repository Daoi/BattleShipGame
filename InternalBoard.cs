namespace BattleShipGame
{
    public class InternalBoard
    {
        int[,] board;

        public InternalBoard()
        {
            board = new int[9, 9];
        }

        public void placeShip(int row, int col)
        {
            board[row, col] = 1;
        }

        public bool checkLeft(int row, int col, int size)
        {
            if ((col - (size - 1)) < 0)
                return false;
            for(int i = col; i > (col- (size - 1)); i--)
            {
                if(board[row, i] == 1)
                {
                    return false;
                }
            }
            return true;
        }
        //4,4 size = 5 |4 5 6 7 8
        public bool checkRight(int row, int col, int size)
        {
            if ((col + (size-1)) > 9)
                return false;
            for (int i = col; i < (col+(size-1)); i++)
            {
                if (board[row, i] == 1)
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkDown(int row, int col, int size)
        {
            if ((row + (size - 1)) > 9)
                return false;
            for (int i = row; i < (row+(size-1)); i++)
            {
                if (board[i, col] == 1)
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkUp(int row, int col, int size)
        {
            if ((row - (size - 1)) < 0)
                return false;
            for (int i = row; i > (row- (size - 1)); i--)
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