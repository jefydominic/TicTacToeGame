namespace TicTacToe
{
    partial class GameForm
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.radioTwo = new System.Windows.Forms.RadioButton();
            this.ctrlDisplayBoard = new BoardControl();
            this.ctrlPlayers = new PlayerControl();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(155, 132);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(100, 23);
            this.buttonNewGame.TabIndex = 13;
            this.buttonNewGame.Text = "Start New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.Location = new System.Drawing.Point(46, 18);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(86, 17);
            this.radioSingle.TabIndex = 15;
            this.radioSingle.TabStop = true;
            this.radioSingle.Text = "Single Player";
            this.radioSingle.UseVisualStyleBackColor = true;
            this.radioSingle.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // radioTwo
            // 
            this.radioTwo.AutoSize = true;
            this.radioTwo.Location = new System.Drawing.Point(163, 18);
            this.radioTwo.Name = "radioTwo";
            this.radioTwo.Size = new System.Drawing.Size(83, 17);
            this.radioTwo.TabIndex = 16;
            this.radioTwo.TabStop = true;
            this.radioTwo.Text = "Two Players";
            this.radioTwo.UseVisualStyleBackColor = true;
            this.radioTwo.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // ctrlDisplayBoard
            // 
            this.ctrlDisplayBoard.Location = new System.Drawing.Point(62, 161);
            this.ctrlDisplayBoard.Name = "ctrlDisplayBoard";
            this.ctrlDisplayBoard.Size = new System.Drawing.Size(150, 150);
            this.ctrlDisplayBoard.TabIndex = 25;
            // 
            // ctrlPlayers
            // 
            this.ctrlPlayers.Location = new System.Drawing.Point(12, 41);
            this.ctrlPlayers.Name = "ctrlPlayers";
            this.ctrlPlayers.Size = new System.Drawing.Size(254, 86);
            this.ctrlPlayers.TabIndex = 26;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 311);
            this.Controls.Add(this.ctrlPlayers);
            this.Controls.Add(this.ctrlDisplayBoard);
            this.Controls.Add(this.radioTwo);
            this.Controls.Add(this.radioSingle);
            this.Controls.Add(this.buttonNewGame);
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.RadioButton radioSingle;
        private System.Windows.Forms.RadioButton radioTwo;
        private BoardControl ctrlDisplayBoard;
        private PlayerControl ctrlPlayers;
    }
}

