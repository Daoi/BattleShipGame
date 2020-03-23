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

        private void doStuff(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlayerOne.Text) || string.IsNullOrWhiteSpace(txtPlayerTwo.Text))
            {
                MessageBox.Show("Enter both player names", "Invalid Name");
            }
            else {
                Player playerOne = new Player(txtPlayerOne.Text);
                Player playerTwo = new Player(txtPlayerTwo.Text);

                Hide();
                //frmGameBoard gameBoard = new frmGameBoard();
                frmShipPlacement placementBoard = new frmShipPlacement(playerOne, playerTwo, 1);
                placementBoard.Show();
                //gameBoard.Show();
            }
        }

        private void frmWelcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
