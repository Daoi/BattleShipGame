namespace BattleShipGame
{
    partial class frmWelcome
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
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.txtPlayerOne = new System.Windows.Forms.TextBox();
            this.txtPlayerTwo = new System.Windows.Forms.TextBox();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwoName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(237, 307);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(75, 23);
            this.btnPlayGame.TabIndex = 0;
            this.btnPlayGame.Text = "Play Game";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.doStuff);
            // 
            // txtPlayerOne
            // 
            this.txtPlayerOne.Location = new System.Drawing.Point(128, 236);
            this.txtPlayerOne.Name = "txtPlayerOne";
            this.txtPlayerOne.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerOne.TabIndex = 1;
            // 
            // txtPlayerTwo
            // 
            this.txtPlayerTwo.Location = new System.Drawing.Point(348, 236);
            this.txtPlayerTwo.Name = "txtPlayerTwo";
            this.txtPlayerTwo.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerTwo.TabIndex = 2;
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Location = new System.Drawing.Point(29, 239);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(93, 13);
            this.lblPlayerOne.TabIndex = 3;
            this.lblPlayerOne.Text = "Player One Name:";
            // 
            // lblPlayerTwoName
            // 
            this.lblPlayerTwoName.AutoSize = true;
            this.lblPlayerTwoName.Location = new System.Drawing.Point(248, 239);
            this.lblPlayerTwoName.Name = "lblPlayerTwoName";
            this.lblPlayerTwoName.Size = new System.Drawing.Size(94, 13);
            this.lblPlayerTwoName.TabIndex = 4;
            this.lblPlayerTwoName.Text = "Player Two Name:";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 492);
            this.Controls.Add(this.lblPlayerTwoName);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.txtPlayerTwo);
            this.Controls.Add(this.txtPlayerOne);
            this.Controls.Add(this.btnPlayGame);
            this.Name = "frmWelcome";
            this.Text = "Welcome to Battleship";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.TextBox txtPlayerOne;
        private System.Windows.Forms.TextBox txtPlayerTwo;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwoName;
    }
}

