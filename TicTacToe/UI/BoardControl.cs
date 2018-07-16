using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Classes.Interfaces;
using TicTacToe.Classes;

namespace TicTacToe
{
    public delegate void UserPlayEventHandler(PlayPosition playPos);
    public partial class BoardControl : UserControl,IGameBoardDisplay
    {
        public BoardControl()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            PlayPosition pos = this.getPlayPosition((Control)sender);

            //Raise Play event
            UserPlayEvent(pos);
        }

        public event UserPlayEventHandler UserPlayEvent;

        public void displayBoard(IGameBoard board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    displayACell(board, i, j);
                }
            }
        }

        public void disableBoard(IGameBoard board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    disableACell(board, i, j);
                }
            }
        }

        public void enableBoard(IGameBoard board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    enableACell(board, i, j);
                }
            }
        }
        public void displayACell(IGameBoard board, int x, int y)
        {
            int b = ((x * 3) + y) + 1;
            string strBut = "b" + b.ToString();
            ((Button)this.Controls["groupBox"].Controls[strBut]).Text = board.Values[x][y].Value.ToString();
            ((Button)this.Controls["groupBox"].Controls[strBut]).BackColor = board.Values[x][y].cellColor;
        }
        public void disableACell(IGameBoard board, int x, int y)
        {
            int b = ((x * 3) + y) + 1;
            string strBut = "b" + b.ToString();
            ((Button)this.Controls["groupBox"].Controls[strBut]).Enabled = false;
        }
        public void enableACell(IGameBoard board, int x, int y)
        {
            int b = ((x * 3) + y) + 1;
            string strBut = "b" + b.ToString();
            ((Button)this.Controls["groupBox"].Controls[strBut]).Enabled = true;
        }
        public PlayPosition getPlayPosition(Control sender)
        {
            PlayPosition playPos = new PlayPosition();

            int controlNumber = 0;

            controlNumber = int.Parse(sender.Name.Substring(1));

            controlNumber--;

            playPos.X = controlNumber / 3;

            playPos.Y = controlNumber % 3;

            return playPos;
        }
        public void displayResult(GameResult result)
        {
            if (result.GameOver)
            {
                //Display full board
                displayBoard(result.GameBoard);
                //Disable full board
                disableBoard(result.GameBoard);

                if (result.WhoWon != null)
                {
                    MessageBox.Show(result.WhoWon.PlayerName + " wins!");
                }
                else
                {
                    MessageBox.Show("Its a tie, play again!");
                }

            }
            else
            {
                if (result.LastPlayedPosition != null)
                {
                    //Display played cell
                    displayACell(result.GameBoard, result.LastPlayedPosition.X, result.LastPlayedPosition.Y);

                    //Disable played cell
                    disableACell(result.GameBoard, result.LastPlayedPosition.X, result.LastPlayedPosition.Y);
                }
                else
                {
                    //Display full board
                    displayBoard(result.GameBoard);
                    //Enable full board
                    enableBoard(result.GameBoard);
                }
            }
        }
        
    }
}
