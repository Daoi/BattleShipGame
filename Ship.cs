using System.Drawing;
using System.Windows.Forms;

namespace BattleShipGame
{
    internal class Ship
    {
        //To get the number for the cords array, e.g. for the position [5,6] You do the first ((first index - 1) * 9) + the second index. 
        //e.g. (4*9) + 6 = 42. 42 is the number we add to the array we give to the ship for its location.  
        private int[] cords;
        private int size;
        private int hits;
        private string shipType;//Can store what type of ship something is(e.g. carrier), might be useful down the line
        //2 = Destroyer, 3 = Submarine or Cruiser, 4 = Battleship, 5 = Carrier


        public Ship(int[] cords, string type)
        {
            this.cords = cords;
            size = cords.Length;
            hits = 0;
            shipType = type;

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

        public int[] GetCords()
        {
            return cords;
        }
    }
}