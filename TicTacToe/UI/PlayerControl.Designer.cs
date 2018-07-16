using TicTacToe.Classes;

namespace TicTacToe
{
    partial class PlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textPlayer2 = new System.Windows.Forms.TextBox();
            this.textPlayer1 = new System.Windows.Forms.TextBox();
            this.textScore2 = new System.Windows.Forms.TextBox();
            this.textScore1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPlayer2
            // 
            this.textPlayer2.Location = new System.Drawing.Point(24, 50);
            this.textPlayer2.Name = "textPlayer2";
            this.textPlayer2.ReadOnly = true;
            this.textPlayer2.Size = new System.Drawing.Size(100, 20);
            this.textPlayer2.TabIndex = 20;
            this.textPlayer2.Text = "Computer";
            this.textPlayer2.TextChanged += new System.EventHandler(this.textPlayer_TextChanged);
            // 
            // textPlayer1
            // 
            this.textPlayer1.Location = new System.Drawing.Point(24, 23);
            this.textPlayer1.Name = "textPlayer1";
            this.textPlayer1.Size = new System.Drawing.Size(100, 20);
            this.textPlayer1.TabIndex = 19;
            this.textPlayer1.Text = "Player1";
            this.textPlayer1.TextChanged += new System.EventHandler(this.textPlayer_TextChanged);
            // 
            // textScore2
            // 
            this.textScore2.Location = new System.Drawing.Point(141, 50);
            this.textScore2.Name = "textScore2";
            this.textScore2.ReadOnly = true;
            this.textScore2.Size = new System.Drawing.Size(100, 20);
            this.textScore2.TabIndex = 22;
            // 
            // textScore1
            // 
            this.textScore1.Location = new System.Drawing.Point(141, 23);
            this.textScore1.Name = "textScore1";
            this.textScore1.ReadOnly = true;
            this.textScore1.Size = new System.Drawing.Size(100, 20);
            this.textScore1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Scores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Players";
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textScore2);
            this.Controls.Add(this.textScore1);
            this.Controls.Add(this.textPlayer2);
            this.Controls.Add(this.textPlayer1);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(254, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPlayer2;
        private System.Windows.Forms.TextBox textPlayer1;
        private System.Windows.Forms.TextBox textScore2;
        private System.Windows.Forms.TextBox textScore1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        
    }
}
