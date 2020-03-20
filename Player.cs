using System.Windows.Forms;

namespace BattleShipGame
{
    public class Player
    {
        const int numberOfShips = 5;
        private Button[,] guessBoard = new Button[9, 9];
        private Button[,] shipBoard = new Button[9, 9];
        private string name;
        private InternalBoard internalBoard = new InternalBoard();
        private int ShipSunkCounter;
        private Ship[] ships = new Ship[5];


        public Player(string name)
        {
            this.name = name;
            ships[0] = new Ship("Carrier", 5);
            ships[1] = new Ship("Battleship", 4);
            ships[2] = new Ship("Submarine", 3);
            ships[3] = new Ship("Cruiser", 3);
            ships[4] = new Ship("Destroyer", 2);
        }

        public Button[,] getGuessBoard()
        {
            return guessBoard;
        }

        public Button[,] getShipBoard()
        {
            return shipBoard;
        }

        public bool hasWon()
        {
            return ShipSunkCounter == numberOfShips;
        }

        public void setGuessBoard(Button[,] gb)
        {
            guessBoard = gb;
        }

        public void setShipBoard(Button[,] sb)
        {
            shipBoard = sb;
        }

        public void setInternalBoard(InternalBoard ib)
        {
            internalBoard = ib;
        }

        public InternalBoard getInternalBoard()
        {
            return internalBoard;
        }

        public string getName()
        {
            return name;
        }

        public Ship[] getShips()
        {
            return ships;
        }
    }
}