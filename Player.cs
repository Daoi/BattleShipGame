using System.Windows.Forms;

namespace BattleShipGame
{
    public class Player
    {
        const int numberOfShips = 5;
        private Button[,] guessBoard;
        private Button[,] shipBoard;
        private string name;
        private int ShipSunkCounter = 0;
        private Ship[] ships = new Ship[5];

        // Player class constructor
        // Assigns player name and creates ship array with all ships
        public Player(string name)
        {
            this.name = name;
            ships[0] = new Ship("Carrier", 5);
            ships[1] = new Ship("Battleship", 4);
            ships[2] = new Ship("Submarine", 3);
            ships[3] = new Ship("Cruiser", 3);
            ships[4] = new Ship("Destroyer", 2);
        }

        // Method that increments ship sunk counter
        public void addShipSunk()
        {
            ShipSunkCounter++;
        }

        // Getter for players guessboard
        public Button[,] getGuessBoard()
        {
            return guessBoard;
        }

        // Getter for players ship board
        public Button[,] getShipBoard()
        {
            return shipBoard;
        }

        // Method that checks if player has won
        public bool hasWon()
        {
            return ShipSunkCounter == numberOfShips;
        }

        // Setter for guess board
        public void setGuessBoard(Button[,] gb)
        {
            guessBoard = gb;
        }

        // Setter for ship board
        public void setShipBoard(Button[,] sb)
        {
            shipBoard = sb;
        }

        // Getter for player name
        public string getName()
        {
            return name;
        }

        // Getter for ship array
        public Ship[] getShips()
        {
            return ships;
        }
    }
}