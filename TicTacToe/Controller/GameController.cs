using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using TicTacToe.Classes.Interfaces;
using static System.Windows.Forms.Control;

namespace TicTacToe.Classes
{
    public enum GameType {Single=1, Double=2}

    //This class will manage between game object and user display
    class GameController
    {

        #region Private Members
        IGame _objGame;//Game object

        GameType _gameType;
        #endregion

        #region Constructor
        //Constuctor, game object injected from Front end
        public GameController()
        {
        }
        #endregion

        #region Properties
        //Return player count
        public int PlayerCount
        {
            get
            {
                return _objGame.PlayerCount;
            }
        }
        //return Game type - Single or double
        public GameType gameType
        {
            get
            {
                return _gameType;
            }
            
        }
        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        //To initialize game board.
        public void InitializeGame()
        {
            IGameBoard gameBoard = new GameBoard();
            _objGame = new Game(gameBoard);
        }
        //Set player
        public void setPlayer(string playerName, int index)
        {
            _objGame.Players[index].PlayerName = playerName;
        }
        //TO start new game
        public GameResult StartNewGame(GameType gameType, string[] playerNames)
        {
            _gameType = gameType;

            if (gameType == GameType.Single)
            {
                _objGame.setPlayer(new Player(playerNames[0]), 0);
                _objGame.setPlayer(new ComputerPlayer(playerNames[1]), 1);
            }
            else
            {
                _objGame.setPlayer(new Player(playerNames[0]), 0);
                _objGame.setPlayer(new Player(playerNames[1]), 1);
            }

            return ClearBoard();
        }
        //Clear game board
        public GameResult ClearBoard()
        {
            _objGame.newGame();

            GameResult gameRslt = new GameResult();

            gameRslt.GameBoard = _objGame.GameBoard;
            gameRslt.WhoWon = null;
            gameRslt.GameOver = _objGame.gameOver;
            gameRslt.LastPlayedPosition = null;
            gameRslt.Players = _objGame.Players;

            return gameRslt;
        }
        //Execute a user play
        public GameResult UserPlay(PlayPosition playPos)
        {
            GameResult gameRslt = new GameResult();

            //Play
            _objGame.Play(playPos);

            //Prepare play result
            gameRslt.LastPlayedPosition = playPos;
            gameRslt.GameBoard = _objGame.GameBoard;
            gameRslt.GameOver = _objGame.gameOver;
            gameRslt.Players = _objGame.Players;

            //Check game over flag
            if (_objGame.gameOver)
            {
                gameRslt.WhoWon = _objGame.wonPlayer;
                gameRslt.GameOver = _objGame.gameOver;
            }
            
            return gameRslt;
        }
        //Find execute computer play
        public GameResult DoComputerPlay()
        {
            GameResult gameRslt = null;
            //At end if next player is computer type then execute next play too.
            if (_objGame.NextPlayer == PlayerNumber.SecondPlayer && _objGame.Players[1].Type == PlayerType.Computer && !_objGame.gameOver)//if 2nd player is a computer
            {
                //Find our next best play
                PlayPosition nextPlay = ((ComputerPlayer)_objGame.Players[1]).GetNextMove(_objGame.GameBoard);

                //Play that move
                gameRslt = this.UserPlay(nextPlay);
            }
            else
            {
                //Otherwise just return current gameboard
                gameRslt = new GameResult();
                gameRslt.GameBoard = _objGame.GameBoard;
            }

            return gameRslt;
        }
        #endregion
    }
}
