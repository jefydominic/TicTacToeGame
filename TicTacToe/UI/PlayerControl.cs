using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Classes;

namespace TicTacToe
{
    public delegate void PlayerNameChangedEventHandler(string[] playerNames);
    public partial class PlayerControl : UserControl, IPlayersScoreBoardDisplay
    {
        public PlayerControl()
        {
            InitializeComponent();
        }

        private void textPlayer_TextChanged(object sender, EventArgs e)
        {
            string[] players = new string[2];

            players[0] = textPlayer1.Text;

            players[1] = textPlayer2.Text;

            PlayerNameChanged(players);
        }

        public PlayerNameChangedEventHandler PlayerNameChanged;

        public void setGameType(GameType type)
        {
            if (type == GameType.Single)
            {
                textPlayer2.ReadOnly = true;
                textPlayer2.Text = "Computer";
            }
            else
            {
                textPlayer2.ReadOnly = false;
            }
        }
        public string[] getPlayerNames()
        {
            string[] players = { textPlayer1.Text, textPlayer2.Text };

            return players;
        }
        public void showGameScore(GameResult rslt)
        {
           textScore1.Text = rslt.Players[0].Score.ToString();

           textScore2.Text = rslt.Players[1].Score.ToString();
        }
    }
}
