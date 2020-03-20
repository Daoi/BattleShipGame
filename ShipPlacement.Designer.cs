namespace BattleShipGame
{
    partial class frmShipPlacement
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
            this.pnlShipPlacementBoard = new System.Windows.Forms.Panel();
            this.lblCurrentShip = new System.Windows.Forms.Label();
            this.lblCurrentShipName = new System.Windows.Forms.Label();
            this.lblCurrentPlayerPlacement = new System.Windows.Forms.Label();
            this.btnPlaceLeft = new System.Windows.Forms.Button();
            this.btnPlaceRight = new System.Windows.Forms.Button();
            this.btnPlaceUp = new System.Windows.Forms.Button();
            this.btnPlaceDown = new System.Windows.Forms.Button();
            this.btnNextShip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlShipPlacementBoard
            // 
            this.pnlShipPlacementBoard.Location = new System.Drawing.Point(162, 13);
            this.pnlShipPlacementBoard.Name = "pnlShipPlacementBoard";
            this.pnlShipPlacementBoard.Size = new System.Drawing.Size(617, 553);
            this.pnlShipPlacementBoard.TabIndex = 0;
            // 
            // lblCurrentShip
            // 
            this.lblCurrentShip.AutoSize = true;
            this.lblCurrentShip.Location = new System.Drawing.Point(269, 573);
            this.lblCurrentShip.Name = "lblCurrentShip";
            this.lblCurrentShip.Size = new System.Drawing.Size(124, 13);
            this.lblCurrentShip.TabIndex = 1;
            this.lblCurrentShip.Text = "Select a location for your";
            // 
            // lblCurrentShipName
            // 
            this.lblCurrentShipName.AutoSize = true;
            this.lblCurrentShipName.Location = new System.Drawing.Point(399, 573);
            this.lblCurrentShipName.Name = "lblCurrentShipName";
            this.lblCurrentShipName.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentShipName.TabIndex = 2;
            // 
            // lblCurrentPlayerPlacement
            // 
            this.lblCurrentPlayerPlacement.AutoSize = true;
            this.lblCurrentPlayerPlacement.Location = new System.Drawing.Point(13, 35);
            this.lblCurrentPlayerPlacement.Name = "lblCurrentPlayerPlacement";
            this.lblCurrentPlayerPlacement.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentPlayerPlacement.TabIndex = 3;
            // 
            // btnPlaceLeft
            // 
            this.btnPlaceLeft.Enabled = false;
            this.btnPlaceLeft.Location = new System.Drawing.Point(616, 591);
            this.btnPlaceLeft.Name = "btnPlaceLeft";
            this.btnPlaceLeft.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceLeft.TabIndex = 4;
            this.btnPlaceLeft.Text = "Place Left";
            this.btnPlaceLeft.UseVisualStyleBackColor = true;
            this.btnPlaceLeft.Click += new System.EventHandler(this.btnPlaceLeft_Click);
            // 
            // btnPlaceRight
            // 
            this.btnPlaceRight.Enabled = false;
            this.btnPlaceRight.Location = new System.Drawing.Point(616, 621);
            this.btnPlaceRight.Name = "btnPlaceRight";
            this.btnPlaceRight.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceRight.TabIndex = 5;
            this.btnPlaceRight.Text = "Place Right";
            this.btnPlaceRight.UseVisualStyleBackColor = true;
            this.btnPlaceRight.Click += new System.EventHandler(this.btnPlaceRight_Click);
            // 
            // btnPlaceUp
            // 
            this.btnPlaceUp.Enabled = false;
            this.btnPlaceUp.Location = new System.Drawing.Point(724, 590);
            this.btnPlaceUp.Name = "btnPlaceUp";
            this.btnPlaceUp.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceUp.TabIndex = 6;
            this.btnPlaceUp.Text = "Place Up";
            this.btnPlaceUp.UseVisualStyleBackColor = true;
            this.btnPlaceUp.Click += new System.EventHandler(this.btnPlaceUp_Click);
            // 
            // btnPlaceDown
            // 
            this.btnPlaceDown.Enabled = false;
            this.btnPlaceDown.Location = new System.Drawing.Point(724, 620);
            this.btnPlaceDown.Name = "btnPlaceDown";
            this.btnPlaceDown.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceDown.TabIndex = 7;
            this.btnPlaceDown.Text = "Place Down";
            this.btnPlaceDown.UseVisualStyleBackColor = true;
            this.btnPlaceDown.Click += new System.EventHandler(this.btnPlaceDown_Click);
            // 
            // btnNextShip
            // 
            this.btnNextShip.Enabled = false;
            this.btnNextShip.Location = new System.Drawing.Point(174, 573);
            this.btnNextShip.Name = "btnNextShip";
            this.btnNextShip.Size = new System.Drawing.Size(75, 23);
            this.btnNextShip.TabIndex = 8;
            this.btnNextShip.Text = "Next Ship";
            this.btnNextShip.UseVisualStyleBackColor = true;
            this.btnNextShip.Click += new System.EventHandler(this.btnNextShip_Click);
            // 
            // frmShipPlacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnNextShip);
            this.Controls.Add(this.btnPlaceDown);
            this.Controls.Add(this.btnPlaceUp);
            this.Controls.Add(this.btnPlaceRight);
            this.Controls.Add(this.btnPlaceLeft);
            this.Controls.Add(this.lblCurrentPlayerPlacement);
            this.Controls.Add(this.lblCurrentShipName);
            this.Controls.Add(this.lblCurrentShip);
            this.Controls.Add(this.pnlShipPlacementBoard);
            this.Name = "frmShipPlacement";
            this.Text = "Ship Placement";
            this.Load += new System.EventHandler(this.frmShipPlacement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlShipPlacementBoard;
        private System.Windows.Forms.Label lblCurrentShip;
        private System.Windows.Forms.Label lblCurrentShipName;
        private System.Windows.Forms.Label lblCurrentPlayerPlacement;
        private System.Windows.Forms.Button btnPlaceLeft;
        private System.Windows.Forms.Button btnPlaceRight;
        private System.Windows.Forms.Button btnPlaceUp;
        private System.Windows.Forms.Button btnPlaceDown;
        private System.Windows.Forms.Button btnNextShip;
    }
}