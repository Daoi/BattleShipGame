namespace BattleShipGame
{
    partial class frmGameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlShipBoard_P2 = new System.Windows.Forms.Panel();
            this.pnlGuessBoard_P2 = new System.Windows.Forms.Panel();
            this.lblShipBoard = new System.Windows.Forms.Label();
            this.lblGuessBoard = new System.Windows.Forms.Label();
            this.btnDoneTurn = new System.Windows.Forms.Button();
            this.pnlShipBoard_P1 = new System.Windows.Forms.Panel();
            this.pnlGuessBoard_P1 = new System.Windows.Forms.Panel();
            this.lblShipInstructions = new System.Windows.Forms.Label();
            this.lblGuessInstructions = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblToPlay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlShipBoard_P2
            // 
            this.pnlShipBoard_P2.Enabled = false;
            this.pnlShipBoard_P2.Location = new System.Drawing.Point(1, 65);
            this.pnlShipBoard_P2.Name = "pnlShipBoard_P2";
            this.pnlShipBoard_P2.Size = new System.Drawing.Size(500, 503);
            this.pnlShipBoard_P2.TabIndex = 0;
            // 
            // pnlGuessBoard_P2
            // 
            this.pnlGuessBoard_P2.Location = new System.Drawing.Point(507, 65);
            this.pnlGuessBoard_P2.Name = "pnlGuessBoard_P2";
            this.pnlGuessBoard_P2.Size = new System.Drawing.Size(500, 503);
            this.pnlGuessBoard_P2.TabIndex = 1;
            // 
            // lblShipBoard
            // 
            this.lblShipBoard.AutoSize = true;
            this.lblShipBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblShipBoard.Location = new System.Drawing.Point(191, 577);
            this.lblShipBoard.Name = "lblShipBoard";
            this.lblShipBoard.Size = new System.Drawing.Size(100, 17);
            this.lblShipBoard.TabIndex = 2;
            this.lblShipBoard.Text = "My Ship Board";
            // 
            // lblGuessBoard
            // 
            this.lblGuessBoard.AutoSize = true;
            this.lblGuessBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGuessBoard.Location = new System.Drawing.Point(697, 579);
            this.lblGuessBoard.Name = "lblGuessBoard";
            this.lblGuessBoard.Size = new System.Drawing.Size(113, 17);
            this.lblGuessBoard.TabIndex = 3;
            this.lblGuessBoard.Text = "My Guess Board";
            // 
            // btnDoneTurn
            // 
            this.btnDoneTurn.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDoneTurn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDoneTurn.Location = new System.Drawing.Point(710, 613);
            this.btnDoneTurn.Name = "btnDoneTurn";
            this.btnDoneTurn.Size = new System.Drawing.Size(85, 31);
            this.btnDoneTurn.TabIndex = 5;
            this.btnDoneTurn.Text = "Done Turn";
            this.btnDoneTurn.UseVisualStyleBackColor = false;
            this.btnDoneTurn.Click += new System.EventHandler(this.btnDoneTurn_Click);
            // 
            // pnlShipBoard_P1
            // 
            this.pnlShipBoard_P1.Enabled = false;
            this.pnlShipBoard_P1.Location = new System.Drawing.Point(1, 65);
            this.pnlShipBoard_P1.Name = "pnlShipBoard_P1";
            this.pnlShipBoard_P1.Size = new System.Drawing.Size(500, 503);
            this.pnlShipBoard_P1.TabIndex = 1;
            // 
            // pnlGuessBoard_P1
            // 
            this.pnlGuessBoard_P1.Location = new System.Drawing.Point(507, 65);
            this.pnlGuessBoard_P1.Name = "pnlGuessBoard_P1";
            this.pnlGuessBoard_P1.Size = new System.Drawing.Size(500, 503);
            this.pnlGuessBoard_P1.TabIndex = 2;
            // 
            // lblShipInstructions
            // 
            this.lblShipInstructions.AutoSize = true;
            this.lblShipInstructions.Location = new System.Drawing.Point(12, 650);
            this.lblShipInstructions.Name = "lblShipInstructions";
            this.lblShipInstructions.Size = new System.Drawing.Size(406, 13);
            this.lblShipInstructions.TabIndex = 9;
            this.lblShipInstructions.Text = "Ship Board: A board that represents your ships and hits / misses from the other p" +
    "layer";
            // 
            // lblGuessInstructions
            // 
            this.lblGuessInstructions.AutoSize = true;
            this.lblGuessInstructions.Location = new System.Drawing.Point(12, 674);
            this.lblGuessInstructions.Name = "lblGuessInstructions";
            this.lblGuessInstructions.Size = new System.Drawing.Size(391, 13);
            this.lblGuessInstructions.TabIndex = 10;
            this.lblGuessInstructions.Text = "Guess Board: A board that represents your hits / misses on the other players ship" +
    "s";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInstructions.Location = new System.Drawing.Point(12, 623);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(84, 17);
            this.lblInstructions.TabIndex = 11;
            this.lblInstructions.Text = "Instructions:";
            // 
            // lblToPlay
            // 
            this.lblToPlay.AutoSize = true;
            this.lblToPlay.Location = new System.Drawing.Point(12, 699);
            this.lblToPlay.Name = "lblToPlay";
            this.lblToPlay.Size = new System.Drawing.Size(448, 13);
            this.lblToPlay.TabIndex = 12;
            this.lblToPlay.Text = "To Play: Click a cell on the guess board to make a hit attempt on a ship, then cl" +
    "ick Done Turn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(442, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Battleship";
            // 
            // frmGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToPlay);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblGuessInstructions);
            this.Controls.Add(this.lblShipInstructions);
            this.Controls.Add(this.pnlShipBoard_P1);
            this.Controls.Add(this.pnlGuessBoard_P1);
            this.Controls.Add(this.pnlShipBoard_P2);
            this.Controls.Add(this.btnDoneTurn);
            this.Controls.Add(this.lblGuessBoard);
            this.Controls.Add(this.lblShipBoard);
            this.Controls.Add(this.pnlGuessBoard_P2);
            this.Name = "frmGameBoard";
            this.Text = "Battleship";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlShipBoard_P2;
        private System.Windows.Forms.Panel pnlGuessBoard_P2;
        private System.Windows.Forms.Label lblShipBoard;
        private System.Windows.Forms.Label lblGuessBoard;
        private System.Windows.Forms.Button btnDoneTurn;
        private System.Windows.Forms.Panel pnlShipBoard_P1;
        private System.Windows.Forms.Panel pnlGuessBoard_P1;
        private System.Windows.Forms.Label lblShipInstructions;
        private System.Windows.Forms.Label lblGuessInstructions;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblToPlay;
        private System.Windows.Forms.Label label1;
    }
}