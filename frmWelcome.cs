using System;
using System.Windows.Forms;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// April 5th, 2020
// Project 3 - Battleship

namespace BattleShipGame
{
    public partial class frmWelcome : Form
    {
        // Form constructor
        public frmWelcome()
        {
            InitializeComponent();
        }

        // Play game click handler
        // Checks that names are both entered, then loads placement board for P1 if valid
        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlayerOne.Text) || string.IsNullOrWhiteSpace(txtPlayerTwo.Text))
            {
                MessageBox.Show("Enter both player names", "Invalid Name");
            }
            else
            {
                Player playerOne = new Player(txtPlayerOne.Text);
                Player playerTwo = new Player(txtPlayerTwo.Text);

                Hide();
                frmShipPlacement placementBoard = new frmShipPlacement(playerOne, playerTwo, 1);
                placementBoard.Show();
            }
        }

        // Form closed event handler
        private void frmWelcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
