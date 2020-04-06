using System.Collections.Generic;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// April 5th, 2020
// Project 3 - Battleship

namespace BattleShipGame
{
    // Class that models the ships
    public class Ship
    {
        //To get the number for the cords array, e.g. for the position [5,6] You do the first ((first index - 1) * 9) + the second index. 
        //e.g. (4*9) + 6 = 42. 42 is the number we add to the array we give to the ship for its location.  
        private List<int> cord;
        private int size;
        private int hits;
        private string shipType; //Can store what type of ship something is(e.g. carrier), might be useful down the line
        //2 = Destroyer, 3 = Submarine or Cruiser, 4 = Battleship, 5 = Carrier
        
        // Ship class constructor
        public Ship(string type, int size)
        {
            this.size = size;
            hits = 0;
            shipType = type;
            cord = new List<int>(size);

        }

        // Method that checks if the ship is sunk
        public bool IsShipSunk()
        {
            return hits == size;
        }

        // Method that increments hit counter
        public void Hit()
        {
            hits++;
        }

        // Method that adds a ship coordinates to coordinate list
        public void setCord(int cord)
        {
            this.cord.Add(cord);
        }

        // Getter for coordinate list
        public List<int> getCord()
        {
            return cord;
        }
        // Getter for ship type string
        public string getShipType()
        {
            return shipType;
        }
        // Getter for ship size
        public int getShipSize()
        {
            return size;
        }
    }
}