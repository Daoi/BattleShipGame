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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlShipPlacementBoard
            // 
            this.pnlShipPlacementBoard.Location = new System.Drawing.Point(137, 59);
            this.pnlShipPlacementBoard.Name = "pnlShipPlacementBoard";
            this.pnlShipPlacementBoard.Size = new System.Drawing.Size(617, 553);
            this.pnlShipPlacementBoard.TabIndex = 0;
            // 
            // lblCurrentShip
            // 
            this.lblCurrentShip.AutoSize = true;
            this.lblCurrentShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCurrentShip.Location = new System.Drawing.Point(226, 626);
            this.lblCurrentShip.Name = "lblCurrentShip";
            this.lblCurrentShip.Size = new System.Drawing.Size(186, 17);
            this.lblCurrentShip.TabIndex = 1;
            this.lblCurrentShip.Text = "Place starting point for your:";
            // 
            // lblCurrentShipName
            // 
            this.lblCurrentShipName.AutoSize = true;
            this.lblCurrentShipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCurrentShipName.Location = new System.Drawing.Point(226, 647);
            this.lblCurrentShipName.Name = "lblCurrentShipName";
            this.lblCurrentShipName.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentShipName.TabIndex = 2;
            // 
            // lblCurrentPlayerPlacement
            // 
            this.lblCurrentPlayerPlacement.AutoSize = true;
            this.lblCurrentPlayerPlacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCurrentPlayerPlacement.Location = new System.Drawing.Point(134, 20);
            this.lblCurrentPlayerPlacement.Name = "lblCurrentPlayerPlacement";
            this.lblCurrentPlayerPlacement.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentPlayerPlacement.TabIndex = 3;
            // 
            // btnPlaceLeft
            // 
            this.btnPlaceLeft.Enabled = false;
            this.btnPlaceLeft.Location = new System.Drawing.Point(575, 637);
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
            this.btnPlaceRight.Location = new System.Drawing.Point(575, 667);
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
            this.btnPlaceUp.Location = new System.Drawing.Point(683, 636);
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
            this.btnPlaceDown.Location = new System.Drawing.Point(683, 666);
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
            this.btnNextShip.Location = new System.Drawing.Point(123, 619);
            this.btnNextShip.Name = "btnNextShip";
            this.btnNextShip.Size = new System.Drawing.Size(85, 29);
            this.btnNextShip.TabIndex = 8;
            this.btnNextShip.Text = "Next Ship";
            this.btnNextShip.UseVisualStyleBackColor = true;
            this.btnNextShip.Click += new System.EventHandler(this.btnNextShip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(397, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Battleship";
            // 
            // frmShipPlacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 729);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}