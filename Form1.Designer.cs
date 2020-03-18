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
            this.btnDoStuff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoStuff
            // 
            this.btnDoStuff.Location = new System.Drawing.Point(227, 251);
            this.btnDoStuff.Name = "btnDoStuff";
            this.btnDoStuff.Size = new System.Drawing.Size(75, 23);
            this.btnDoStuff.TabIndex = 0;
            this.btnDoStuff.Text = "Do stuff";
            this.btnDoStuff.UseVisualStyleBackColor = true;
            this.btnDoStuff.Click += new System.EventHandler(this.doStuff);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 492);
            this.Controls.Add(this.btnDoStuff);
            this.Name = "frmWelcome";
            this.Text = "Welcome to Battleship";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoStuff;
    }
}

