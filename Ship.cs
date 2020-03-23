using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BattleShipGame
{
    public class Ship
    {
        //To get the number for the cords array, e.g. for the position [5,6] You do the first ((first index - 1) * 9) + the second index. 
        //e.g. (4*9) + 6 = 42. 42 is the number we add to the array we give to the ship for its location.  
        private List<int> cord;
        private List<string> cords;
        private int size;
        private int hits;
        private string shipType;//Can store what type of ship something is(e.g. carrier), might be useful down the line
        //2 = Destroyer, 3 = Submarine or Cruiser, 4 = Battleship, 5 = Carrier
        
        public Ship(string type, int size)
        {
            this.size = size;
            hits = 0;
            shipType = type;
            cords = new List<string>();
            cord = new List<int>(size);

        }

        public bool IsShipSunk()
        {
            return hits == size;
        }

        public void Hit()
        {
            hits++;
        }

        public int[] getIndex(int tile)
        {
            //indices[0] = row index, indices[1] = col index.
            int[] index = { tile / 9, tile % 9 };
            MessageBox.Show("row index: " + index[0].ToString() + " col index:" + index[1].ToString());//For illustration
            return index;
        }

        public void setCords(List<string> cords) 
        {
            this.cords = cords;
        }

        public List<string> GetCords()
        {
            return cords;
        }

        public void setCord(int cord)
        {
            this.cord.Add(cord);
        }

        public List<int> getCord()
        {
            return cord;
        }


        public string getShipType()
        {
            return shipType;
        }
        public int getShipSize()
        {
            return size;
        }
    }
}