using System;
using System.Threading;
using System.Windows.Forms;
using TicTacToe.Classes;
using TicTacToe.Classes.Interfaces;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        GameController _gameController;

        public GameForm()
        {
            try
            {
                InitializeComponent();

                radioSingle.Checked = true;

                _gameController = new GameController();

                _gameController.InitializeGame();

                this.ctrlPlayers.PlayerNameChanged += new PlayerNameChangedEventHandler(this.ctrlPlayers_NameChanged);

                this.ctrlDisplayBoard.UserPlayEvent += new UserPlayEventHandler(this.BoardCtrl_UserPlayEvent);

                StartNewGame();

            }
            catch(Exception oEx)
            {
                MessageBox.Show("Failed to Initialize!");
            }
        }
        //TO start new game
        void StartNewGame()
        {
            string[] players = ctrlPlayers.getPlayerNames();

            GameResult result = null;

            if (radioSingle.Checked)
                result = _gameController.StartNewGame(GameType.Single,players);
            else
                result = _gameController.StartNewGame(GameType.Double,players);

            ctrlDisplayBoard.displayResult(result);
            ctrlPlayers.showGameScore(result);

        }
        //User play event from board control
        private void BoardCtrl_UserPlayEvent(PlayPosition playPos)
        {
            GameResult result = _gameController.UserPlay(playPos);

            //Show result
            ctrlDisplayBoard.displayResult(result);
            ctrlPlayers.showGameScore(result);

            //if 2nd player is a computer
            if (_gameController.gameType == GameType.Single && !result.GameOver)
            {
                //Introduce a delay bewteen first player play and computer play for smooth user experience
                Thread.Sleep(400);

                //DO 2nd computer play
                result = _gameController.DoComputerPlay();

                if (result.LastPlayedPosition != null)
                {
                    ctrlDisplayBoard.displayResult(result);
                    ctrlPlayers.showGameScore(result);
                }
            }
            //If game over then set board for next play
            if (result.GameOver)
            {
                result = _gameController.ClearBoard();
                ctrlDisplayBoard.displayResult(result);
                ctrlPlayers.showGameScore(result);
            }
        }
   
        //Start new game
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
        //Mode change
        private void radioCheckedChanged(object sender, EventArgs e)
        {
            if (_gameController != null)
            {
                bool single = ((RadioButton)this.Controls["radioSingle"]).Checked;

                if (single)
                {
                    ctrlPlayers.setGameType(GameType.Single);
                }
                else
                {
                    ctrlPlayers.setGameType(GameType.Double);
                }

                StartNewGame();
            }

        }
        //Player name changed event from player score board control
        private void ctrlPlayers_NameChanged(string[] playerNames)
        {
            if (_gameController != null)
            {
                _gameController.setPlayer(playerNames[0], 0);

                _gameController.setPlayer(playerNames[1], 1);
            }
        }

    }
}
