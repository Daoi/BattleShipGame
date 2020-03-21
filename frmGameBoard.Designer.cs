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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.pnlShipBoard = new System.Windows.Forms.Panel();
            this.pnlGuessBoard = new System.Windows.Forms.Panel();
            this.lblShipBoard = new System.Windows.Forms.Label();
            this.lblGuessBoard = new System.Windows.Forms.Label();
            this.lblCurrentPlayersTurn = new System.Windows.Forms.Label();
            this.btnDoneTurn = new System.Windows.Forms.Button();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblShipImageOne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShipBoard
            // 
            this.pnlShipBoard.Location = new System.Drawing.Point(1, 1);
            this.pnlShipBoard.Name = "pnlShipBoard";
            this.pnlShipBoard.Size = new System.Drawing.Size(500, 503);
            this.pnlShipBoard.TabIndex = 0;
            // 
            // pnlGuessBoard
            // 
            this.pnlGuessBoard.Location = new System.Drawing.Point(507, 1);
            this.pnlGuessBoard.Name = "pnlGuessBoard";
            this.pnlGuessBoard.Size = new System.Drawing.Size(500, 503);
            this.pnlGuessBoard.TabIndex = 1;
            // 
            // lblShipBoard
            // 
            this.lblShipBoard.AutoSize = true;
            this.lblShipBoard.Location = new System.Drawing.Point(128, 507);
            this.lblShipBoard.Name = "lblShipBoard";
            this.lblShipBoard.Size = new System.Drawing.Size(59, 13);
            this.lblShipBoard.TabIndex = 2;
            this.lblShipBoard.Text = "Ship Board";
            // 
            // lblGuessBoard
            // 
            this.lblGuessBoard.AutoSize = true;
            this.lblGuessBoard.Location = new System.Drawing.Point(723, 507);
            this.lblGuessBoard.Name = "lblGuessBoard";
            this.lblGuessBoard.Size = new System.Drawing.Size(68, 13);
            this.lblGuessBoard.TabIndex = 3;
            this.lblGuessBoard.Text = "Guess Board";
            // 
            // lblCurrentPlayersTurn
            // 
            this.lblCurrentPlayersTurn.AutoSize = true;
            this.lblCurrentPlayersTurn.Location = new System.Drawing.Point(465, 427);
            this.lblCurrentPlayersTurn.Name = "lblCurrentPlayersTurn";
            this.lblCurrentPlayersTurn.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentPlayersTurn.TabIndex = 4;
            // 
            // btnDoneTurn
            // 
            this.btnDoneTurn.Location = new System.Drawing.Point(921, 694);
            this.btnDoneTurn.Name = "btnDoneTurn";
            this.btnDoneTurn.Size = new System.Drawing.Size(75, 23);
            this.btnDoneTurn.TabIndex = 5;
            this.btnDoneTurn.Text = "Done Turn";
            this.btnDoneTurn.UseVisualStyleBackColor = true;
            this.btnDoneTurn.Click += new System.EventHandler(this.btnDoneTurn_Click);
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(466, 507);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentPlayer.TabIndex = 6;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 584);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(35, 13);
            this.lblInstructions.TabIndex = 7;
            this.lblInstructions.Text = "label1";
            // 
            // lblShipImageOne
            // 
            this.lblShipImageOne.Location = new System.Drawing.Point(465, 661);
            this.lblShipImageOne.Name = "lblShipImageOne";
            this.lblShipImageOne.Size = new System.Drawing.Size(100, 23);
            this.lblShipImageOne.TabIndex = 8;
            // 
            // frmGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblShipImageOne);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.pnlShipBoard);
            this.Controls.Add(this.btnDoneTurn);
            this.Controls.Add(this.lblCurrentPlayersTurn);
            this.Controls.Add(this.lblGuessBoard);
            this.Controls.Add(this.lblShipBoard);
            this.Controls.Add(this.pnlGuessBoard);
            this.Name = "frmGameBoard";
            this.Text = "Battleship";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Panel pnlShipBoard;
        private System.Windows.Forms.Panel pnlGuessBoard;
        private System.Windows.Forms.Label lblShipBoard;
        private System.Windows.Forms.Label lblGuessBoard;
        private System.Windows.Forms.Label lblCurrentPlayersTurn;
        private System.Windows.Forms.Button btnDoneTurn;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblShipImageOne;
    }
}