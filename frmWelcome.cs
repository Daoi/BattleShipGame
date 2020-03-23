using System;
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
                frmShipPlacement placementBoard = new frmShipPlacement(playerOne, playerTwo, 1);
                placementBoard.Show();
            }
        }

        private void frmWelcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
