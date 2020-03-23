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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblPlayerXsTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlShipBoard_P2
            // 
            this.pnlShipBoard_P2.Enabled = false;
            this.pnlShipBoard_P2.Location = new System.Drawing.Point(1, 65);
            this.pnlShipBoard_P2.Name = "pnlShipBoard_P2";
            this.pnlShipBoard_P2.Size = new System.Drawing.Size(490, 503);
            this.pnlShipBoard_P2.TabIndex = 0;
            // 
            // pnlGuessBoard_P2
            // 
            this.pnlGuessBoard_P2.Location = new System.Drawing.Point(513, 65);
            this.pnlGuessBoard_P2.Name = "pnlGuessBoard_P2";
            this.pnlGuessBoard_P2.Size = new System.Drawing.Size(490, 503);
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
            this.pnlShipBoard_P1.Size = new System.Drawing.Size(490, 503);
            this.pnlShipBoard_P1.TabIndex = 1;
            // 
            // pnlGuessBoard_P1
            // 
            this.pnlGuessBoard_P1.Location = new System.Drawing.Point(513, 65);
            this.pnlGuessBoard_P1.Name = "pnlGuessBoard_P1";
            this.pnlGuessBoard_P1.Size = new System.Drawing.Size(490, 503);
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
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblInstructions.Location = new System.Drawing.Point(12, 619);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(122, 24);
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
            this.label1.Location = new System.Drawing.Point(442, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Battleship";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(492, 79);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(18, 17);
            this.lblA.TabIndex = 14;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(492, 133);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(18, 17);
            this.lblB.TabIndex = 15;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(492, 189);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(18, 17);
            this.lblC.TabIndex = 16;
            this.lblC.Text = "C";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(492, 247);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(19, 17);
            this.lblD.TabIndex = 17;
            this.lblD.Text = "D";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(493, 305);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(18, 17);
            this.lblE.TabIndex = 18;
            this.lblE.Text = "E";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.Location = new System.Drawing.Point(493, 362);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(17, 17);
            this.lblF.TabIndex = 19;
            this.lblF.Text = "F";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(492, 414);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(20, 17);
            this.lblG.TabIndex = 20;
            this.lblG.Text = "G";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(492, 472);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(19, 17);
            this.lblH.TabIndex = 21;
            this.lblH.Text = "H";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.Location = new System.Drawing.Point(495, 525);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(12, 17);
            this.lblI.TabIndex = 22;
            this.lblI.Text = "I";
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(501, 47);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(494, 13);
            this.lblNumbers.TabIndex = 23;
            this.lblNumbers.Text = "          1            2            3            4           5            6      " +
    "      7          8           9    ";
            // 
            // lblPlayerXsTurn
            // 
            this.lblPlayerXsTurn.AutoSize = true;
            this.lblPlayerXsTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerXsTurn.Location = new System.Drawing.Point(29, 18);
            this.lblPlayerXsTurn.Name = "lblPlayerXsTurn";
            this.lblPlayerXsTurn.Size = new System.Drawing.Size(0, 20);
            this.lblPlayerXsTurn.TabIndex = 24;
            // 
            // frmGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblPlayerXsTurn);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGameBoard_FormClosed);
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
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblPlayerXsTurn;
    }
}