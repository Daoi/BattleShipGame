using System;
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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void doStuff(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlayerOne.Text) || string.IsNullOrWhiteSpace(txtPlayerTwo.Text))
            {
                MessageBox.Show("Enter a name", "Invalid Name");
            }
            else {

                Player playerOne = new Player(txtPlayerOne.Text);
                Player playerTwo = new Player(txtPlayerTwo.Text);

                Hide();
                //frmGameBoard gameBoard = new frmGameBoard();
                frmShipPlacement placementBoard = new frmShipPlacement(playerOne, playerTwo, 1);
                //gameBoard.Show();
                placementBoard.Show();
            }
        }
    }
}
